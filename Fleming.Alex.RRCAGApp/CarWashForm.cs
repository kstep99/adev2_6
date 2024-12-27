using Fleming.Alex.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fleming.Alex.RRCAGApp
{
    /// <summary>
    /// A form for calculating the cost of car wash packages.
    /// </summary>
    public partial class CarWashForm : Form
    {
        List<Service> services;

        BindingSource fragranceBindingSource;
        BindingSource packageBindingSource;
        BindingSource interiorBindingSource;
        BindingSource exteriorBindingSource;
        BindingSource carWashInvoiceBindingSource;

        BindingList<Fragrance> fragranceBindingList;
        BindingList<Package> packageBindingList;
        BindingList<Service> interioirServiceBindingList;
        BindingList<Service> exteriorServiceBindingList;
        CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.5M);

        /// <summary>
        /// Initializes an instance of the CarWashForm class.
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();
            InitializeFragranceList();
            InitializePackageList();
            InitializeServiceLists();

            this.Load += CarWashForm_Load;
        }
 
        private void CarWashForm_Load(object sender, EventArgs e)
        
        {
            this.generateInvoiceToolStripMenuItem.Click += GenerateInvoiceToolStripMenuItem_Click;
            this.exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.packageBindingSource.CurrentChanged += PackageBindingSource_CurrentChanged;
            
            BindData();
            BindControls();
            UpdateServices();
        }

        private void fragranceBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateServices();
            Fragrance currentFragrance = (Fragrance)this.fragranceBindingSource.Current;
            this.carWashInvoice.FragranceCost = currentFragrance.Price;
            ((Fragrance)this.services[0]).Description = currentFragrance.Description;

        }

        private void CboFragrance_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateServices();
            Fragrance currentFragrance = (Fragrance)this.fragranceBindingSource.Current;
            this.carWashInvoice.FragranceCost = currentFragrance.Price;
            ((Fragrance)this.services[0]).Description = currentFragrance.Description;
        }

        private void PackageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateServices();
            this.carWashInvoice.PackageCost = ((Package)this.packageBindingSource.Current).Price;
        }

        private void InitializePackageList()
        {
            this.packageBindingList = new BindingList<Package>();
            this.packageBindingSource = new BindingSource();
            this.packageBindingSource.DataSource = this.packageBindingList;

            // Create packages and add to list. 
            Package defaultPackage = new Package("Standard", 7.5M, 1);
            this.packageBindingList.Add(defaultPackage);
            this.packageBindingList.Add(new Package("Deluxe", 15, 2));
            this.packageBindingList.Add(new Package("Executive", 35, 3));
            this.packageBindingList.Add(new Package("Luxury", 55, 4));

            this.cboPackage.SelectedItem = defaultPackage;
            //MessageBox.Show(String.Format("Loaded {0} Packages!", defaultPackage.Description));

        }


    void InitializeFragranceList()
        {
            string caption = "Data File Error";
            try
            {
                
                FileStream stream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                // BindingList + BindingSource pattern for collection data sources. 
                this.fragranceBindingList = new BindingList<Fragrance>();
                this.fragranceBindingSource = new BindingSource();
                this.fragranceBindingSource.DataSource = this.fragranceBindingList;

                // Add 'No Charge' Default Value...
                // Storing for use in setting default SelectedItem...
                Fragrance defaultFragrance = new Fragrance("Pine", 0);

                fragranceBindingList.Add(defaultFragrance);
                while (reader.Peek() != -1)
                {
                    string input = reader.ReadLine();
                    string[] values = input.Split(',');
                    string name = values[0];
                    decimal price = decimal.Parse(values[1]);
                    fragranceBindingList.Add(new Fragrance(name, price));
                }
                reader.Close();
                stream.Dispose();

                // This updates the currently selected fragrance in the combo box
                // (So the lstInterior population has the right initialization value)
                this.cboFragrance.SelectedItem = defaultFragrance;

            }
            catch (FileNotFoundException)
            {
                // If Fragrance Data not found, display Message box. 
                MessageBox.Show("Fragrances data file not found.", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                // Any other exception.
                MessageBox.Show("An error occurred while reading the Data File.", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void InitializeServiceLists()
        {
            // Build collections containing all SERVICE options.
            // This collection is used to filter the package-specific collections that populate listbox control 

            // Initialize master List.
            this.services = new List<Service>();
            this.services.Add((Fragrance)this.fragranceBindingSource.Current);
            this.services.Add(new Service("Shampoo Carpets", 2, true));
            this.services.Add(new Service("Shampoo Upholstery", 3, true));
            this.services.Add(new Service("Interior Protection Coat", 4, true));
            this.services.Add(new Service("Hand Wash", 1, false));
            this.services.Add(new Service("Hand Wax", 2, false));
            this.services.Add(new Service("Wheel Polish", 3, false));
            this.services.Add(new Service("Detail Engine Compartment", 4, false));

            // Initialize interior binding source + list.
            this.interioirServiceBindingList = new BindingList<Service>();
            this.interiorBindingSource = new BindingSource();
            this.interiorBindingSource.DataSource = interioirServiceBindingList;

            // Initialize exterior binding source + list.
            this.exteriorServiceBindingList = new BindingList<Service>();
            this.exteriorBindingSource = new BindingSource();
            this.exteriorBindingSource.DataSource = exteriorServiceBindingList;

            
        }

        private void UpdateServices()
        {
            // First we find out what Package is currently selected. 

            // What is the service level of the currently selected package?
            // Default = 1 (STANDARD)
            // Set it to 1 before checking because... if no current item is found
            // It will have an invalid value. 
            int currentServiceLevel = 1;

            // Corresponds to currently selected package type:
            // 1 = Standard, 2 = Deluxe, 3 = Executive, 4 = Luxury

            // If the following evaluates to true, a package HAS been selected. 
            // (Position initializes to -1 before an item is selected)
            if (this.packageBindingSource.Position > 0)
            {    
                currentServiceLevel = ((Package)this.packageBindingSource.Current).ServiceLevel;
            }

            this.packageBindingSource.CurrentChanged += PackageBindingSource_CurrentChanged;
            this.cboFragrance.SelectedValueChanged += CboFragrance_SelectedValueChanged1;
            
            //`          this.fragranceBindingSource.CurrentChanged += FragranceBindingSource_CurrentChanged;
            // Check to see any changes have occurred - 
            // If servicelevel = number of services already displayed, no changes.
            if (currentServiceLevel != interioirServiceBindingList.Count)
            {
                this.interioirServiceBindingList.Clear();
                this.exteriorServiceBindingList.Clear();

                foreach (var service in services)
                {
                    if (service.HighestServiceLevel <= currentServiceLevel)
                    {
                        if (service.IsInterior)
                        {
                            interioirServiceBindingList.Add(service);
                        }
                        else
                        {
                            exteriorServiceBindingList.Add(service);
                        }
                    }
                }
            }
            // Set this to make sure the new values are updated in the binding source 
            //interioirServiceBindingList.ResetBinders(false);
            //this.exteriorBindingSource;

        }

        private void CboFragrance_SelectedValueChanged1(object sender, EventArgs e)
        {
            Fragrance currentFragrance = (Fragrance)this.fragranceBindingSource.Current;
            ((Fragrance)interiorBindingSource.Current).Description = ((Fragrance)cboFragrance.SelectedItem).Description;
            this.carWashInvoice.FragranceCost = currentFragrance.Price;
            interiorBindingSource.ResetBindings(false);
        }

        private void BindControls()
        {
            // Simple Binding (to Text/Label controls)
            this.carWashInvoiceBindingSource = new BindingSource();
            this.carWashInvoiceBindingSource.DataSource = this.carWashInvoice;

            Binding subTotal = new Binding("Text", this.carWashInvoiceBindingSource, "SubTotal");
            subTotal.FormattingEnabled = true;
            subTotal.FormatString = "C";
            this.lblSubtotalOutput.DataBindings.Add(subTotal);

            Binding GST = new Binding("Text", this.carWashInvoiceBindingSource, "ProvincialSalesTaxCharged");
            GST.FormattingEnabled = true;
            GST.FormatString = "N2";
            this.lblGstOutput.DataBindings.Add(GST);

            Binding PST = new Binding("Text", this.carWashInvoiceBindingSource, "GoodsAndServicesTaxCharged");
            PST.FormattingEnabled = true;
            PST.FormatString = "N2";
            this.lblPstOutput.DataBindings.Add(PST);

            Binding Total = new Binding("Text", this.carWashInvoiceBindingSource, "Total");
            Total.FormattingEnabled = true;
            Total.FormatString = "C";
            this.lblTotalOutput.DataBindings.Add(Total);
            carWashInvoiceBindingSource.ResetBindings(false);
            this.cboFragrance.SelectedValueChanged += CboFragrance_SelectedValueChanged;
            this.fragranceBindingSource.CurrentChanged += fragranceBindingSource_CurrentChanged;
        }

        private void BindData()
        {
            // Fragrance Combo Box Binding
            // Collection: Dictionary<string, decimal> fragrances
            this.cboFragrance.DataSource = fragranceBindingSource;
            this.cboFragrance.DisplayMember = "Description";
            this.cboFragrance.ValueMember = "Price";

            // Package Combo Box Binding
            // Collection: List<Package> packages
            // Type: Package(string description, decimal Price)
            this.cboPackage.DataSource = this.packageBindingSource;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.ValueMember = "Price";

            // Interior List Box Binding
            // Collection: List<Service>
            this.lstInteriorBox.DataSource = this.interiorBindingSource;
            this.lstInteriorBox.DisplayMember= "ToString";
           
            // Interior List Box Binding
            // Collection: List<Service>
            this.lstExteriorBox.DataSource = this.exteriorBindingSource;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm form;
            form = new CarWashInvoiceForm(carWashInvoice);
            form.ShowDialog();
        }
    }
}
/*
 * Name: Alex Fleming
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 10/27/2021
 * Updated: 11/14/2021 
 */
using Fleming.Alex.Business;
using System;
using System.Windows.Forms;
using RRCAG.Data;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Fleming.Alex.RRCAGApp
{
    public partial class VehicleSalesQuoteForm : Form
    {
        public SalesQuote salesQuote;
        public BindingSource vehicleSource = new BindingSource();
        public BindingList<Vehicle> vehicleBindingList;
        public BindingSource source = new BindingSource();
        public VehicleSalesQuoteForm()
        {
            InitializeComponent();

            this.vehicleSource.CurrentChanged += VehicleSource_CurrentChanged;
            this.Load += VehicleSalesQuoteForm_Load;
        }

        private void VehicleSource_CurrentChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ay");   
        }

        private void MnuViewVehicleInformation_Click(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                VehicleInformationForm form;
                form = new VehicleInformationForm((Vehicle)this.vehicleSource.Current);
                form.ShowDialog();
            }
        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboVehicleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
         
            // if selected vehicle changes and salesquote exists, reset outputs.
            if (salesQuote != null)
            {
                source.ResetBindings(false);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            string message = "Do you want to reset the form?";
            string caption = "Reset Form";

            DialogResult result = MessageBox.Show(message,
                caption,
                MessageBoxButtons.YesNo,    // Dialog/Message Box Buttons are of MessageBoxButtons type 
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                // Clear SalesQuote instance from memory. 
                salesQuote = null;

            }
        }


        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                Update_MonthlyPayment();
            }

        }

        /// <summary>
        /// Handles the click event for the custom finish radio button.
        /// </summary>
        private void ExteriorFinishRadioButton_Click(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                Update_ExteriorFinish();
            }

        }

        /// <summary>
        ///  Handles the click event for the computer navigation check box.
        /// </summary>
        private void AccessoriesCheckbox_Click(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                Update_AccessoriesChosen();
            }
        }

        /// <summary>
        /// Handles the load event of this form.
        /// </summary>
        private void VehicleSalesQuoteForm_Load(object sender, EventArgs e)
        {
            // Pull Data & Initialize BindingSource
            // Initialize DataSource (Vehicle from RRCAG.Data)
            List<Vehicle> vehicles = DataRetriever.GetVehicles();
            this.vehicleSource = new BindingSource();
            this.vehicleSource.DataSource = this.vehicleBindingList;
            vehicleBindingList = new BindingList<Vehicle>(vehicles);
 
            this.cboVehicleComboPrice.CausesValidation = true;
            this.txtTradeInValueBox.CausesValidation = true;

            // Update Summary For Options...
            this.chkStereoSystemCheckbox.Click += AccessoriesCheckbox_Click; ;
            this.chkLeatherInteriorCheckbox.Click += AccessoriesCheckbox_Click;
            this.chkComputerNavigationCheckbox.Click += AccessoriesCheckbox_Click;
            this.radStandardFinish.Click += ExteriorFinishRadioButton_Click;
            this.radPearlizedFinish.Click += ExteriorFinishRadioButton_Click;
            this.radCustomDetailingFinish.Click += ExteriorFinishRadioButton_Click;

            // Update Summary For Number of Years and Annual Interest Rate
            this.nudNumberOfYears.ValueChanged += NumericUpDown_ValueChanged;
            this.numericUpDown1.ValueChanged += NumericUpDown_ValueChanged;

            this.btnCalculateQuote.Click += BtnClick_Validating;
            this.btnReset.Click += BtnReset_Click;


            // Event Listener for cboVehicle.SelectedValueChanged... 
            // If a vehicle is selected, enable the view > vehicle information menu item. 


            // Menu Clicks

            // Event Listener for menuviewvehicleinfo.click > create vehicle information modal form. 
            this.mnuViewVehicleInformation.Click += MnuViewVehicleInformation_Click;
            this.mnuFileClose.Click += MnuFileClose_Click;
            BindVehicleData();

        }

        private void BtnClick_Validating(object sender, EventArgs e)
        {
            int tradeInAmount = 0;
            
            bool flag = false;
            if (this.vehicleSource.Current != null)
            {
                if (string.IsNullOrWhiteSpace(txtTradeInValueBox.Text))
                {
                    errorProvider1.SetError(txtTradeInValueBox, txtTradeInValueBox.Tag + " is a required field.");
                }
                else
                {
                    errorProvider1.SetError(txtTradeInValueBox, "");
                    try
                    {
                        tradeInAmount = int.Parse(txtTradeInValueBox.Text);
                        errorProvider1.SetError(txtTradeInValueBox, "");
                        if (tradeInAmount < ((Vehicle)this.vehicleSource.Current).BasePrice)
                        {
                            errorProvider1.SetError(txtTradeInValueBox, "");
                            flag = true;
                        }
                        else
                        {
                            errorProvider1.SetError(txtTradeInValueBox, txtTradeInValueBox.Tag + " cannot exceed vehicle sales price.");
                        }
                    }
                    catch (FormatException)
                    {
                        errorProvider1.SetError(txtTradeInValueBox, txtTradeInValueBox.Tag + " cannot contain special characters or letters");
                    }
                }
            }
            if (flag)
            {
                if (salesQuote == null)
                { 
                    decimal vehiclePrice = vehicleBindingList[this.cboVehicleComboPrice.SelectedIndex].BasePrice;
                    salesQuote = new SalesQuote((decimal)this.cboVehicleComboPrice.SelectedValue, tradeInAmount, 0.12M);
                    cboVehicleComboPrice.SelectedValueChanged += CboVehicleComboBox_SelectedValueChanged;
                    
                }
                BindControls();

                UpdateAll();
            }
            // New Vehicle will be selected. 
        }


        private void UpdateAll()
        {
            Update_AccessoriesChosen();
            Update_ExteriorFinish();
            Update_MonthlyPayment();
        }

        private void BindVehicleData()
        {
            vehicleSource.DataSource = vehicleBindingList;
            cboVehicleComboPrice.SelectedIndex = -1;
            this.cboVehicleComboPrice.DataSource = this.vehicleSource;
            this.cboVehicleComboPrice.DisplayMember = "StockID";
            this.cboVehicleComboPrice.ValueMember = "BasePrice";
            //this.vehicleSource.ResetBindings(true);
        }

        private void BindControls()
        {

                this.source = new BindingSource();
                this.source.DataSource = salesQuote;

                //Binding optionsBinding = new Binding("Text", source, "");
                //this.lblSummaryOptionEntryBox.DataBindings.Add(optionsBinding);

                Binding subTotalBinding = new Binding("Text", source, "SubTotal");
                this.lblSummarySubTotalEntryBox.DataBindings.Add(subTotalBinding);

                Binding SalesTaxBinding = new Binding("Text", source, "SalesTax");
                this.lblSummarySalesTaxEntryBox.DataBindings.Add(SalesTaxBinding);

                Binding totalBinding = new Binding("Text", source, "Total");
                this.lblSummaryTotalTextBox.DataBindings.Add(totalBinding);

                Binding amountDueBinding = new Binding("Text", source, "AmountDue");
                this.lblSummaryAmountDueTextbox.DataBindings.Add(amountDueBinding);

                Binding vehiclePriceBinding = new Binding("Text", source, "VehicleSalePrice");
                this.lblSummaryVehiclePriceEntryBox.DataBindings.Add(vehiclePriceBinding);

                Binding tradeInBinding = new Binding("Text", source, "TradeInAmount");
                this.lblSummaryTradeinEntryBox.DataBindings.Add(tradeInBinding);

                source.DataSourceChanged += Source_DataSourceChanged;
                //Binding getMonthlyPayment = new Binding("Text", idksorry ,GetMonthlyPayment");
                //this.lblTextboxMonthlyPayment.DataBindings.Add(getMonthlyPayment);
        

        }

        private void Source_DataSourceChanged(object sender, EventArgs e)
        {
            source.ResetBindings(false);
        }

        private void Update_MonthlyPayment()
        {
            decimal rate = (this.numericUpDown1.Value) / 100;
            decimal numberOfPaymentPeriods = this.nudNumberOfYears.Value;
            this.lblTextboxMonthlyPayment.Text = (Financial.GetPayment(rate, (int)numberOfPaymentPeriods, salesQuote.AmountDue)).ToString("C2");
        }

        private void Update_ExteriorFinish()
        {
            if (this.radCustomDetailingFinish.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;
            }
            else if (this.radPearlizedFinish.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            else if (this.radStandardFinish.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;
            }
        }

        private void Update_AccessoriesChosen()
        {

            {
                bool stereoSelected = this.chkStereoSystemCheckbox.Checked;
                bool leatherIntSelected = this.chkLeatherInteriorCheckbox.Checked;
                bool computerNavigationSelected = this.chkComputerNavigationCheckbox.Checked;

                int optionCount = 0;

                if (stereoSelected)
                {
                    optionCount += 1;
                }
                if (leatherIntSelected)
                {
                    optionCount += 2;
                }
                if (computerNavigationSelected)
                {
                    optionCount += 5;
                }

                switch (optionCount)
                {
                    case 0:
                        salesQuote.AccessoriesChosen = Accessories.None;
                        break;
                    case 1:
                        salesQuote.AccessoriesChosen = Accessories.StereoSystem;
                        break;
                    case 2:
                        salesQuote.AccessoriesChosen = Accessories.LeatherInterior;
                        break;
                    case 3:
                        salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;
                        break;
                    case 5:
                        salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;
                        break;
                    case 6:
                        salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;
                        break;
                    case 7:
                        salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
                        break;
                    case 8:
                        salesQuote.AccessoriesChosen = Accessories.All;
                        break;
                }

            }


        }
    }
}

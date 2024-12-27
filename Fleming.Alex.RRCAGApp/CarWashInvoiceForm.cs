using Fleming.Alex.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fleming.Alex.RRCAGApp
{
    public partial class CarWashInvoiceForm : Fleming.Alex.RRCAGApp.InvoiceForm
    {
        public CarWashInvoice CarWashInvoice { get; set; }
        public CarWashInvoiceForm(CarWashInvoice carWashInvoice)
        {
            this.CarWashInvoice = carWashInvoice;
            InitializeComponent();

           
            BindingSource source = new BindingSource();
            source.DataSource = this.CarWashInvoice;
          
            Binding packagePrice = new Binding("Text", source, "PackageCost");
            this.lblPackagePriceOutput.DataBindings.Add(packagePrice);
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "C";

            Binding fragrancePrice = new Binding("Text", source, "FragranceCost");
            this.lblFragranceOutput.DataBindings.Add(fragrancePrice);
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "N";

            Binding subTotalCarWashInvoice = new Binding("Text", source, "Subtotal");
            this.lblSubtotalOutput.DataBindings.Add(subTotalCarWashInvoice);
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "C";

            // How to create composite datamember ??? 
            Binding taxesCarWashInvoice = new Binding("Text", source, "ProvincialSalesTaxCharged");
            this.lblTaxesOutput.DataBindings.Add(taxesCarWashInvoice);
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "N";

            Binding totalCarWashInvoice = new Binding("Text", source, "Total");
            this.lblTotalOutput.DataBindings.Add(totalCarWashInvoice);
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "C";

        }
    }
}

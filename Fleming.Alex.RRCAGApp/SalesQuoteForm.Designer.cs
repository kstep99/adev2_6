
namespace Fleming.Alex.RRCAGApp
{
    partial class VehicleSalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVehiclesSalePrice = new System.Windows.Forms.Label();
            this.txtVehiclesSalePriceBox = new System.Windows.Forms.TextBox();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValueBox = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigationCheckbox = new System.Windows.Forms.CheckBox();
            this.chkLeatherInteriorCheckbox = new System.Windows.Forms.CheckBox();
            this.chkStereoSystemCheckbox = new System.Windows.Forms.CheckBox();
            this.grpExteriorFInishRadios = new System.Windows.Forms.GroupBox();
            this.radCustomDetailingFinish = new System.Windows.Forms.RadioButton();
            this.radPearlizedFinish = new System.Windows.Forms.RadioButton();
            this.radStandardFinish = new System.Windows.Forms.RadioButton();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblTextboxMonthlyPayment = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.nudNumberOfYears = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblSummaryTradeinEntryBox = new System.Windows.Forms.Label();
            this.lblSummaryTotalTextBox = new System.Windows.Forms.Label();
            this.lblSummarySalesTaxEntryBox = new System.Windows.Forms.Label();
            this.lblSummarySubTotalEntryBox = new System.Windows.Forms.Label();
            this.lblSummaryOptionEntryBox = new System.Windows.Forms.Label();
            this.lblSummaryVehiclePriceEntryBox = new System.Windows.Forms.Label();
            this.lblSummaryAmountDueTextbox = new System.Windows.Forms.Label();
            this.lblSummaryTextboxAmountDue = new System.Windows.Forms.Label();
            this.lblSummaryAmountDue = new System.Windows.Forms.Label();
            this.lblSummaryTradein = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.lblSummarySalesTax = new System.Windows.Forms.Label();
            this.lblSummarySubtotal = new System.Windows.Forms.Label();
            this.lblSummaryOption = new System.Windows.Forms.Label();
            this.lblSummaryVehiclesSalePrice = new System.Windows.Forms.Label();
            this.mnuVehicleSalesQuote = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewVehicleInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.cboVehicleComboPrice = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFInishRadios.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.mnuVehicleSalesQuote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiclesSalePrice
            // 
            this.lblVehiclesSalePrice.AutoSize = true;
            this.lblVehiclesSalePrice.Location = new System.Drawing.Point(83, 25);
            this.lblVehiclesSalePrice.Name = "lblVehiclesSalePrice";
            this.lblVehiclesSalePrice.Size = new System.Drawing.Size(54, 17);
            this.lblVehiclesSalePrice.TabIndex = 0;
            this.lblVehiclesSalePrice.Text = "Vehicle";
            this.lblVehiclesSalePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVehiclesSalePriceBox
            // 
            this.txtVehiclesSalePriceBox.Location = new System.Drawing.Point(171, 25);
            this.txtVehiclesSalePriceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehiclesSalePriceBox.Name = "txtVehiclesSalePriceBox";
            this.txtVehiclesSalePriceBox.Size = new System.Drawing.Size(185, 22);
            this.txtVehiclesSalePriceBox.TabIndex = 0;
            this.txtVehiclesSalePriceBox.Tag = "Vehicle Price";
            this.txtVehiclesSalePriceBox.Text = "999.99";
            this.txtVehiclesSalePriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(45, 78);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(106, 17);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValueBox
            // 
            this.txtTradeInValueBox.AccessibleDescription = "";
            this.txtTradeInValueBox.Location = new System.Drawing.Point(171, 78);
            this.txtTradeInValueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTradeInValueBox.Name = "txtTradeInValueBox";
            this.txtTradeInValueBox.Size = new System.Drawing.Size(185, 22);
            this.txtTradeInValueBox.TabIndex = 1;
            this.txtTradeInValueBox.Tag = "Trade-in value.";
            this.txtTradeInValueBox.Text = "0";
            this.txtTradeInValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigationCheckbox);
            this.grpAccessories.Controls.Add(this.chkLeatherInteriorCheckbox);
            this.grpAccessories.Controls.Add(this.chkStereoSystemCheckbox);
            this.grpAccessories.Location = new System.Drawing.Point(25, 142);
            this.grpAccessories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAccessories.Size = new System.Drawing.Size(331, 200);
            this.grpAccessories.TabIndex = 4;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigationCheckbox
            // 
            this.chkComputerNavigationCheckbox.AutoSize = true;
            this.chkComputerNavigationCheckbox.Location = new System.Drawing.Point(23, 142);
            this.chkComputerNavigationCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkComputerNavigationCheckbox.Name = "chkComputerNavigationCheckbox";
            this.chkComputerNavigationCheckbox.Size = new System.Drawing.Size(162, 21);
            this.chkComputerNavigationCheckbox.TabIndex = 4;
            this.chkComputerNavigationCheckbox.Text = "Computer Navigation";
            this.chkComputerNavigationCheckbox.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInteriorCheckbox
            // 
            this.chkLeatherInteriorCheckbox.AutoSize = true;
            this.chkLeatherInteriorCheckbox.Location = new System.Drawing.Point(23, 87);
            this.chkLeatherInteriorCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLeatherInteriorCheckbox.Name = "chkLeatherInteriorCheckbox";
            this.chkLeatherInteriorCheckbox.Size = new System.Drawing.Size(127, 21);
            this.chkLeatherInteriorCheckbox.TabIndex = 3;
            this.chkLeatherInteriorCheckbox.Text = "Leather Interior";
            this.chkLeatherInteriorCheckbox.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystemCheckbox
            // 
            this.chkStereoSystemCheckbox.AutoSize = true;
            this.chkStereoSystemCheckbox.Location = new System.Drawing.Point(23, 41);
            this.chkStereoSystemCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkStereoSystemCheckbox.Name = "chkStereoSystemCheckbox";
            this.chkStereoSystemCheckbox.Size = new System.Drawing.Size(122, 21);
            this.chkStereoSystemCheckbox.TabIndex = 2;
            this.chkStereoSystemCheckbox.Text = "Stereo System";
            this.chkStereoSystemCheckbox.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFInishRadios
            // 
            this.grpExteriorFInishRadios.Controls.Add(this.radCustomDetailingFinish);
            this.grpExteriorFInishRadios.Controls.Add(this.radPearlizedFinish);
            this.grpExteriorFInishRadios.Controls.Add(this.radStandardFinish);
            this.grpExteriorFInishRadios.Location = new System.Drawing.Point(24, 384);
            this.grpExteriorFInishRadios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpExteriorFInishRadios.Name = "grpExteriorFInishRadios";
            this.grpExteriorFInishRadios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpExteriorFInishRadios.Size = new System.Drawing.Size(331, 222);
            this.grpExteriorFInishRadios.TabIndex = 5;
            this.grpExteriorFInishRadios.TabStop = false;
            this.grpExteriorFInishRadios.Text = "Exterior FInish";
            // 
            // radCustomDetailingFinish
            // 
            this.radCustomDetailingFinish.AutoSize = true;
            this.radCustomDetailingFinish.Location = new System.Drawing.Point(24, 166);
            this.radCustomDetailingFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCustomDetailingFinish.Name = "radCustomDetailingFinish";
            this.radCustomDetailingFinish.Size = new System.Drawing.Size(135, 21);
            this.radCustomDetailingFinish.TabIndex = 7;
            this.radCustomDetailingFinish.TabStop = true;
            this.radCustomDetailingFinish.Text = "Custom Detailing";
            this.radCustomDetailingFinish.UseVisualStyleBackColor = true;
            // 
            // radPearlizedFinish
            // 
            this.radPearlizedFinish.AutoSize = true;
            this.radPearlizedFinish.Location = new System.Drawing.Point(24, 111);
            this.radPearlizedFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPearlizedFinish.Name = "radPearlizedFinish";
            this.radPearlizedFinish.Size = new System.Drawing.Size(88, 21);
            this.radPearlizedFinish.TabIndex = 6;
            this.radPearlizedFinish.TabStop = true;
            this.radPearlizedFinish.Text = "Pearlized";
            this.radPearlizedFinish.UseVisualStyleBackColor = true;
            // 
            // radStandardFinish
            // 
            this.radStandardFinish.AutoSize = true;
            this.radStandardFinish.Checked = true;
            this.radStandardFinish.Location = new System.Drawing.Point(24, 54);
            this.radStandardFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radStandardFinish.Name = "radStandardFinish";
            this.radStandardFinish.Size = new System.Drawing.Size(87, 21);
            this.radStandardFinish.TabIndex = 5;
            this.radStandardFinish.TabStop = true;
            this.radStandardFinish.Text = "Standard";
            this.radStandardFinish.UseVisualStyleBackColor = true;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblTextboxMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.numericUpDown1);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblNumberOfYears);
            this.grpFinance.Controls.Add(this.nudNumberOfYears);
            this.grpFinance.Controls.Add(this.nudNoOfYears);
            this.grpFinance.Location = new System.Drawing.Point(401, 481);
            this.grpFinance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFinance.Size = new System.Drawing.Size(400, 125);
            this.grpFinance.TabIndex = 6;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblTextboxMonthlyPayment
            // 
            this.lblTextboxMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTextboxMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTextboxMonthlyPayment.Location = new System.Drawing.Point(261, 82);
            this.lblTextboxMonthlyPayment.Name = "lblTextboxMonthlyPayment";
            this.lblTextboxMonthlyPayment.Size = new System.Drawing.Size(117, 22);
            this.lblTextboxMonthlyPayment.TabIndex = 0;
            this.lblTextboxMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(261, 46);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(116, 17);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(156, 82);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(153, 34);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(92, 39);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(21, 46);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(87, 17);
            this.lblNumberOfYears.TabIndex = 1;
            this.lblNumberOfYears.Text = "No. of Years";
            // 
            // nudNumberOfYears
            // 
            this.nudNumberOfYears.Location = new System.Drawing.Point(25, 82);
            this.nudNumberOfYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfYears.Name = "nudNumberOfYears";
            this.nudNumberOfYears.Size = new System.Drawing.Size(84, 22);
            this.nudNumberOfYears.TabIndex = 8;
            this.nudNumberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(45, 180);
            this.nudNoOfYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(85, 22);
            this.nudNoOfYears.TabIndex = 0;
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(647, 626);
            this.btnCalculateQuote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(155, 38);
            this.btnCalculateQuote.TabIndex = 10;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 626);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.SystemColors.Control;
            this.grpSummary.Controls.Add(this.lblSummaryTradeinEntryBox);
            this.grpSummary.Controls.Add(this.lblSummaryTotalTextBox);
            this.grpSummary.Controls.Add(this.lblSummarySalesTaxEntryBox);
            this.grpSummary.Controls.Add(this.lblSummarySubTotalEntryBox);
            this.grpSummary.Controls.Add(this.lblSummaryOptionEntryBox);
            this.grpSummary.Controls.Add(this.lblSummaryVehiclePriceEntryBox);
            this.grpSummary.Controls.Add(this.lblSummaryAmountDueTextbox);
            this.grpSummary.Controls.Add(this.lblSummaryTextboxAmountDue);
            this.grpSummary.Controls.Add(this.lblSummaryAmountDue);
            this.grpSummary.Controls.Add(this.lblSummaryTradein);
            this.grpSummary.Controls.Add(this.lblSummaryTotal);
            this.grpSummary.Controls.Add(this.lblSummarySalesTax);
            this.grpSummary.Controls.Add(this.lblSummarySubtotal);
            this.grpSummary.Controls.Add(this.lblSummaryOption);
            this.grpSummary.Controls.Add(this.lblSummaryVehiclesSalePrice);
            this.grpSummary.Location = new System.Drawing.Point(401, 25);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(400, 434);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblSummaryTradeinEntryBox
            // 
            this.lblSummaryTradeinEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTradeinEntryBox.Location = new System.Drawing.Point(187, 333);
            this.lblSummaryTradeinEntryBox.Name = "lblSummaryTradeinEntryBox";
            this.lblSummaryTradeinEntryBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummaryTradeinEntryBox.TabIndex = 12;
            this.lblSummaryTradeinEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTotalTextBox
            // 
            this.lblSummaryTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTotalTextBox.Location = new System.Drawing.Point(187, 274);
            this.lblSummaryTotalTextBox.Name = "lblSummaryTotalTextBox";
            this.lblSummaryTotalTextBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummaryTotalTextBox.TabIndex = 12;
            this.lblSummaryTotalTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySalesTaxEntryBox
            // 
            this.lblSummarySalesTaxEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySalesTaxEntryBox.Location = new System.Drawing.Point(187, 216);
            this.lblSummarySalesTaxEntryBox.Name = "lblSummarySalesTaxEntryBox";
            this.lblSummarySalesTaxEntryBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummarySalesTaxEntryBox.TabIndex = 12;
            this.lblSummarySalesTaxEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummarySubTotalEntryBox
            // 
            this.lblSummarySubTotalEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummarySubTotalEntryBox.Location = new System.Drawing.Point(187, 159);
            this.lblSummarySubTotalEntryBox.Name = "lblSummarySubTotalEntryBox";
            this.lblSummarySubTotalEntryBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummarySubTotalEntryBox.TabIndex = 12;
            this.lblSummarySubTotalEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryOptionEntryBox
            // 
            this.lblSummaryOptionEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryOptionEntryBox.Location = new System.Drawing.Point(187, 107);
            this.lblSummaryOptionEntryBox.Name = "lblSummaryOptionEntryBox";
            this.lblSummaryOptionEntryBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummaryOptionEntryBox.TabIndex = 12;
            this.lblSummaryOptionEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryVehiclePriceEntryBox
            // 
            this.lblSummaryVehiclePriceEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryVehiclePriceEntryBox.Location = new System.Drawing.Point(187, 49);
            this.lblSummaryVehiclePriceEntryBox.Name = "lblSummaryVehiclePriceEntryBox";
            this.lblSummaryVehiclePriceEntryBox.Size = new System.Drawing.Size(171, 24);
            this.lblSummaryVehiclePriceEntryBox.TabIndex = 12;
            this.lblSummaryVehiclePriceEntryBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryAmountDueTextbox
            // 
            this.lblSummaryAmountDueTextbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSummaryAmountDueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryAmountDueTextbox.Location = new System.Drawing.Point(187, 389);
            this.lblSummaryAmountDueTextbox.Name = "lblSummaryAmountDueTextbox";
            this.lblSummaryAmountDueTextbox.Size = new System.Drawing.Size(171, 24);
            this.lblSummaryAmountDueTextbox.TabIndex = 0;
            this.lblSummaryAmountDueTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummaryTextboxAmountDue
            // 
            this.lblSummaryTextboxAmountDue.AutoSize = true;
            this.lblSummaryTextboxAmountDue.Location = new System.Drawing.Point(243, 410);
            this.lblSummaryTextboxAmountDue.Name = "lblSummaryTextboxAmountDue";
            this.lblSummaryTextboxAmountDue.Size = new System.Drawing.Size(0, 17);
            this.lblSummaryTextboxAmountDue.TabIndex = 13;
            // 
            // lblSummaryAmountDue
            // 
            this.lblSummaryAmountDue.AutoSize = true;
            this.lblSummaryAmountDue.Location = new System.Drawing.Point(79, 389);
            this.lblSummaryAmountDue.Name = "lblSummaryAmountDue";
            this.lblSummaryAmountDue.Size = new System.Drawing.Size(90, 17);
            this.lblSummaryAmountDue.TabIndex = 6;
            this.lblSummaryAmountDue.Text = "Amount Due:";
            // 
            // lblSummaryTradein
            // 
            this.lblSummaryTradein.AutoSize = true;
            this.lblSummaryTradein.Location = new System.Drawing.Point(99, 337);
            this.lblSummaryTradein.Name = "lblSummaryTradein";
            this.lblSummaryTradein.Size = new System.Drawing.Size(66, 17);
            this.lblSummaryTradein.TabIndex = 5;
            this.lblSummaryTradein.Text = "Trade-in:";
            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.AutoSize = true;
            this.lblSummaryTotal.Location = new System.Drawing.Point(125, 278);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(44, 17);
            this.lblSummaryTotal.TabIndex = 4;
            this.lblSummaryTotal.Text = "Total:";
            // 
            // lblSummarySalesTax
            // 
            this.lblSummarySalesTax.AutoSize = true;
            this.lblSummarySalesTax.Location = new System.Drawing.Point(53, 220);
            this.lblSummarySalesTax.Name = "lblSummarySalesTax";
            this.lblSummarySalesTax.Size = new System.Drawing.Size(116, 17);
            this.lblSummarySalesTax.TabIndex = 3;
            this.lblSummarySalesTax.Text = "Sales Tax (13%):";
            // 
            // lblSummarySubtotal
            // 
            this.lblSummarySubtotal.AutoSize = true;
            this.lblSummarySubtotal.Location = new System.Drawing.Point(99, 162);
            this.lblSummarySubtotal.Name = "lblSummarySubtotal";
            this.lblSummarySubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSummarySubtotal.TabIndex = 2;
            this.lblSummarySubtotal.Text = "Subtotal:";
            // 
            // lblSummaryOption
            // 
            this.lblSummaryOption.AutoSize = true;
            this.lblSummaryOption.Location = new System.Drawing.Point(108, 107);
            this.lblSummaryOption.Name = "lblSummaryOption";
            this.lblSummaryOption.Size = new System.Drawing.Size(54, 17);
            this.lblSummaryOption.TabIndex = 1;
            this.lblSummaryOption.Text = "Option:";
            // 
            // lblSummaryVehiclesSalePrice
            // 
            this.lblSummaryVehiclesSalePrice.AutoSize = true;
            this.lblSummaryVehiclesSalePrice.Location = new System.Drawing.Point(33, 49);
            this.lblSummaryVehiclesSalePrice.Name = "lblSummaryVehiclesSalePrice";
            this.lblSummaryVehiclesSalePrice.Size = new System.Drawing.Size(136, 17);
            this.lblSummaryVehiclesSalePrice.TabIndex = 0;
            this.lblSummaryVehiclesSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // mnuVehicleSalesQuote
            // 
            this.mnuVehicleSalesQuote.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuVehicleSalesQuote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.mnuVehicleSalesQuote.Location = new System.Drawing.Point(0, 0);
            this.mnuVehicleSalesQuote.Name = "mnuVehicleSalesQuote";
            this.mnuVehicleSalesQuote.Size = new System.Drawing.Size(839, 28);
            this.mnuVehicleSalesQuote.TabIndex = 12;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuFileClose.Size = new System.Drawing.Size(184, 26);
            this.mnuFileClose.Text = "&Close";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewVehicleInformation});
            this.mnuView.Enabled = false;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(55, 24);
            this.mnuView.Text = "&View";
            // 
            // mnuViewVehicleInformation
            // 
            this.mnuViewVehicleInformation.Enabled = false;
            this.mnuViewVehicleInformation.Name = "mnuViewVehicleInformation";
            this.mnuViewVehicleInformation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuViewVehicleInformation.Size = new System.Drawing.Size(307, 26);
            this.mnuViewVehicleInformation.Text = "Vehicle &Information";
            // 
            // cboVehicleComboPrice
            // 
            this.cboVehicleComboPrice.Location = new System.Drawing.Point(172, 25);
            this.cboVehicleComboPrice.Name = "cboVehicleComboPrice";
            this.cboVehicleComboPrice.Size = new System.Drawing.Size(184, 24);
            this.cboVehicleComboPrice.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // VehicleSalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 693);
            this.Controls.Add(this.cboVehicleComboPrice);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpExteriorFInishRadios);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValueBox);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.txtVehiclesSalePriceBox);
            this.Controls.Add(this.lblVehiclesSalePrice);
            this.Controls.Add(this.mnuVehicleSalesQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuVehicleSalesQuote;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "VehicleSalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFInishRadios.ResumeLayout(false);
            this.grpExteriorFInishRadios.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.mnuVehicleSalesQuote.ResumeLayout(false);
            this.mnuVehicleSalesQuote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiclesSalePrice;
        private System.Windows.Forms.TextBox txtVehiclesSalePriceBox;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValueBox;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigationCheckbox;
        private System.Windows.Forms.CheckBox chkLeatherInteriorCheckbox;
        private System.Windows.Forms.CheckBox chkStereoSystemCheckbox;
        private System.Windows.Forms.GroupBox grpExteriorFInishRadios;
        private System.Windows.Forms.RadioButton radCustomDetailingFinish;
        private System.Windows.Forms.RadioButton radPearlizedFinish;
        private System.Windows.Forms.RadioButton radStandardFinish;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.NumericUpDown nudNumberOfYears;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblSummaryAmountDue;
        private System.Windows.Forms.Label lblSummaryTradein;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label lblSummarySalesTax;
        private System.Windows.Forms.Label lblSummarySubtotal;
        private System.Windows.Forms.Label lblSummaryOption;
        private System.Windows.Forms.Label lblSummaryVehiclesSalePrice;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTextboxMonthlyPayment;
        private System.Windows.Forms.Label lblSummaryAmountDueTextbox;
        private System.Windows.Forms.Label lblSummaryTextboxAmountDue;
        private System.Windows.Forms.Label lblSummaryTradeinEntryBox;
        private System.Windows.Forms.Label lblSummaryTotalTextBox;
        private System.Windows.Forms.Label lblSummarySalesTaxEntryBox;
        private System.Windows.Forms.Label lblSummarySubTotalEntryBox;
        private System.Windows.Forms.Label lblSummaryOptionEntryBox;
        private System.Windows.Forms.Label lblSummaryVehiclePriceEntryBox;
        private System.Windows.Forms.MenuStrip mnuVehicleSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ComboBox cboVehicleComboPrice;
        private System.Windows.Forms.ToolStripMenuItem mnuViewVehicleInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
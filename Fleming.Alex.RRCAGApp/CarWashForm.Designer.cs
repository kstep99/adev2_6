
namespace Fleming.Alex.RRCAGApp
{
    partial class CarWashForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lstExteriorBox = new System.Windows.Forms.ListBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lstInteriorBox = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalOutput = new System.Windows.Forms.Label();
            this.lblPstOutput = new System.Windows.Forms.Label();
            this.lblGstOutput = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.generateInvoiceToolStripMenuItem.Text = "Generate &Invoice";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(45, 73);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(67, 17);
            this.lblPackage.TabIndex = 1;
            this.lblPackage.Text = "Package:";
            // 
            // lblFragrance
            // 
            this.lblFragrance.AutoSize = true;
            this.lblFragrance.Location = new System.Drawing.Point(259, 73);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(77, 17);
            this.lblFragrance.TabIndex = 2;
            this.lblFragrance.Text = "Fragrance:";
            // 
            // cboFragrance
            // 
            this.cboFragrance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(262, 109);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(174, 24);
            this.cboFragrance.TabIndex = 2;
            // 
            // cboPackage
            // 
            this.cboPackage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboPackage.CausesValidation = false;
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(48, 108);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(174, 24);
            this.cboPackage.TabIndex = 1;
            
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lstExteriorBox);
            this.grpSummary.Controls.Add(this.lblExterior);
            this.grpSummary.Controls.Add(this.lblInterior);
            this.grpSummary.Controls.Add(this.lstInteriorBox);
            this.grpSummary.Location = new System.Drawing.Point(26, 167);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(435, 221);
            this.grpSummary.TabIndex = 5;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lstExteriorBox
            // 
            this.lstExteriorBox.FormattingEnabled = true;
            this.lstExteriorBox.ItemHeight = 16;
            this.lstExteriorBox.Location = new System.Drawing.Point(236, 72);
            this.lstExteriorBox.Name = "lstExteriorBox";
            this.lstExteriorBox.Size = new System.Drawing.Size(174, 116);
            this.lstExteriorBox.TabIndex = 5;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Location = new System.Drawing.Point(233, 41);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(60, 17);
            this.lblExterior.TabIndex = 1;
            this.lblExterior.Text = "Exterior:";
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Location = new System.Drawing.Point(19, 41);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(56, 17);
            this.lblInterior.TabIndex = 0;
            this.lblInterior.Text = "Interior:";
            // 
            // lstInteriorBox
            // 
            this.lstInteriorBox.CausesValidation = false;
            this.lstInteriorBox.FormattingEnabled = true;
            this.lstInteriorBox.ItemHeight = 16;
            this.lstInteriorBox.Location = new System.Drawing.Point(22, 72);
            this.lstInteriorBox.Name = "lstInteriorBox";
            this.lstInteriorBox.Size = new System.Drawing.Size(174, 116);
            this.lstInteriorBox.TabIndex = 4;
            this.lstInteriorBox.TabStop = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(272, 413);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Location = new System.Drawing.Point(295, 450);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(39, 17);
            this.lblPST.TabIndex = 7;
            this.lblPST.Text = "PST:";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(293, 486);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(41, 17);
            this.lblGST.TabIndex = 8;
            this.lblGST.Text = "GST:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(290, 524);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotalOutput
            // 
            this.lblSubtotalOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotalOutput.Location = new System.Drawing.Point(346, 412);
            this.lblSubtotalOutput.Name = "lblSubtotalOutput";
            this.lblSubtotalOutput.Size = new System.Drawing.Size(115, 26);
            this.lblSubtotalOutput.TabIndex = 10;
            this.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPstOutput
            // 
            this.lblPstOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPstOutput.Location = new System.Drawing.Point(346, 449);
            this.lblPstOutput.Name = "lblPstOutput";
            this.lblPstOutput.Size = new System.Drawing.Size(115, 26);
            this.lblPstOutput.TabIndex = 11;
            this.lblPstOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGstOutput
            // 
            this.lblGstOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGstOutput.Location = new System.Drawing.Point(346, 485);
            this.lblGstOutput.Name = "lblGstOutput";
            this.lblGstOutput.Size = new System.Drawing.Size(115, 28);
            this.lblGstOutput.TabIndex = 12;
            this.lblGstOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutput.Location = new System.Drawing.Point(346, 523);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(115, 26);
            this.lblTotalOutput.TabIndex = 13;
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 582);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.lblGstOutput);
            this.Controls.Add(this.lblPstOutput);
            this.Controls.Add(this.lblSubtotalOutput);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarWashForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.ListBox lstExteriorBox;
        private System.Windows.Forms.ListBox lstInteriorBox;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalOutput;
        private System.Windows.Forms.Label lblPstOutput;
        private System.Windows.Forms.Label lblGstOutput;
        private System.Windows.Forms.Label lblTotalOutput;
        public System.Windows.Forms.ComboBox cboPackage;
    }
}
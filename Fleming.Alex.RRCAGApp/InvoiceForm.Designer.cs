
namespace Fleming.Alex.RRCAGApp
{
    partial class InvoiceForm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddresss = new System.Windows.Forms.Label();
            this.lblCityProvincePostal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(329, 36);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "RRC Automotive Group";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddresss
            // 
            this.lblAddresss.AutoSize = true;
            this.lblAddresss.Location = new System.Drawing.Point(15, 64);
            this.lblAddresss.Name = "lblAddresss";
            this.lblAddresss.Size = new System.Drawing.Size(143, 17);
            this.lblAddresss.TabIndex = 1;
            this.lblAddresss.Text = "777 Inheritance Drive";
            // 
            // lblCityProvincePostal
            // 
            this.lblCityProvincePostal.AutoSize = true;
            this.lblCityProvincePostal.Location = new System.Drawing.Point(15, 91);
            this.lblCityProvincePostal.Name = "lblCityProvincePostal";
            this.lblCityProvincePostal.Size = new System.Drawing.Size(178, 17);
            this.lblCityProvincePostal.TabIndex = 2;
            this.lblCityProvincePostal.Text = "Winnipeg, Manitoba, I0I 0I0";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 17);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "204-867-5309";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(13, 174);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(157, 29);
            this.lblInvoiceTitle.TabIndex = 4;
            this.lblInvoiceTitle.Text = "[Invoice Title]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(613, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDisplay.Location = new System.Drawing.Point(658, 3);
            this.lblDateDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(122, 47);
            this.lblDateDisplay.TabIndex = 6;
            this.lblDateDisplay.Text = "[Date]";
            this.lblDateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 499);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCityProvincePostal);
            this.Controls.Add(this.lblAddresss);
            this.Controls.Add(this.lblCompanyName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.Text = "[Form Title]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddresss;
        private System.Windows.Forms.Label lblCityProvincePostal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateDisplay;
        protected System.Windows.Forms.Label lblInvoiceTitle;
    }
}
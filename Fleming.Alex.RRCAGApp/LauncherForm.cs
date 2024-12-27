/*
 * Name: Alex Fleming
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 10/27/2021
 * Updated: 11/14/2021 
 */
using System;
using System.Windows.Forms;

namespace Fleming.Alex.RRCAGApp
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
        }

        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm form;
            form = new CarWashForm();
            form.Show();
        }

        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
           VehicleSalesQuoteForm form;
           form = new VehicleSalesQuoteForm();
           form.ShowDialog();
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
           AboutForm form;
           form = new AboutForm();
           // make the form appear (as modal).
           form.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

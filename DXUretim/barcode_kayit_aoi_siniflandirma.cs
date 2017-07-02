using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXUretim
{
    public partial class barcode_kayit_aoi_siniflandirma : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public barcode_kayit_aoi_siniflandirma()
        {
            
            InitializeComponent();
        }

        private void barcode_kayit_aoi_siniflandirma_Load(object sender, EventArgs e)
        {
            string[] States = {
                     "Alabama",
                     "Alaska",
                     "Arizona",
                     "California",
                     "Colorado",
                     "Florida",
                     "Idaho",
                     "Kansas",
                     "Michigan",
                     "Nevada",
                     "Texas",
                     "Utah"
                  };
            // Initialize and create an instance of the ListBoxControl class
            ListBoxControl listBox = new ListBoxControl();
            // Define the parent control
            listBox.Parent = this;
            // Set the listBox's background color
            listBox.BackColor = Color.FromArgb(254, 246, 212);
            // Dock to all edges and fill the parent container
            listBox.Dock = DockStyle.Fill;
            // Add items
            listBox.Items.AddRange(States);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DXUretim
{
    public partial class menu : DevExpress.XtraEditors.XtraForm
    {
        public menu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("içeri", "başlık", MessageBoxButtons.YesNo);

        }
    }
}
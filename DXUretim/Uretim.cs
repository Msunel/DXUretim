using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXUretim
{
    public partial class Uretim : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Uretim()
        {
            InitializeComponent();
        }

        private void tHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            barcode_kayit_tht bk_tht = new barcode_kayit_tht();
            bk_tht.MdiParent = this;
            bk_tht.Show();
        }

        private void aOITaramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            barcode_kayit_aoi_tarama bk_aoi_tarama = new barcode_kayit_aoi_tarama();
            bk_aoi_tarama.MdiParent = this;
            bk_aoi_tarama.Show();
        }

        private void aOISınıflandırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            barcode_kayit_aoi_siniflandirma bk_sinif = new barcode_kayit_aoi_siniflandirma();
            bk_sinif.MdiParent = this;
            bk_sinif.Show();

        }

        private void yarıÜrünTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            barcode_kayit_yariurun_test bk_yu_test = new barcode_kayit_yariurun_test();
            bk_yu_test.MdiParent = this;
            bk_yu_test.Show();
        }

        private void gönderiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            HaftalıkGönderiGörüntüle hft_görtl = new HaftalıkGönderiGörüntüle();
            hft_görtl.MdiParent = this;
            hft_görtl.Show();
        }

        private void deneme1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Deneme1 deneme1 = new Deneme1();
            deneme1.MdiParent = this;
            deneme1.Show();
        }

       

        private void themeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void deneme2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deneme3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deneme3 deneme3 = new Deneme3();
            deneme3.MdiParent = this;
            deneme3.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void anaMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnaMenu anamenu = new AnaMenu();
            anamenu.MdiParent = this;
            anamenu.Show();
        }

        private void calisma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Calisma1 calisma1 = new Calisma1();
            calisma1.MdiParent = this;
            calisma1.Show();

        }

        private void calisma2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma2 calisma2 = new Calisma2();
            calisma2.MdiParent = this;
            calisma2.Show();

        }

        private void calisma3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma3 calisma3 = new Calisma3();
            calisma3.MdiParent = this;
            calisma3.Show();
        }

        private void calisma4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma4 calisma4 = new Calisma4();
            calisma4.MdiParent = this;
            calisma4.Show();
        }

        private void calisma5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma5 calisma5 = new Calisma5();
            calisma5.MdiParent = this;
            calisma5.Show();
            
        }

        private void calismaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma6 calisma6 = new Calisma6();
            calisma6.MdiParent = this;
            calisma6.Show();
        }

        private void calisma7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma7 calisma7 = new Calisma7();
            calisma7.MdiParent = this;
            calisma7.Show();

        }

        private void calisma8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma8 calisma8 = new Calisma8();
             calisma8.MdiParent = this;
            calisma8.Show();
        }

        private void calisma9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisma9 calisma9 = new Calisma9();
             calisma9.MdiParent = this;
            calisma9.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Uretim_Load(object sender, EventArgs e)
        {

        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barMdiChildrenListItem2_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.MdiParent = this;
            menu.Show();
        }
    } 
         
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DXUretim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           //DevExpress.UserSkins.BonusSkins.Register(); // ekstra skinlerin görünür olması
           // DevExpress.Skins.SkinManager.EnableMdiFormSkins();// mdiparent form skin
           // DevExpress.Skins.SkinManager.EnableFormSkins(); // enable form skin
           //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Summer 2008";

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Uretim());
        }
    }
}

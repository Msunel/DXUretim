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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DXUretim
{
    public partial class barcode_kayit_tht : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MySqlConnection baglanti; // baglanti nesnesi
        public barcode_kayit_tht()
        {
           
            InitializeComponent();
        }

        private void barcode_kayit_tht_Load(object sender, EventArgs e)
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "1234";
            build.Database = "sakila";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();

            string sql = "SELECT * FROM city";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            adapter.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
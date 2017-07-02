using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DXUretim
{
    public partial class HaftalıkGönderiGörüntüle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MySqlConnection baglanti; // baglanti nesnesi
        public HaftalıkGönderiGörüntüle()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

            string sql = "SELECT * FROM actor";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            gridControl1.DataSource = dt;

             gridControl1.DataSource = dt;
             gridControl2.DataSource = dt;
           gridControl3.DataSource = dt;
             gridControl4.DataSource = dt;
            gridControl5.DataSource = dt;
             gridControl6.DataSource = dt;
             gridControl7.DataSource = dt;
            gridControl8.DataSource = dt;
           // gridControl9.DataSource = dt;
            // dataGridView1.DataSource = dt;

            /* gridControl1.DataSource = dt;
             gridControl2.DataSource = dt;
             gridControl3.DataSource = dt;
             gridControl4.DataSource = dt;
             vGridControl1.DataSource = dt;
             gridControl5.DataSource = dt;
             gridColumn1.Caption = "city id";
             gridColumn2.Caption = "city id";
             gridColumn3.Caption = "city id";
             gridControl6.DataSource = dt;
             gridControl6.Text = "dteffs";*/
        }

        private void gridControl8_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

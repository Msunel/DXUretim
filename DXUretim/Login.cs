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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public MySqlConnection con;  // baglanti nesnesi
        int i;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "1234";
            build.Database = "uretim";
            build.Server = "localhost";

            bag = build.ToString();
            con = new MySqlConnection(bag);


            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *from users where username='"+txtUsername.Text+"' and password='"+txtPassword.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i==0)
            {
                labelControl1.Text = "Yanlış şifre";
            }

            else
            {
                this.Hide();
                Uretim fm = new Uretim();
                fm.Show();
            }
            con.Close();

           
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
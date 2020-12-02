using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class LoginR : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");

        public LoginR()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void LoginR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean b = false;

            con.Open();


            string s = "select * from receptionist ";
            MySqlCommand cmd = new MySqlCommand(s, con);

            MySqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                string username = d["rName"].ToString();
                string password = d["rpassword"].ToString();
                if ((username == textBox1.Text) && (password == textBox2.Text))
                {
                    b = true;
                }

            }

            if (b == false)
                MessageBox.Show("Invalid Click (Ok) to try again");
            else
            {
                Receptionist_Form rform = new Receptionist_Form();
                this.Hide();
                rform.ShowDialog();

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

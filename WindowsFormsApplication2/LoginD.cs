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

namespace WindowsFormsApplication2
{
    public partial class LoginD : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
      
        public LoginD()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            con.Open();

            string s = "select * from doctor ";
            MySqlCommand cmd = new MySqlCommand(s, con);

            MySqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                string username = d["dName"].ToString();
                string password = d["dpassword"].ToString();
                if ((username == textBox1.Text) && (password == textBox2.Text))
                {
                    b = true;
                }

            }

            if (b == false)
                MessageBox.Show("Invalid Click (Ok) to try again");
            else
            { Doctor_form  Dform =new Doctor_form();
                this.Hide();
                Dform.ShowDialog();
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class Add_Patient : Form
    {
       

        List<string> Category = new List<string>();
        double cost;
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        Receptionist_Form RF = new Receptionist_Form();
        public Add_Patient()
        {
            InitializeComponent();
            label13.Visible = false;
           
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {if (!textBox11.Lines.Contains(listBox1.SelectedItem.ToString()))
            {
                textBox11.Text += (listBox1.SelectedItem.ToString());
                textBox11.Text += Environment.NewLine;

                double n = P_cost(listBox1.SelectedItem.ToString());

                label13.Text = "0";
                label13.Text = (Convert.ToDouble(label13.Text) + n).ToString();
                con.Close();
            }
            else { MessageBox.Show("Analysis have been added"); }
        }
        public double P_cost (string s)
        {   con.Open();
            try
            {
               string s1 = "select * from analysisattributes ";
                    MySqlCommand cmd1 = new MySqlCommand(s1, con);
                    MySqlDataReader a = cmd1.ExecuteReader();
                while (a.Read())
                {
                    if (s == a["anName"].ToString())
                    {
                        cost += Convert.ToDouble(a["Cost"]);

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return cost;
        }
        private void Add_Patient_Load(object sender, EventArgs e)
        {
            string[] g = { "male", "female" };
            comboBox1.Items.AddRange(g);
            
            con.Open();

            string s1 = "select * from analysisCatigory ";
            MySqlCommand cmd1 = new MySqlCommand(s1, con);
            MySqlDataReader a = cmd1.ExecuteReader();
            while (a.Read())
            {

                listBox1.Items.Add(a["anName"].ToString());

            }


            con.Close();
            DateTime today = DateTime.Today;
            textBox6.Text = today.ToString("d");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RF.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox10.Text == ""|| textBox11.Text == "")
            {
                MessageBox.Show("There is missing data please check your Name, age, gender, National Id, Date and Analysis ");
            }
            else
            {
                try
                {
                    Convert.ToInt32(textBox3.Text);

                    if (textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox6.Text != "" && textBox10.Text != "")
                    {
                        Preview Preview = new Preview(textBox2.Text, textBox3.Text, comboBox1.Text, textBox6.Text, textBox9.Text, textBox8.Text, textBox5.Text,
                            textBox1.Text, textBox7.Text, textBox10.Text, label13.Text, textBox11.Text);
                        Preview.ShowDialog();
                    }
                }
                catch { MessageBox.Show("You must enter Numerical value in age of the patient"); }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

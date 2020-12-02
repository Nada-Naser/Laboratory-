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
    public partial class Results : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        MySqlCommand cmd7;
        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        Doctor_form dr = new Doctor_form();
        public Results()
        {
            InitializeComponent();
            Addresults.Columns[2].Width = 120;
            Addresults.Columns[3].Width = 110;
        }

        private void Results_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Boolean b = false;
            Pcategories.Items.Clear();
            con.Open();


            string s = "select * from patient ";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                string PID = d["pid"].ToString();

                if (PID == textBox1.Text)
                {
                    patientname.Text = d["pname"].ToString();
                    textBox2.Text = d["gender"].ToString();
                    textBox3.Text = d["ptAge"].ToString();



                }
            }

            con.Close();

            con.Open();

            string s1 = "select * from analysisDetail ";
            MySqlCommand cmd1 = new MySqlCommand(s1, con);
            MySqlDataReader a = cmd1.ExecuteReader();
            while (a.Read())
            {
                string Pid = a["pid"].ToString();

                if (Pid == textBox1.Text)
                {if (!Pcategories.Items.Contains(a["anName"].ToString()))
                        Pcategories.Items.Add(a["anName"].ToString());
                   
                }

            }

          
            con.Close();

        }

        private void Pcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string P = Pcategories.SelectedItem.ToString();
            con.Open();

            string s3 = "select dename,results,normalValue,measuringUnit from analysisDetail where anName = '" + P + "'and pId='" + textBox1.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(s3, con);
            MySqlDataAdapter g = new MySqlDataAdapter(s3, con);

            DataTable data = new DataTable();
            g.Fill(data);
            Addresults.DataSource = data;

            con.Close();
        }
        private void Addresults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Addresults.Rows.Count; i++)
            {
                if (Addresults.Rows[i].Cells[1].ToString() != String.Empty)
                {
                    string d = "update analysisDetail set results= '" + Addresults.Rows[i].Cells[1].Value
                        + "' where dename='" + Addresults.Rows[i].Cells[0].Value + "'and pId ='" + textBox1.Text + "'";
                    cmd7 = new MySqlCommand(d, con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    try
                    {
                        cmd7.ExecuteNonQuery();
                        if (i == Addresults.Rows.Count - 1)
                            MessageBox.Show("Results added successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There is a Pending Analysis");

                        break;

                    }
                    con.Close();
                }

            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dr.ShowDialog();

        }
    }
}

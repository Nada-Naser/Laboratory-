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
using System.Collections;
namespace WindowsFormsApplication2
{
    public partial class Preview : Form
    {
        List<string> DName = new List<string>();
        List<string> cost = new List<string>();
        List<string> normalV = new List<string>();
        List<string> measuringU = new List<string>();

        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        string e4;
        public Preview(string s, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11)
        {
            InitializeComponent();
            textBox1.Text = s;
            textBox2.Text = s1;
            comboBox1.Text = s2;
            textBox4.Text = s3;
            textBox5.Text = s4;
            textBox6.Text = s5;
            textBox7.Text = s6;
            textBox8.Text = s7;
            textBox9.Text = s8;
            textBox10.Text = s9;
            label23.Text = s10;
            textBox11.Text = s11;


        }



        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string Pinsert = "insert into  patient (nationalId ,pname,ptAge,gender,pdate ,referencedBy,mail, phone,address,city) values(  '" + textBox10.Text + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + comboBox1.Text + "' ,'" + textBox4.Text + "', '" + textBox9.Text + "' , '" + textBox7.Text + "' , '" + textBox5.Text + "' , '" + textBox8.Text + "' , '" + textBox6.Text + "')";

                MySqlCommand cmd = new MySqlCommand(Pinsert, con);
                cmd.ExecuteNonQuery();
                con.Close();

            if (con.State == ConnectionState.Closed)

                    con.Open();
                string select = "select * from patient where nationalId='" + textBox10.Text + "'and pdate='" + textBox4.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(select, con);
                MySqlDataReader d = cmd2.ExecuteReader();
                while (d.Read())
                {
                    e4 = d["pid"].ToString();

                }

                con.Close();
                MessageBox.Show("Patient Added, This is his / her ID = " + e4 + " ");



                for (int i = 0; i < textBox11.Lines.Count(); i++)
                {
                    con.Open();
                    string AnCselect = "select * from analysisAttributes";

                    MySqlCommand cmd1 = new MySqlCommand(AnCselect, con);
                    MySqlDataReader t = cmd1.ExecuteReader();
                    while (t.Read())
                    {
                        if (t["anName"].ToString() == textBox11.Lines[i].ToString())
                        {

                            DName.Add(t["dename"].ToString());
                            cost.Add(t["cost"].ToString());
                            normalV.Add(t["normalValue"].ToString());
                            measuringU.Add(t["measuringUnit"].ToString());

                        }

                    }
                    con.Close();
                    if (DName.Count > 0)
                    {
                        for (int j = 0; j < DName.Count; j++)
                        {
                            string Detinsert = "insert into   analysisDetail (anName,pId,dename,cost,normalValue,measuringUnit) values(  '" + textBox11.Lines[i] + "' ,'"
                                + e4 + "','" + DName[j] + "','" + Convert.ToDouble(cost[j]) + "' ,'" + Convert.ToDouble(normalV[j]) + "','" + measuringU[j] + "')";
                            MySqlCommand cmd4 = new MySqlCommand(Detinsert, con);
                            con.Open();
                            cmd4.ExecuteNonQuery();
                            con.Close();
                        }
                        DName.Clear();
                        cost.Clear();
                        normalV.Clear();
                        measuringU.Clear();
                    }






                }
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                label23.Text = "";
            }
            catch { MessageBox.Show("Invalid Data Click (OK) to Re-enter data "); }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Preview_Load(object sender, EventArgs e)
        {

            string[] g = { "male", "female" };
            comboBox1.Items.AddRange(g);
        }
    }
}





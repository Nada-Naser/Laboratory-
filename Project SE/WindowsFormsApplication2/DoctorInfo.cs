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
    public partial class DoctorInfo : Form
    {
        string e4;
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password =123456789");
        HR_form HR = new HR_form();
        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'laboratoryDataSet2.doctor' table. You can move, or remove it, as needed.

            string[] g = { "male", "female" };
            comboBox1.Items.AddRange(g);
            
            fill_grid();
           
        }

        public void fill_grid()
        {
            MySqlCommand cmd4 = con.CreateCommand();

            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select dId,dName,dage ,phone,address,city,mail,nationalId ,gender,dpassword from doctor";
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();
            DataTable data = new DataTable();
            MySqlDataAdapter g = new MySqlDataAdapter(cmd4);
            g.Fill(data);
            dataGridView1.DataSource = data;



        }
       


   

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("National ID is missing please enter National ID to update a doctor record");
            }

            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox7.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("There is missing data please check your Name, age, phone, National Id and password");
                }
                else
                {
                    string update = " update doctor set dname='" + textBox1.Text + "' ,dage = '" + textBox2.Text + "',phone = '" + textBox3.Text + "',address= '" + textBox4.Text + "' ,city ='" + textBox5.Text + "',mail= '" + textBox6.Text + "' ,gender ='" + comboBox1.Text + "',dpassword = '" + textBox9.Text + "'where nationalId ='" + textBox7.Text + "'";
                    MySqlCommand cmd4 = new MySqlCommand(update, con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    fill_grid();
                    MessageBox.Show("Doctor updated successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("National ID is missing please enter National ID to delete a doctor");
            }
            else
            {
                string delete = " delete from doctor where nationalId ='" + textBox7.Text + "'";
            MySqlCommand cmd5 = new MySqlCommand(delete, con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
            cmd5.ExecuteNonQuery();
            con.Close();
            fill_grid();
                MessageBox.Show("Doctor deleted successfully");
            }

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            HR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox7.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("There is missing data please check  Name, age, phone, National Id and password");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string Pinsert = "insert into  doctor (dName,dage ,phone,address,city,mail,nationalId ,gender,dpassword) values(  '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + textBox7.Text + "' , '" + comboBox1.Text + "' , '" + textBox9.Text + "')";
                MySqlCommand cmd = new MySqlCommand(Pinsert, con);
                cmd.ExecuteNonQuery();
                con.Close();
                fill_grid();
                 if (con.State == ConnectionState.Closed)

                    con.Open();
                string select = "select * from doctor where nationalId='" + textBox7.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(select, con);
                MySqlDataReader d = cmd2.ExecuteReader();
                while (d.Read())
                {
                    e4 = d["dId"].ToString();

                }

                con.Close();
                MessageBox.Show("Doctor Added ,This is his/her ID=" + e4 + " ");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
                textBox9.Text = "";

            }
        }
    }

            }
       
  

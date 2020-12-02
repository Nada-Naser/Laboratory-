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
    public partial class Receptionist_Info : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password =123456789");
        string e4;
        public Receptionist_Info()
        {
            InitializeComponent();
        }
        public void fillGrid()
        {
            if (con.State == ConnectionState.Closed)

                con.Open();
            MySqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select* from receptionist";
            cmd4.ExecuteNonQuery();
            DataTable data = new DataTable();
            MySqlDataAdapter g = new MySqlDataAdapter(cmd4);
            g.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("There is missing data please check Name, age, phone, National Id ,password and your type ");
            }
            else
            {
                if (con.State == ConnectionState.Closed)

                    con.Open();
                string Pinsert = "insert into  receptionist (rName,age,phone,address,city,nationalId ,gender,Recptype,rpassword) values(  '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + comboBox1.Text + "' , '" + textBox8.Text + "' , '" + textBox9.Text + "')";
                MySqlCommand cmd = new MySqlCommand(Pinsert, con);
                cmd.ExecuteNonQuery();
                con.Close();
                fillGrid();
               
                if (con.State == ConnectionState.Closed)

                    con.Open();
                string select = "select * from receptionist where nationalId='" + textBox6.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(select, con);
                MySqlDataReader d = cmd2.ExecuteReader();
                while (d.Read())
                {
                    e4 = d["rId"].ToString();

                }

                con.Close();
                MessageBox.Show("Receptionist Added ,This is his/her ID=" + e4 + " ");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";



            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("National ID is missing please enter National ID to update a receptionist record");
            }

            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("There is missing data please check your Name, age, phone, National Id ,password and your type ");
                }
                else
                {
                    string update = " update receptionist set rName='" + textBox1.Text + "' ,age = '" + textBox2.Text + "',phone = '" + textBox3.Text + "',address= '" + textBox4.Text + "' ,city ='" + textBox5.Text + "' ,gender ='" + comboBox1.Text + "',Recptype='" + textBox8.Text + "',rpassword = '" + textBox9.Text + "'where nationalId ='" + textBox6.Text + "'";
                    MySqlCommand cmd4 = new MySqlCommand(update, con);
                    if (con.State == ConnectionState.Closed)

                        con.Open();
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    MessageBox.Show("receptionist updated successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("National ID is missing please enter National ID to delete a receptionist");
            }
            else
            {
                string delete = " delete from receptionist where nationalId ='" + textBox6.Text + "'";
                MySqlCommand cmd5 = new MySqlCommand(delete, con);
                if (con.State == ConnectionState.Closed)

                    con.Open();
                cmd5.ExecuteNonQuery();
                con.Close();
                fillGrid();
                MessageBox.Show("receptionist deleted successfully");
            }
        }

        private void Receptionist_Info_Load(object sender, EventArgs e)
        {
            fillGrid();

            string[] g = { "male", "female" };
            comboBox1.Items.AddRange(g);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HR_form HR = new HR_form();
            HR.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("When HR_Manager wants to modify or Delete patient information he should search by his National ID");

        }
    }
}
//(   '" + textBox1.Text +"', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "' ,'" + textBox5.Text + "', '" + textBox6.Text + "' , '" + textBox7.Text + "' ,'" + textBox8.Text + "', '" + "','" + textBox9.Text + "')";

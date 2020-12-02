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
    public partial class Edit_patient : Form
    {
        string e4;
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        Receptionist_Form RF = new Receptionist_Form();
        public Edit_patient()
        {
            InitializeComponent();
            fillGrid();

            
        }

        public void fillGrid() {
            if (con.State == ConnectionState.Closed)

                con.Open();
            try
            { 
                MySqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select* from patient";
                cmd4.ExecuteNonQuery();
                DataTable data = new DataTable();
                MySqlDataAdapter g = new MySqlDataAdapter(cmd4);
                g.Fill(data);
                dataGridView1.DataSource = data;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
        }

       
        private void Edit_patient_Load(object sender, EventArgs e)
        {

            string[] g = { "male", "female" };
            comboBox1.Items.AddRange(g);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("you should enter National Id to update patient record");
            }
            else
            {
                string update = " update patient set pname='" + textBox1.Text + "' ,ptAge = '" + textBox3.Text
                    + "',gender = '" + comboBox1.Text  + "',address= '" + textBox4.Text 
                    + "' ,city ='" + textBox7.Text + "',mail= '" + textBox5.Text + "',referencedBy= '"
                    + textBox8.Text + "',phone= '" + textBox6.Text + "' where nationalId ='" + textBox10.Text
                    + "'and pdate= '" + textBox9.Text+"'";
                MySqlCommand cmd4 = new MySqlCommand(update, con);
                 con.Open();
                cmd4.ExecuteNonQuery();
                con.Close();
                fillGrid();
                MessageBox.Show("Patient has been modified successfully");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox11.Text == "")
            {
                MessageBox.Show("Patient ID is missing please enter patient ID to delete a patient");
            }
            else
            {
                string delete = " delete from patient where pid ='" + textBox11.Text + "'";
                MySqlCommand cmd5 = new MySqlCommand(delete, con);
                if (con.State == ConnectionState.Closed)

                    con.Open();
                cmd5.ExecuteNonQuery();
                con.Close();
                fillGrid();
                MessageBox.Show("Patient is deleted successfully");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RF.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show(@"When receptionist wants to modify patient information he should search by his National ID
            and when he wants to delete a patient record he should delete by his ID");

        }
    }
}

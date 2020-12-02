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
    public partial class Analysis : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        MySqlCommand cmd2;
        bool b = true;
        Doctor_form Dr = new Doctor_form();
        public Analysis()
        {
            InitializeComponent();
           
          
            dataGridView1.Columns[3].Width = 100;
            Fillcombo();
        }

        void Fillcombo()
        {
            comboBox1.Items.Clear();
            con.Open();
            string s = "select * from AnalysisCatigory ";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                string analysisName = d.GetString("anName");
                comboBox1.Items.Add(analysisName);

            }
            con.Close();

        }
        private void Analysis_Load(object sender, EventArgs e)
        {


        }

        private void savecategory_Click(object sender, EventArgs e)
        { for (int i = 0; i < comboBox1.Items.Count; i++)
            { if (comboBox1.Text == comboBox1.Items[i].ToString())
                { b = false; break; }
            }
            if (b == true)
            { string Ainsert = "insert into analysisCatigory (anName)value('" + comboBox1.Text + "')";
                MySqlCommand cmd6 = new MySqlCommand(Ainsert, con);
                con.Open();
                cmd6.ExecuteNonQuery();
                con.Close();

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                { try
                    {string Sinsert = "insert into analysisattributes (anName,dename,normalValue,measuringUnit,cost)values('" 
                            + comboBox1.Text + "' , '" + dataGridView1.Rows[i].Cells[0].Value + "' , '" + 
                            dataGridView1.Rows[i].Cells[1].Value + "' , '" + dataGridView1.Rows[i].Cells[2].Value + "' , '" 
                            + dataGridView1.Rows[i].Cells[3].Value + "')";
                        cmd2 = new MySqlCommand(Sinsert, con);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        
                    }
                    catch (Exception   ex) { MessageBox.Show(ex.Message); }
                }
                MessageBox.Show("Analysis is added Successfully");

                Fillcombo();
            } }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s3 = "select dename,normalValue,measuringUnit,cost from analysisattributes where anName= '" + comboBox1.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(s3, con);
            MySqlDataAdapter g = new MySqlDataAdapter(s3, con);

            DataTable data = new DataTable();
            g.Fill(data);
            dataGridView1.DataSource = data;

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            string o = "delete  from analysisCatigory where anName= '" + comboBox1.Text + "'";
            MySqlCommand cmd7 = new MySqlCommand(o, con);
            string v = "delete  from analysisattributes where anName= '" + comboBox1.Text + "'";
            MySqlCommand cmd8 = new MySqlCommand(v, con);
            comboBox1.Items.Remove(comboBox1.Text);
          
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
            con.Open();
            cmd7.ExecuteNonQuery();
            cmd8.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Analysis is deleted");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dr.ShowDialog();
           
        }
    }
}

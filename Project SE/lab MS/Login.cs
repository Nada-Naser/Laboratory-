using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lab_MS
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; Initial Catalog = laboratory; User ID = root; Password = 123456789");
        int i;
        public Login()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from doctor where dName= '" + textBox1 + "'dpassword='" + textBox2 + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter madabter = new MySqlDataAdapter(cmd);
            madabter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
                MessageBox.Show("invalid");
           else
                MessageBox.Show("valid");
            con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginD Login = new LoginD();
            Login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginR rlogin = new LoginR();
            rlogin.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginHR hrlogin = new LoginHR();
            hrlogin.ShowDialog();

        }

       
    }
}

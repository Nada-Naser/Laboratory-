using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_MS
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
            //dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[3].Width = 100;
        }

        private void Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}

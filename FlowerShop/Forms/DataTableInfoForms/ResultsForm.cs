using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(DataTable table)
        {
            InitializeComponent();
            dataGridViewResults.DataSource = table;
        }
        public ResultsForm(DataTable table, string info)
        {
            InitializeComponent();
            dataGridViewResults.DataSource = table;
            textBoxOutput.Text = info;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

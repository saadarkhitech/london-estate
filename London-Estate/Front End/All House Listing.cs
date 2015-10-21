using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace London_Estate
{
    public partial class All_House_Listing : Form
    {
        public All_House_Listing()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            House_Management hm = new House_Management();
            hm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

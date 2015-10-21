using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace London_Estate.Front_End
{
    public partial class Add_New_House : Form
    {
        public Add_New_House()
        {
            InitializeComponent();
        }

        private void btn_addplaza_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_House_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            House_Management hm = new House_Management();
            hm.Show();
            this.Hide();
        }
    }
}

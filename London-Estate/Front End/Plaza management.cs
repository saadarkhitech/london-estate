using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace London_Estate
{
    public partial class Plaza_management : Form
    {
        public Plaza_management()
        {
            InitializeComponent();
        }

        private void btn_viewallplaza_Click(object sender, EventArgs e)
        {

        }

        private void btn_addnewplaza_Click(object sender, EventArgs e)
        {
            Form New_Plaza_Information = new New_Plaza_Information();

            New_Plaza_Information.Show();

            this.Hide();
        }
    }
}

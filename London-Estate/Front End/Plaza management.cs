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
        //    All_Plaza_Listing apl = new All_Plaza_Listing();
        //    apl.Show();
        //    this.Hide();
        }

        private void btn_addnewplaza_Click(object sender, EventArgs e)
        {
            Form New_Plaza_Information = new New_Plaza_Information();

            New_Plaza_Information.Show();

            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashborad_form = new dashboard();

            dashborad_form.Show();
            this.Hide();
        }
    }
}

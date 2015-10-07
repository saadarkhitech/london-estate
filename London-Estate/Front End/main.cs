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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void lb_Logo_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Form dashborad_form = new dashboard();
            
            dashborad_form.Show();

            this.Hide();
            
        }
       
            
    }
}

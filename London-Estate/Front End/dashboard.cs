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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btn_housemanagement_Click(object sender, EventArgs e)
        {
            Form house_manage = new House_Management();
            house_manage.Show();
            this.Hide();
        }

        private void btn_plazamanagement_Click(object sender, EventArgs e)
        {
            Form plaza_manage = new Plaza_management();
            plaza_manage.Show();
            this.Hide();
        }

        private void btn_ownerinfo_Click(object sender, EventArgs e)
        {
            Owner_Information Ow = new Owner_Information();
            Ow.Show();
            this.Hide();

        }

        private void btn_renterinfo_Click(object sender, EventArgs e)
        {
            //Rental_nformation ri = new Rental_nformation();
            //ri.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Monthly_Rent_Information mri = new Monthly_Rent_Information();
            //mri.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

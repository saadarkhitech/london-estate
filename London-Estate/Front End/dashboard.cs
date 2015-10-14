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
        }

        private void btn_plazamanagement_Click(object sender, EventArgs e)
        {
            Form plaza_manage = new Plaza_management();
            plaza_manage.Show();
        }

        private void btn_ownerinfo_Click(object sender, EventArgs e)
        {
            Owner_Information Ow = new Owner_Information();
            Ow.Show();

        }
    }
}

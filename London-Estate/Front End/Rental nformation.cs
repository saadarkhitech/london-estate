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
    public partial class Rental_nformation : Form
    {
        public Rental_nformation()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashborad_form = new dashboard();

            dashborad_form.Show();
            this.Hide();
        }

        private void Rental_nformation_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_plazalocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_agreeend_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

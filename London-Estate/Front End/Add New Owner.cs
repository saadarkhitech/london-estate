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
    public partial class Add_New_Owner : Form
    {
        public Add_New_Owner()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_plazaOwnerInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox_ownership.Items.Add("Shop");
            comboBox_ownership.Items.Add("Flat");

            comboBox_ownership.SelectedItem = "Shop";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

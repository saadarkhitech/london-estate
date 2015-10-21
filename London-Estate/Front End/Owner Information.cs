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
    public partial class Owner_Information : Form
    {
        public Owner_Information()
        {
            InitializeComponent();
        }

        

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_housesOwnerlist_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_AddOwner_Click(object sender, EventArgs e)
        {
            Add_New_Owner adnewowner = new Add_New_Owner();
            adnewowner.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashborad_form = new dashboard();
            dashborad_form.Show();
            this.Hide();
        }

        private void Btn_newhouseowner_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_plazaOwnerList_Click(object sender, EventArgs e)
        {

        }
    }
}

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

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rsDbDataSet.Plaza' table. You can move, or remove it, as needed.
            this.plazaTableAdapter.Fill(this.rsDbDataSet.Plaza);

        }
    }
}

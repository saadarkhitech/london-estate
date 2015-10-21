using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DController dc = new DController();
            SqlDataReader rdr = dc.getAllPlazaInfo();
            // comboBox_Plaza.DataSource = rdr;

            while (rdr.Read())
            {
                comboBox_Plaza.Items.Add(rdr[0].ToString());

            }
           
          
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
           

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.plazaTableAdapter1.FillBy(this.allDataSelected.Plaza);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox_Plaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_floor.Items.Clear();
            int pid = int.Parse(comboBox_Plaza.SelectedItem.ToString());
            DController dc = new DController();
            SqlDataReader rdr = dc.getFloorsPlaza(pid);

            while (rdr.Read())
            {
                comboBox_floor.Items.Add(rdr[0].ToString());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_shopflat.Items.Clear();
            string fid = comboBox_floor.SelectedItem.ToString();
            DController dc = new DController();
            SqlDataReader rdr1 = dc.getShopsOfFloor(fid);
            SqlDataReader rdr2 = dc.getFlatsOfFloor(fid);

            while (rdr1.Read())
            {
                comboBox_shopflat.Items.Add(rdr1[0].ToString());
            }
            while (rdr2.Read())
            {
                comboBox_shopflat.Items.Add(rdr2[0].ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plazaID = comboBox_Plaza.SelectedItem.ToString();
            string FloorId = comboBox_floor.SelectedItem.ToString();
            string FtId_shopId = comboBox_shopflat.SelectedItem.ToString();
            string OwnerName = textBox1.Text;
            string cninc = textBox4.Text;
            string contactNo = textBox3.Text;
            string bankName = textBox2.Text;
            string accNo = textBox5.Text;

            DController dc = new DController();
            int owId = dc.addOwner(OwnerName, cninc, DateTime.Today.Date, contactNo, bankName, accNo);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner_Information Owner_Information_form = new Owner_Information();

            Owner_Information_form.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_housenumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_houseaddres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_plazalocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_floor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_PlazaOwnerName_Click(object sender, EventArgs e)
        {

        }

        private void radio_plazaOwner_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void radio_houseOwner_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}

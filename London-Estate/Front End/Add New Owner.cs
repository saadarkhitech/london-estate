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
            
            SqlDataReader rdr = FController.getController().getAllPlazaIds();

            while (rdr.Read())
            {
                comboBox_Plaza.Items.Add(rdr[0].ToString());
                
            }
          
        }
         
                     
        private void Add_New_Owner_Load(object sender, EventArgs e)
        {
           

        }

     

        private void comboBox_Plaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int pid = int.Parse(comboBox_Plaza.SelectedItem.ToString());
            
            SqlDataReader rdr =  FController.getController().getFloorsPlaza(pid);

            while (rdr.Read())
            {
                comboBox2.Items.Add(rdr[0].ToString());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string fid = comboBox2.SelectedItem.ToString();
            
            SqlDataReader rdr1 = FController.getController().getShopsOfFloor(fid);
            SqlDataReader rdr2 = FController.getController().getFlatsOfFloor(fid);

            while (rdr1.Read())
            {
                comboBox1.Items.Add(rdr1[0].ToString());
            }
            while (rdr2.Read())
            {
                comboBox1.Items.Add(rdr2[0].ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plazaID = comboBox_Plaza.SelectedItem.ToString();
            string FloorId = comboBox2.SelectedItem.ToString();
            string FtId_shopId = comboBox1.SelectedItem.ToString();
            string OwnerName = textBox1.Text;
            string cninc = textBox4.Text;
            string contactNo = textBox3.Text;
            string bankName = textBox2.Text;
            string accNo = textBox5.Text;

            
           int owId = FController.getController().addOwner(OwnerName, cninc, DateTime.Today.Date, contactNo, bankName, accNo);

           if (FController.getController().diffRentiateFlatShop(FtId_shopId))
           {
               // owner of shop
               FController.getController().addOwnerOfShop(FtId_shopId, owId);
           }
           else
           { 
                // owner of flat
               FController.getController().addOwnerOfFlat(FtId_shopId, owId);
           }
        }
    }
}

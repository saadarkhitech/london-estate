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
    public partial class New_Plaza_Information : Form
    {
        public New_Plaza_Information()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Plazafloors_Click(object sender, EventArgs e)
        {

        }

        private void New_Plaza_Information_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_plazafloors_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int floors = int.Parse(tb_plazafloors.Text); //int.Parse(tb_plazafloors.Text);
            Label[] lab_floor = new Label[floors];
            TextBox[] tb = new TextBox[floors];
            for (int i = 0; i < floors; i++)
            {
                lab_floor[i] = new Label();
                lab_floor[i].Text = i.ToString();
                lab_floor[i].Visible = true;



                tb[i] = new TextBox();
                tb[i].Text = i.ToString();
                tb[i].Visible = true;
                tb[i].Location = new Point(i * 20, i * 40);
                this.Controls.Add(tb[i]);
            }
        }

        private void btn_addplaza_Click(object sender, EventArgs e)
        {
            string plzaName = tb_plazaname.Text;
            int floors = int.Parse(tb_plazafloors.Text);
            string loc = tb_plazalocation.Text;
            string add = tb_plazaaddress.Text;
            int[] s_f = new int[floors];
            
            
                for (int i=0, j = 0; i < this.Controls.Count || j < floors; i++)
                {  // Check this control
                    Control c = this.Controls[i];
                    if (c.Name == "")
                    { // mujhe apna cntrol ml gya hy jo chyes ab us k bachy dhondne hy
                        int a; // ager ider debuger agay tu control mil gya hy 
                        TextBox x = (TextBox)c;
                        s_f[j] = int.Parse(x.Text);
                        j++;

                    }

                    else
                    {
                        // ager ider aya tu ni mila
                    }

                }
                int total_flats=0,total_shops=0;

                if (checkBox_basment.Checked)
                {
                    total_shops += s_f[0];
                    total_shops += s_f[1];
                    for (int i = 2; i < floors; i++)
                    {
                        total_flats += s_f[i];
                    }
                }
                else
                {
                    total_shops += s_f[0];

                    for (int i = 1; i < floors; i++)
                    {
                        total_flats += s_f[i];
                    }
                }
               

                FController.getController().addPlaza(plzaName, floors, total_shops, total_flats, add, loc,checkBox_basment.Checked,s_f);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plaza_management pm = new Plaza_management();
            pm.Show();
            this.Hide();
        }
    }
}

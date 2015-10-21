using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace London_Estate.Front_End
{
    public partial class User_Recieved_Rent_Information : Form
    {
        public User_Recieved_Rent_Information()
        {
            InitializeComponent();
        }

        public void User_Recieved_Rent_Information_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Other_Expenses_Details oed = new Other_Expenses_Details();
            oed.Show();
            
        }

        private void btn__Click(object sender, EventArgs e)
        {
            Monthly_Rent_Information mri = new Monthly_Rent_Information();
            mri.Show();
            this.Hide();
        }
    }
}

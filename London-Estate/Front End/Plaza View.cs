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
    public partial class Plaza_View : Form
    {
        public Plaza_View()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            All_Plaza_Listing apl = new All_Plaza_Listing();
            apl.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class usr_Home : UserControl
    {
        cls_Devices dev = new cls_Devices();

        public usr_Home()
        {
            InitializeComponent();
        }

        private void usr_Home_Load(object sender, EventArgs e)
        {
            

            txt_Stock.Text = dev.DevStockCount().ToString();
            txt_Stock.ReadOnly = true;

            txt_Branch.Text = dev.DevNonStockCount().ToString();
            txt_Branch.ReadOnly = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usr_Home_Load(null, null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class frm_Category_New : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();
        
        public frm_Category_New()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_ShrtName.Text))
            {
                cat.Insert(txt_Name.Text, txt_ShrtName.Text);
                txt_Name.Clear();
                txt_ShrtName.Clear();
                txt_Name.Focus();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
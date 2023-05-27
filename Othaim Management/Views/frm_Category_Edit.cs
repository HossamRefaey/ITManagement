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
    public partial class frm_Category_Edit : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();
        public frm_Category_Edit()
        {
            InitializeComponent();
        }

        private void frm_Category_Edit_Load(object sender, EventArgs e)
        {
            var result = cat.findByID(Properties.Settings.Default.id);
            foreach (var item in result)
            {
                txt_Name.Text = item.Name;
                txt_ShrtName.Text = item.shrt_id;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_ShrtName.Text))
            {
                cat.Update(Properties.Settings.Default.id, txt_Name.Text, txt_ShrtName.Text);
                Close();
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
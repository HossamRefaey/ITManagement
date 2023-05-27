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
    public partial class frm_Device_Type_Edit : DevExpress.XtraEditors.XtraForm
    {
        cls_DevType type = new cls_DevType();
        cls_Category cat = new cls_Category();

        void cbxTypeFill()
        {
            cbx_DevTypeList.DataSource = cat.List();
            cbx_DevTypeList.ValueMember = "ID";
            cbx_DevTypeList.DisplayMember = "Name";
        }

        public frm_Device_Type_Edit()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && cbx_DevTypeList.SelectedValue != null)
            {
                type.Update(Properties.Settings.Default.id, txt_Name.Text, int.Parse(cbx_DevTypeList.SelectedValue.ToString()));
                Close();
            }
            else
            {
                MessageBox.Show("يرجى إكمال البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_Device_Type_Edit_Load(object sender, EventArgs e)
        {
            cbxTypeFill();

            var result = type.findByID(Properties.Settings.Default.id);
            foreach (var item in result)
            {
                txt_Name.Text = item.dev_type;
                cbx_DevTypeList.SelectedValue = item.Category_ID;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_DevTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
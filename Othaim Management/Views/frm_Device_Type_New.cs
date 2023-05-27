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
    public partial class frm_Device_Type_New : DevExpress.XtraEditors.XtraForm
    {
        cls_DevType devType = new cls_DevType();
        cls_Category cat = new cls_Category();

        void cbxTypeFill()
        {
            cbx_DevTypeList.DataSource = cat.List();
            cbx_DevTypeList.ValueMember = "ID";
            cbx_DevTypeList.DisplayMember = "Name";
        }

        void refresh()
        {
            cbxTypeFill();
            txt_Name.Clear();
            cbx_DevTypeList.SelectedIndex = -1;
            txt_Name.Focus();
        }

        public frm_Device_Type_New()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && cbx_DevTypeList.SelectedValue !=null)
            {
                devType.Create(txt_Name.Text, int.Parse(cbx_DevTypeList.SelectedValue.ToString()));
                refresh();
            }
            else
            {
                MessageBox.Show("يرجى إكمال البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_Device_Type_New_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
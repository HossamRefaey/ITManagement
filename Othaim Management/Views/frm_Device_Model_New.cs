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
    public partial class frm_Device_Model_New : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();
        cls_DevType type = new cls_DevType();
        cls_DevModel model = new cls_DevModel();

        void cbx_CatFill()
        {
            cbx_Category.DataSource = cat.List();
            cbx_Category.ValueMember = "ID";
            cbx_Category.DisplayMember = "Name";
        }
        
        void refresh()
        {
            cbx_CatFill();
            cbx_Category.SelectedIndex = -1;
            cbx_DevType.DataSource = null;
            txt_ModelName.Clear();
            txt_itemCode.Clear();
            txt_ModelName.Focus();
        }

        public frm_Device_Model_New()
        {
            InitializeComponent();
        }

        private void frm_Device_Model_New_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbx_Category.SelectedValue.ToString());

                var result = type.findByCatID(id);
                if (result.Count<=0)
                {
                    cbx_DevType.DataSource = null;
                }
                else
                {
                    cbx_DevType.DataSource = result;
                    cbx_DevType.ValueMember = "id";
                    cbx_DevType.DisplayMember = "dev_type";
                }
                    

            }
            catch (Exception) { return; }
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_itemCode.Text) && !string.IsNullOrWhiteSpace(txt_ModelName.Text))
            {
                model.Create(txt_ModelName.Text,txt_itemCode.Text,int.Parse(cbx_DevType.SelectedValue.ToString()), int.Parse(cbx_Category.SelectedValue.ToString()));
                refresh();
            }
            else
            {
                MessageBox.Show("يرجى إكمال البيانات الناقصة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

}

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
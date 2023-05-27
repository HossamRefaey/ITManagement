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
    public partial class frm_Device_Model_Edit : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();
        cls_DevType type = new cls_DevType();
        cls_DevModel model = new cls_DevModel();

        void cbxCategoryFill()
        {
            cbx_Category.DataSource = cat.List();
            cbx_Category.ValueMember = "ID";
            cbx_Category.DisplayMember = "Name";
        }

        void cbxTypeFill()
        {
            cbx_DevType.DataSource = type.List();
            cbx_DevType.ValueMember = "id";
            cbx_DevType.DisplayMember = "dev_type";
        }
        void CurrentModel()
        {
            try
            {
                cbxCategoryFill();
                cbxTypeFill();

                var result = model.findByID(Properties.Settings.Default.id);
                foreach (var item in result)
                {
                    txt_ModelName.Text = item.Name;
                    txt_itemCode.Text = item.Item_Code;
                    cbx_DevType.SelectedValue = item.devType_ID;
                    cbx_Category.SelectedValue = item.category_ID;
                }
            }
            catch (Exception){ return; }
            

            
        }

        public frm_Device_Model_Edit()
        {
            InitializeComponent();
        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Device_Model_Edit_Load(object sender, EventArgs e)
        {
            CurrentModel();
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbx_Category.SelectedValue.ToString());

                var result = type.findByCatID(id);
                if (result.Count <= 0)
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

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_itemCode.Text) && !string.IsNullOrWhiteSpace(txt_ModelName.Text))
            {
                int id = Properties.Settings.Default.id;
                model.Update(id, txt_ModelName.Text, txt_itemCode.Text, int.Parse(cbx_DevType.SelectedValue.ToString()), int.Parse(cbx_Category.SelectedValue.ToString()));
                Close();
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
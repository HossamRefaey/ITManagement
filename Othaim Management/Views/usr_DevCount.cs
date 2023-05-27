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

    public partial class usr_DevCount : UserControl
    {


        cls_Category cat = new cls_Category();
        cls_DevType dev_type = new cls_DevType();
        cls_DevModel model = new cls_DevModel();
        
        cls_Devices dev = new cls_Devices();
        cls_Branch branch = new cls_Branch();
        cls_deviceCycle devCycle = new cls_deviceCycle();
        cls_Users usr = new cls_Users();

        void cbxCategoryFill()
        {
            cbx_CategoryList.DataSource = cat.List();
            cbx_CategoryList.ValueMember = "category_id";
            cbx_CategoryList.DisplayMember = "Name";
            cbx_CategoryList.SelectedIndex = -1;
        }

        void cbxDevTypeFill()
        {
            try
            {

                cbx_DevType.DataSource = dev_type.findByCatID(int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                cbx_DevType.ValueMember = "devType_ID";
                cbx_DevType.DisplayMember = "dev_type";
                cbx_DevType.SelectedIndex = -1;

            }
            catch { }

        }

        void cbxBranchlFill()
        {
            try
            {
                //cbx_BranchList.DataSource = branch.ListByStoreTrue();
                //cbx_BranchList.ValueMember = "branch_id";
                //cbx_BranchList.DisplayMember = "Name";
                //cbx_BranchList.SelectedIndex = -1;
            //    if (Properties.Settings.Default.stock == false)
            //    {
            //        getUserID();
            //        cbx_BranchList.DataSource = branch.ListByBranchUser(userID);
            //        cbx_BranchList.ValueMember = "branch_id";
            //        cbx_BranchList.DisplayMember = "Name";
            //        cbx_BranchList.SelectedIndex = -1;


                //        cbx_BranchSearch.DataSource = branch.ListByBranchUser(userID);
                //        cbx_BranchSearch.ValueMember = "branch_id";
                //        cbx_BranchSearch.DisplayMember = "Name";
                //        cbx_BranchSearch.SelectedIndex = -1;
                //    }
                //    elseif (Properties.Settings.Default.stock == true)
                //    {
                //        getUserID();
                //        cbx_BranchList.DataSource = branch.List();
                //        cbx_BranchList.ValueMember = "branch_id";
                //        cbx_BranchList.DisplayMember = "Name";
                //        cbx_BranchList.SelectedIndex = -1;


                //        cbx_BranchSearch.DataSource = branch.List();
                //        cbx_BranchSearch.ValueMember = "branch_id";
                //        cbx_BranchSearch.DisplayMember = "Name";
                //        cbx_BranchSearch.SelectedIndex = -1;
                //    }



                }
            catch { }
        }
        void cbxModelFill()
        {
            try
            {


                cbx_DevModel.DataSource = model.findByTypeID(int.Parse(cbx_DevType.SelectedValue.ToString()));
                cbx_DevModel.ValueMember = "model_id";
                cbx_DevModel.DisplayMember = "Name";
                cbx_DevModel.SelectedIndex = -1;
            }
            catch { }
        }

        public usr_DevCount()
        {
            InitializeComponent();
        }

        void refresh()
        {
            cbxBranchlFill();
            //cbx_DevModelSearch();
            cbxCategoryFill();
           
            cbx_CategoryList.Enabled = false;
            cbx_DevType.Enabled = false;
            cbx_DevModel.Enabled = false;
            cbx_BranchList.Enabled = false;
            txt_Name.ReadOnly = true;
            txt_SN.ReadOnly = true;
            txt_DevCount.ReadOnly = true;
           
            btn_Save.Visible = false;
            txt_Name.Clear();
            txt_Search.Clear();
            txt_SN.Clear();
            //dgvfill();
        }

        private void usr_DevCount_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd-MM-yyyy");
       

            //if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_DevCount.Text) && !string.IsNullOrWhiteSpace(txt_SN.Text) && cbx_CategoryList.SelectedItem != null &&
            //    cbx_DevType.SelectedItem != null && cbx_DevModel.SelectedValue != null && cbx_BranchList.SelectedItem != null)
            //{
            //    var result = dev.ChekSerialCount(txt_SN.Text,int.Parse(cbx_BranchList.SelectedValue.ToString()));
            //    if (result.Count > 0)
            //    {
            //        dev.UpdateCount(txt_SN.Text,int.Parse(cbx_BranchList.SelectedValue.ToString()), int.Parse(txt_DevCount.Text));
            //        MessageBox.Show("تم إضافة الكمية بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        dev.CreateItemCount(txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
            //            int.Parse(cbx_CategoryList.SelectedValue.ToString()), Convert.ToDateTime(date), int.Parse(cbx_BranchList.SelectedValue.ToString()), int.Parse(txt_DevCount.Text));
            //        MessageBox.Show("تم إضافة الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_SN.Clear();
            txt_RowCount.Clear();
            txt_SN.Clear();
            txt_DevCount.Clear();
            cbx_CategoryList.Enabled = true;
            cbx_CategoryList.SelectedIndex = -1;
            cbx_DevType.Enabled = true;
            cbx_DevType.SelectedIndex = -1;
            cbx_DevModel.Enabled = true;
            cbx_DevModel.SelectedIndex = -1;
            cbx_BranchList.Enabled = true;
            cbx_BranchList.SelectedIndex = -1;
            cbx_BranchSearch.SelectedIndex = -1;
            txt_Name.ReadOnly = false;
            txt_DevCount.ReadOnly = false;
            //txt_SN.ReadOnly = false;
           
            btn_Save.Visible = true;
            cbx_DevModel.DataSource = null;
            cbx_DevType.DataSource = null;
            txt_Name.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void cbx_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDevTypeFill();
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModelFill();
        }

        private void cbx_DevModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = model.findByID(int.Parse(cbx_DevModel.SelectedValue.ToString()));
            foreach (var item in result)
            {
                txt_SN.Text = item.Item_Code.ToString();
            }
        }
    }
}

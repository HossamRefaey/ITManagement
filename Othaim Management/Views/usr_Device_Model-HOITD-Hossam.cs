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
    public partial class usr_Device_Model : UserControl
    {
        cls_DevType type = new cls_DevType();
        cls_Category cat = new cls_Category();
        cls_DevModel model = new cls_DevModel();
        public int currentID;

        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.mdlNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.mdlEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.mdlDeletebtn;


        }
        void cbxCategoryFill()
        {
            cbx_CategoryList.DataSource = cat.List();
            cbx_CategoryList.ValueMember = "category_ID";
            cbx_CategoryList.DisplayMember = "Name";
            cbx_CategoryList.SelectedIndex = -1;
        }

        //void cbxTypeFill()
        //{
        //    cbx_DevType.DataSource = type.List();
        //    cbx_DevType.ValueMember = "id";
        //    cbx_DevType.DisplayMember = "dev_type";
        //    cbx_DevType.SelectedIndex = -1;
        //}
        void dgvfill()
        {
            try
            {
                dgv_ModelList.Rows.Clear();
                var result = model.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_ModelList.Rows.Add(1);
                    dgv_ModelList.Rows[rowindex].Cells[0].Value = item.model_id.ToString();
                    dgv_ModelList.Rows[rowindex].Cells[1].Value = item.Name;
                    dgv_ModelList.Rows[rowindex].Cells[2].Value = item.Item_Code;
                    dgv_ModelList.Rows[rowindex].Cells[3].Value = item.sys_dev_type.dev_type;


                    rowindex++;
                }
                label1.Text = "عدد السجلات : " + dgv_ModelList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void Search()
        {
            dgv_ModelList.Rows.Clear();
            var result = model.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_ModelList.Rows.Add(1);
                dgv_ModelList.Rows[rowindex].Cells[0].Value = item.model_id.ToString();
                dgv_ModelList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_ModelList.Rows[rowindex].Cells[2].Value = item.Item_Code;
                dgv_ModelList.Rows[rowindex].Cells[3].Value = item.sys_dev_type.dev_type;


                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_ModelList.Rows.Count.ToString();
        }

        void refresh()
        {
            //cbxTypeFill();
            cbxCategoryFill();

            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_ModelName.ReadOnly = true;
            txt_itemCode.ReadOnly = true;
            txt_ModelName.Clear();
            txt_Search.Clear();
            txt_itemCode.Clear();
            cbx_CategoryList.Enabled = false;
            cbx_DevType.Enabled = false;
            dgvfill();
            dgv_ModelList.ClearSelection();

        }

        public usr_Device_Model()
        {
            InitializeComponent();
        }

        

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void usr_Device_Model_Load(object sender, EventArgs e)
        {
            permission();
            refresh();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            model.Update(currentID, txt_ModelName.Text, txt_itemCode.Text, int.Parse(cbx_DevType.SelectedValue.ToString()), int.Parse(cbx_CategoryList.SelectedValue.ToString()));
            refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_ModelName.Text)&&!string.IsNullOrWhiteSpace(txt_itemCode.Text)&&cbx_CategoryList.SelectedItem!=null&&cbx_DevType.SelectedValue!=null)
            {
                var result = model.DublicateItemCode(txt_itemCode.Text);
                if (result.Count < 1)
                {
                    model.Create(txt_ModelName.Text, txt_itemCode.Text, int.Parse(cbx_DevType.SelectedValue.ToString()), int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                    refresh();
                }
                else
                {
                    MessageBox.Show("كود الصنف مكرر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgv_TypeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_ModelList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                Search();
            }
            else { dgvfill(); }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            txt_itemCode.ReadOnly = false;
            txt_ModelName.ReadOnly = false;
            cbx_DevType.Enabled = true;
            cbx_CategoryList.Enabled = true;
            btn_Save.Visible = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_itemCode.ReadOnly = false;
            txt_ModelName.ReadOnly = false;
            cbx_DevType.Enabled = true;
            cbx_CategoryList.Enabled = true;
            btn_Save_Edit.Visible = true;
            var result = model.findByID(currentID);

            foreach (var item in result)
            {
                txt_ModelName.Text = item.Name;
                txt_itemCode.Text = item.Item_Code;
                cbx_CategoryList.SelectedValue = item.category_ID;
                cbx_DevType.SelectedValue = item.devType_ID;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            model.Delete(currentID);
            refresh();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbx_DevType.DataSource = type.findByCatID(int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                cbx_DevType.ValueMember = "devType_ID";
                cbx_DevType.DisplayMember = "dev_type";
                cbx_DevType.SelectedIndex = -1;
            }
            catch { return; }
           
        }
    }
}

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
    public partial class usr_Device_Type : UserControl
    {
        cls_DevType type = new cls_DevType();
        cls_Category cat = new cls_Category();
        public int currentID;

        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.devTypeNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.devTypeEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.devTypeDeletebtn;


        }

        void cbxTypeFill()
        {
            cbx_CategoryList.DataSource = cat.List();
            cbx_CategoryList.ValueMember = "category_ID";
            cbx_CategoryList.DisplayMember = "Name";
            cbx_CategoryList.SelectedIndex = -1;
        }
        void dgvfill()
        {
            try
            {
                dgv_TypeList.Rows.Clear();
                var result = type.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_TypeList.Rows.Add(1);
                    dgv_TypeList.Rows[rowindex].Cells[0].Value = item.devType_ID.ToString();
                    dgv_TypeList.Rows[rowindex].Cells[1].Value = item.dev_type;
                    dgv_TypeList.Rows[rowindex].Cells[2].Value = item.sys_Category.Name;


                    rowindex++;
                }
                label1.Text = "عدد السجلات : " + dgv_TypeList.Rows.Count.ToString();
            }
            catch{return;}
        }

        void Search()
        {
            dgv_TypeList.Rows.Clear();
            var result = type.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_TypeList.Rows.Add(1);
                dgv_TypeList.Rows[rowindex].Cells[0].Value = item.devType_ID.ToString();
                dgv_TypeList.Rows[rowindex].Cells[1].Value = item.dev_type;
                dgv_TypeList.Rows[rowindex].Cells[2].Value = item.sys_Category.Name;


                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_TypeList.Rows.Count.ToString();
        }

        void refresh()
        {
            cbxTypeFill();
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_Name.ReadOnly = true;
            txt_Name.Clear();
            txt_Search.Clear();
            cbx_CategoryList.Enabled = false;
            txt_Search.Clear();

            dgvfill();
            dgv_TypeList.ClearSelection();

        }


        public usr_Device_Type()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void usr_Device_Type_Load(object sender, EventArgs e)
        {
            permission();
            refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && cbx_CategoryList.SelectedItem != null)
            {
                type.Create(txt_Name.Text, int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                refresh();

            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                Search();
            }
            else { dgvfill(); }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            txt_Name.ReadOnly = false;
            cbx_CategoryList.Enabled = true;
            btn_Save.Visible = true;
            txt_Name.Focus();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                type.Update(currentID, txt_Name.Text, int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_TypeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_TypeList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null,null);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Name.ReadOnly = false;
            cbx_CategoryList.Enabled = true;
            btn_Save_Edit.Visible = true;
            btn_Delete.Enabled = true;
            int id = int.Parse(dgv_TypeList.CurrentRow.Cells[0].Value.ToString());
            var result = type.findByID(id);

            foreach (var item in result)
            {
                txt_Name.Text = item.dev_type;
                cbx_CategoryList.SelectedValue = item.Category_ID;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            type.Delete(currentID);
            refresh();
        }
    }
}

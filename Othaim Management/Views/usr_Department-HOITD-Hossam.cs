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
    public partial class usr_Department : UserControl
    {
        cls_Dept dept = new cls_Dept();
        cls_Branch branch = new cls_Branch();
        int currentID;
        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.deptNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.deptEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.deptDeletebtn;


        }

        void cbxBranchlFill()
        {

            cbx_Branch.DataSource = branch.List();
            cbx_Branch.ValueMember = "branch_id";
            cbx_Branch.DisplayMember = "Name";
            cbx_Branch.SelectedIndex = -1;



        }
        void dgvfill()
        {
            try
            {
                dgv_DeptList.Rows.Clear();
                var result = dept.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_DeptList.Rows.Add(1);
                    dgv_DeptList.Rows[rowindex].Cells[0].Value = item.dept_id.ToString();
                    dgv_DeptList.Rows[rowindex].Cells[1].Value = item.name;


                    rowindex++;
                }
                txt_Count.Text = dgv_DeptList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void Search()
        {
            try
            {
                dgv_DeptList.Rows.Clear();
                var result = dept.Search(txt_Search.Text);

                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_DeptList.Rows.Add(1);
                    dgv_DeptList.Rows[rowindex].Cells[0].Value = item.dept_id.ToString();
                    dgv_DeptList.Rows[rowindex].Cells[1].Value = item.name;


                    rowindex++;
                }
                txt_Count.Text = dgv_DeptList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void refresh()
        {
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_Dept.ReadOnly = true;
            txt_Dept.Clear();
            txt_Search.Clear();
            txt_Search.Clear();
            cbx_Branch.Enabled = false;
            cbxBranchlFill();

            dgvfill();
            dgv_DeptList.ClearSelection();

        }

        public usr_Department()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            txt_Dept.ReadOnly = false;
            btn_Save.Visible = true;
            cbx_Branch.Enabled = true;
            txt_Dept.Focus();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Dept.ReadOnly = false;
            btn_Save_Edit.Visible = true;
            btn_Delete.Enabled = true;
            cbx_Branch.Enabled = true;
            int id = int.Parse(dgv_DeptList.CurrentRow.Cells[0].Value.ToString());
            var result = dept.findByID(id);

            foreach (var item in result)
            {
                txt_Dept.Text = item.name;
                cbx_Branch.SelectedValue = item.branch_id;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                dept.Delete(currentID);
                refresh();
            }
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Dept.Text) && cbx_Branch.SelectedItem != null)
            {
                dept.Update(currentID, txt_Dept.Text,int.Parse(cbx_Branch.SelectedValue.ToString()));
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Dept.Text)&&cbx_Branch.SelectedItem!=null)
            {
                dept.Create(txt_Dept.Text, int.Parse(cbx_Branch.SelectedValue.ToString()));
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

        private void dgv_DeptList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_DeptList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void usr_Department_Load(object sender, EventArgs e)
        {
            permission();
            refresh();
        }
    } 
}

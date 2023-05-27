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
    public partial class usr_Branch : UserControl
    {
        cls_Branch branch = new cls_Branch();
        cls_Users user = new cls_Users();
        int currentID;
        int param;

        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.brNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.brEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.brDeletebtn;
            

        }

        void refresh()
        {
            checkBox1.Enabled = false;
            checkBox1.Checked = false;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_BrName.ReadOnly = true;
            txt_BrNum.ReadOnly = true;
            txt_BrShortNum.ReadOnly = true;
            txt_BrShortNum.Clear();
            txt_BrName.Clear();
            txt_BrNum.Clear();
            txt_Search.Clear();
            cbx_Users.Enabled = false;
            cbxUserFill();
            dgvfill();
            cbxSearchFill();
            dgv_BranchList.ClearSelection();
            txt_Search.Focus();
        }

        void cbxUserFill()
        {
            cbx_Users.DataSource = user.List();
            cbx_Users.ValueMember = "user_id";
            cbx_Users.DisplayMember = "Name";
            cbx_Users.SelectedIndex = -1;
        }

        void cbxSearchFill()
        {
            cbx_Search.DataSource = user.List();
            cbx_Search.ValueMember = "user_id";
            cbx_Search.DisplayMember = "Name";
            cbx_Search.SelectedIndex = -1;
        }

        void dgvfill()
        {
            try
            {
                dgv_BranchList.Rows.Clear();
                var result = branch.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_BranchList.Rows.Add(1);
                    dgv_BranchList.Rows[rowindex].Cells[0].Value = item.branch_id.ToString();
                    dgv_BranchList.Rows[rowindex].Cells[1].Value = item.shrt_id;
                    dgv_BranchList.Rows[rowindex].Cells[2].Value = item.name;
                    dgv_BranchList.Rows[rowindex].Cells[3].Value = item.sys_Users.Name;
                    rowindex++;
                }
                txt_Count.Text = dgv_BranchList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void SearchByID()
        {
            try
            {
                dgv_BranchList.Rows.Clear();
                var result = branch.Search(param);
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_BranchList.Rows.Add(1);
                    dgv_BranchList.Rows[rowindex].Cells[0].Value = item.branch_id.ToString();
                    dgv_BranchList.Rows[rowindex].Cells[1].Value = item.shrt_id;
                    dgv_BranchList.Rows[rowindex].Cells[2].Value = item.name;
                    dgv_BranchList.Rows[rowindex].Cells[3].Value = item.sys_Users.Name;
                    rowindex++;
                }
                txt_Count.Text = dgv_BranchList.Rows.Count.ToString();
            }
            catch { return; }
        }

        public usr_Branch()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            btn_Save.Visible = true;
            txt_BrName.ReadOnly = false;
            txt_BrNum.ReadOnly = false;
            txt_BrShortNum.ReadOnly = false;
            cbx_Users.Enabled = true;
            checkBox1.Enabled = true;
            txt_BrNum.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                branch.Delete(currentID);
                refresh();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            txt_BrShortNum.ReadOnly = false;
            txt_BrName.ReadOnly = false;
            cbx_Users.Enabled = true;
            btn_Save_Edit.Visible = true;
            btn_Delete.Enabled = true;
            int id = int.Parse(dgv_BranchList.CurrentRow.Cells[0].Value.ToString());
            var result = branch.findByID(id);

            foreach (var item in result)
            {
                txt_BrNum.Text = item.branch_id.ToString();
                txt_BrShortNum.Text = item.shrt_id;
                txt_BrName.Text = item.name;
                cbx_Users.SelectedValue = item.User_id;
                checkBox1.Checked = item.Main_Store.Value;
                

            }
        }

        private void btn_SearchReset_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_BrNum.Text) && !string.IsNullOrWhiteSpace(txt_BrName.Text) && !string.IsNullOrWhiteSpace(txt_BrShortNum.Text) &&
                cbx_Users.SelectedItem != null)
            {
                branch.Update(currentID, txt_BrShortNum.Text, txt_BrName.Text, int.Parse(cbx_Users.SelectedValue.ToString()),checkBox1.Checked);
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_BrNum.Text)&& !string.IsNullOrWhiteSpace(txt_BrName.Text)&& !string.IsNullOrWhiteSpace(txt_BrShortNum.Text)&&
                cbx_Users.SelectedItem!=null)
            {
                branch.Create(int.Parse(txt_BrNum.Text),txt_BrShortNum.Text,txt_BrName.Text,int.Parse(cbx_Users.SelectedValue.ToString()), checkBox1.Checked);
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void usr_Branch_Load(object sender, EventArgs e)
        {
            permission();
            refresh();
        }

        private void dgv_BranchList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_BranchList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void cbx_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_Search.SelectedItem != null)
                {
                    param = int.Parse(cbx_Search.SelectedValue.ToString());
                    SearchByID();
                }
                else
                {
                    dgvfill();
                }
            }
            catch { }
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                param = int.Parse(txt_Search.Text);
                SearchByID();
            }
            else
            {
                dgvfill();
            }
        }

        private void dgv_BranchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

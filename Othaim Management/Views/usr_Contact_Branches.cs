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
    public partial class usr_Contact_Branches : UserControl
    {
        cls_Contact_Branches contact = new cls_Contact_Branches();
        cls_Branch branch = new cls_Branch();
        int currentID;

        void refresh()
        {
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_EmpName.ReadOnly = true;
            cbx_jobList.Enabled = false;
            txt_Phone.ReadOnly = true;
            cbx_BranchList.Enabled = false;
            cbx_BranchSearch.SelectedIndex = -1;

            txt_Phone.Text = "";
            cbx_jobList.SelectedIndex=-1;
            txt_EmpName.Text = "";
            cbx_BranchList.SelectedIndex = -1;
            //dgv_PhoneListFill();
            cbxBranchListFill();
        }
        
        void dgv_PhoneListFill()
        {
            try
            {
                dgv_PhoneList.Rows.Clear();
                var result = contact.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_PhoneList.Rows.Add(1);
                    dgv_PhoneList.Rows[rowindex].Cells[0].Value = item.branch_id.ToString();
                    dgv_PhoneList.Rows[rowindex].Cells[1].Value = item.sys_branch.name;
                    dgv_PhoneList.Rows[rowindex].Cells[2].Value = item.Emp_Name;
                    dgv_PhoneList.Rows[rowindex].Cells[3].Value = item.Job;
                    dgv_PhoneList.Rows[rowindex].Cells[4].Value = item.Phone_Num;
                    dgv_PhoneList.Rows[rowindex].Cells[5].Value = item.id;


                    rowindex++;
                }
                txt_Count.Text = dgv_PhoneList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void dgvSearchByBranch()
        {
            try
            {
                dgv_PhoneList.Rows.Clear();
                var result = contact.SearchByBranch(int.Parse(cbx_BranchSearch.SelectedValue.ToString()));
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_PhoneList.Rows.Add(1);
                    dgv_PhoneList.Rows[rowindex].Cells[0].Value = item.branch_id.ToString();
                    dgv_PhoneList.Rows[rowindex].Cells[1].Value = item.sys_branch.name;
                    dgv_PhoneList.Rows[rowindex].Cells[2].Value = item.Emp_Name;
                    dgv_PhoneList.Rows[rowindex].Cells[3].Value = item.Job;
                    dgv_PhoneList.Rows[rowindex].Cells[4].Value = item.Phone_Num;
                    dgv_PhoneList.Rows[rowindex].Cells[5].Value = item.id;


                    rowindex++;
                }
                txt_Count.Text = dgv_PhoneList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void cbxBranchListFill()
        {
            cbx_BranchList.DataSource = branch.List();
            cbx_BranchList.ValueMember = "branch_id";
            cbx_BranchList.DisplayMember = "name";
            cbx_BranchList.SelectedIndex = -1;

            cbx_BranchSearch.DataSource = branch.List();
            cbx_BranchSearch.ValueMember = "branch_id";
            cbx_BranchSearch.DisplayMember = "name";
            cbx_BranchSearch.SelectedIndex = -1;
        }

        public usr_Contact_Branches()
        {
            InitializeComponent();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txt_EmpName.Text) || cbx_jobList.SelectedItem != null || !string.IsNullOrEmpty(txt_Phone.Text) || cbx_BranchList.SelectedItem != null)
            {
                int id = currentID;
                string EmpName = txt_EmpName.Text;
                string job = cbx_jobList.SelectedItem.ToString();
                string phone = txt_Phone.Text;
                int br = int.Parse(cbx_BranchList.SelectedValue.ToString());

                contact.Update(id, br, EmpName, job, phone);
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_EmpName.Text) || cbx_jobList.SelectedItem != null || !string.IsNullOrEmpty(txt_Phone.Text) || cbx_BranchList.SelectedItem != null)
            {
                string EmpName = txt_EmpName.Text;
                string job = cbx_jobList.SelectedItem.ToString();
                string phone = txt_Phone.Text;
                int br = int.Parse(cbx_BranchList.SelectedValue.ToString());

                contact.Create(br, EmpName, job, phone);
                MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();

            }
            else
            {
                MessageBox.Show("يرجى إكمال البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cbx_BranchSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSearchByBranch();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_EmpName.ReadOnly = false;
            cbx_jobList.Enabled = true;
            txt_Phone.ReadOnly = false;
            cbx_BranchList.Enabled = true;
            btn_New.Enabled = false;
            btn_Save.Visible = true;               

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            refresh();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_EmpName.ReadOnly = false;
            cbx_jobList.Enabled = true;
            txt_Phone.ReadOnly = false;
            btn_New.Enabled = false;
            btn_Save_Edit.Visible = true;
            btn_Delete.Enabled = true;
            cbx_BranchList.Enabled = true;
            int id = currentID;
            var result = contact.findByID(id);

            foreach (var item in result)
            {
                txt_EmpName.Text = item.Emp_Name;
                cbx_BranchList.SelectedValue = item.branch_id;
                cbx_jobList.SelectedItem = item.Job;
                txt_Phone.Text = item.Phone_Num;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void usr_Contact_Branches_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_PhoneList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_PhoneList.CurrentRow.Cells[5].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null, null);
        }
    }
}

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

    public partial class usr_Phone : UserControl
    {
        cls_Branch branch = new cls_Branch();
        cls_Phone phone = new cls_Phone();
        cls_TransActions trans = new cls_TransActions();
        int currentID;

        void perrmisson()
        {
            btn_Delete.Visible = Properties.Settings.Default.phoneDeletebtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.phoneEditbtn;
            btn_Save.Enabled = Properties.Settings.Default.phoneNewbtn;
        }

        void refresh()
        {
            cbx_Branch.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_New.Enabled = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_LandLine.ReadOnly = true;
            txt_SimCard.ReadOnly = true;
            txt_SimCard.Clear();
            txt_LandLine.Clear();
            txt_Search.Clear();
            txt_Serial.ReadOnly = true;
            txt_Serial.Clear();
            txt_Note.ReadOnly = true;
            txt_Note.Clear();
            txt_Quota.ReadOnly = true;
            txt_Quota.Clear();
            cbx_Branch.Enabled = false;
            cbxBranchFill();
            dgvfill();
            dgv_PhoneList.ClearSelection();
            txt_Search.Focus();
            perrmisson();
        }

        void cbxBranchFill()
        {
            cbx_Branch.DataSource = branch.List();
            cbx_Branch.ValueMember = "branch_id";
            cbx_Branch.DisplayMember = "Name";
            cbx_Branch.SelectedIndex = -1;

            cbx_Search.DataSource = branch.List();
            cbx_Search.ValueMember = "branch_id";
            cbx_Search.DisplayMember = "name";
            cbx_Search.SelectedIndex = -1;
        }

        void dgvfill()
        {
            try
            {
                dgv_PhoneList.Rows.Clear();
                var result = phone.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_PhoneList.Rows.Add(1);
                    dgv_PhoneList.Rows[rowindex].Cells[0].Value = item.phone_id.ToString();
                    dgv_PhoneList.Rows[rowindex].Cells[1].Value = item.sys_branch.name;
                    dgv_PhoneList.Rows[rowindex].Cells[2].Value = item.LandLine;
                    dgv_PhoneList.Rows[rowindex].Cells[3].Value = item.simcard;
                    dgv_PhoneList.Rows[rowindex].Cells[4].Value = item.Quota;
                    dgv_PhoneList.Rows[rowindex].Cells[5].Value = item.note;

                    rowindex++;
                }
                txt_Count.Text = dgv_PhoneList.Rows.Count.ToString();
            }
            catch { return; }
        }

        void dgvSearchByPhone()
        {
            try
            {
                dgv_PhoneList.Rows.Clear();
                var result = phone.SearchByPhone(txt_Search.Text);
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_PhoneList.Rows.Add(1);
                    dgv_PhoneList.Rows[rowindex].Cells[0].Value = item.phone_id.ToString();
                    dgv_PhoneList.Rows[rowindex].Cells[1].Value = item.sys_branch.name;
                    dgv_PhoneList.Rows[rowindex].Cells[2].Value = item.LandLine;
                    dgv_PhoneList.Rows[rowindex].Cells[3].Value = item.simcard;
                    dgv_PhoneList.Rows[rowindex].Cells[4].Value = item.Quota;
                    dgv_PhoneList.Rows[rowindex].Cells[5].Value = item.note;

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
                var result = phone.SearchByBranch(int.Parse(cbx_Search.SelectedValue.ToString()));
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_PhoneList.Rows.Add(1);
                    dgv_PhoneList.Rows[rowindex].Cells[0].Value = item.phone_id.ToString();
                    dgv_PhoneList.Rows[rowindex].Cells[1].Value = item.sys_branch.name;
                    dgv_PhoneList.Rows[rowindex].Cells[2].Value = item.LandLine;
                    dgv_PhoneList.Rows[rowindex].Cells[3].Value = item.simcard;
                    dgv_PhoneList.Rows[rowindex].Cells[4].Value = item.Quota;
                    dgv_PhoneList.Rows[rowindex].Cells[5].Value = item.note;

                    rowindex++;
                }
                txt_Count.Text = dgv_PhoneList.Rows.Count.ToString();
            }
            catch { return; }
        }

        public usr_Phone()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_LandLine.ReadOnly = false;
            txt_SimCard.ReadOnly = false;
            txt_Serial.ReadOnly = false;
            txt_Note.ReadOnly = false;
            txt_Quota.ReadOnly = false;
            cbx_Branch.Enabled = true;
            btn_Save_Edit.Visible = true;
            btn_Delete.Enabled = true;
            
            int id = int.Parse(dgv_PhoneList.CurrentRow.Cells[0].Value.ToString());
            var result = phone.findByID(id);

            foreach (var item in result)
            {
                txt_LandLine.Text = item.LandLine.ToString();
                txt_SimCard.Text = item.simcard;
                txt_Serial.Text = item.simCardSerial;
                txt_Quota.Text = item.Quota;
                txt_Note.Text = item.note;
                cbx_Branch.SelectedValue = item.branch_id;

            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            btn_Save.Visible = true;
            txt_LandLine.ReadOnly = false;
            txt_SimCard.ReadOnly = false;
            txt_Serial.ReadOnly = false;
            txt_Note.ReadOnly = false;
            txt_Quota.ReadOnly = false;
            cbx_Branch.Enabled = true;
            txt_LandLine.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                phone.Delete(currentID);

                refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgv_BranchList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentID = int.Parse(dgv_PhoneList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Quota.Text) && !string.IsNullOrWhiteSpace(txt_LandLine.Text) && !string.IsNullOrWhiteSpace(txt_Serial.Text) && !string.IsNullOrWhiteSpace(txt_SimCard.Text) && cbx_Branch.SelectedItem != null)
            {
                phone.Update(currentID, txt_SimCard.Text, txt_Serial.Text, txt_LandLine.Text, txt_Quota.Text, txt_Note.Text, int.Parse(cbx_Branch.SelectedValue.ToString()));


                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Quota.Text) && !string.IsNullOrWhiteSpace(txt_LandLine.Text) && !string.IsNullOrWhiteSpace(txt_Serial.Text) && !string.IsNullOrWhiteSpace(txt_SimCard.Text) && cbx_Branch.SelectedItem != null)
            {
                int id = phone.FirstID();
                phone.Create(id, txt_SimCard.Text, txt_Serial.Text, txt_LandLine.Text, txt_Quota.Text, txt_Note.Text, int.Parse(cbx_Branch.SelectedValue.ToString()));

                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usr_Phone_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                dgvSearchByPhone();
                cbx_Search.SelectedIndex = -1;
            }
            else
            {
                refresh();
            }
        }

        private void cbx_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSearchByBranch();
            txt_Search.Clear();
        }

        private void btn_SearchReset_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            Report.frm_Phone_rpt frm = new Report.frm_Phone_rpt();
            frm.ShowDialog();
        }
    }
}

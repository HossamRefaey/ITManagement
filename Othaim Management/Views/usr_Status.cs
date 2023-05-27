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
    public partial class usr_Status : UserControl
    {
        cls_Status stat = new cls_Status();
        public int currentID;
        void dgvFill()
        {
            dgv_StatusList.Rows.Clear();
            var result = stat.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_StatusList.Rows.Add(1);
                dgv_StatusList.Rows[rowindex].Cells[0].Value = item.status_id.ToString();
                dgv_StatusList.Rows[rowindex].Cells[1].Value = item.status;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_StatusList.Rows.Count.ToString();
            dgv_StatusList.ClearSelection();
        }

        void Search()
        {
            dgv_StatusList.Rows.Clear();
            var result = stat.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_StatusList.Rows.Add(1);
                dgv_StatusList.Rows[rowindex].Cells[0].Value = item.status_id.ToString();
                dgv_StatusList.Rows[rowindex].Cells[1].Value = item.status;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_StatusList.Rows.Count.ToString();
        }

        void refresh()
        {
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            dgvFill();
            txt_Status.ReadOnly = true;
            txt_Status.Clear();
            txt_Search.Clear();
            
        }

        public usr_Status()
        {
            InitializeComponent();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Status.Text))
            {
                stat.Update(currentID,txt_Status.Text);
                btn_Save_Edit.Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Status.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Status.Text))
            {
                stat.Create(txt_Status.Text);
                btn_Save.Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Status.Focus();
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Status.ReadOnly = false;
            txt_Status.Focus();
            btn_Save.Visible = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Status.ReadOnly = false;
            btn_Save_Edit.Visible = true;
            var result = stat.FindByID(currentID);
            foreach (var item in result)
            {
                txt_Status.Text = item.status;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                stat.Delete(currentID);
                refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                Search();
            }
            else
            {
                dgvFill();
            }
        }

        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.statNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.statEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.statDeletebtn;


        }

        private void usr_Status_Load(object sender, EventArgs e)
        {
            permission();
           
            refresh();
        }

        private void dgv_StatusList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgv_StatusList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_StatusList.CurrentRow.Cells[0].Value.ToString());
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Edit_Click(null, null);
        }
    }
}

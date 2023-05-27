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
using Othaim_Management.Report;

namespace Othaim_Management.Views
{
    public partial class usr_DeviceOps : UserControl
    {
        cls_STK_HDR hdr = new cls_STK_HDR();
        cls_Branch branch = new cls_Branch();
        cls_DevModel model = new cls_DevModel();
        int currentID = 0;
        int doctype = 0;

        void dgvfill()
        {
            try
            {
                dgv_DevOpsList.Rows.Clear();
                var result = hdr.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_DevOpsList.Rows.Add(1);
                    dgv_DevOpsList.Rows[rowindex].Cells[0].Value = item.HDR_ID.ToString();
                    dgv_DevOpsList.Rows[rowindex].Cells[1].Value = item.from_Site_Num+" "+item.from_Site_Name;
                    dgv_DevOpsList.Rows[rowindex].Cells[2].Value = item.to_Site_Num + " " + item.to_Site_Name;
                    dgv_DevOpsList.Rows[rowindex].Cells[3].Value = item.sys_doc_type.doc_type;
                    dgv_DevOpsList.Rows[rowindex].Cells[4].Value = item.userName;
                    dgv_DevOpsList.Rows[rowindex].Cells[5].Value = Convert.ToDateTime(item.date).ToShortDateString();
                    dgv_DevOpsList.Rows[rowindex].Cells[6].Value = item.doc_type_id;


                    rowindex++;
                }
                txt_Count.Text = dgv_DevOpsList.Rows.Count.ToString();
            }
            catch { return; }
        }
        void cbx_BranchFill()
        {
            cbx_ToSite.DataSource = branch.List();
            cbx_ToSite.ValueMember = "branch_id";
            cbx_ToSite.DisplayMember = "Name";
            cbx_ToSite.SelectedIndex = -1;

            cbx_FromSite.DataSource = branch.List();
            cbx_FromSite.ValueMember = "branch_id";
            cbx_FromSite.DisplayMember = "Name";
            cbx_FromSite.SelectedIndex = -1;
        }

        void cbx_DevModelSearch()
        {
            cbx_SearchModel.DataSource = model.List();
            cbx_SearchModel.ValueMember = "model_id";
            cbx_SearchModel.DisplayMember = "Name";
            cbx_SearchModel.SelectedIndex = -1;
        }

        void refresh()
        {
            btn_Printer.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Delete.Visible = Properties.Settings.Default.transReportDeletebtn;
            rbtn_Current.Checked = true;
            cbx_BranchFill();
            cbx_DevModelSearch();
            dgvfill();
        }

        public usr_DeviceOps()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void usr_DeviceOps_Load(object sender, EventArgs e)
        {
            refresh();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            hdr.Delete(currentID);
            refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (rbtn_Current.Checked == true)
            {
                Properties.Settings.Default.rptCheck = 0;
                Properties.Settings.Default.id = currentID;
                Properties.Settings.Default.Save();
                if (doctype == 2)
                {
                    frm_Dispose_rpt frm = new frm_Dispose_rpt();
                    frm.ShowDialog();
                }
                else if (doctype == 3)
                {
                    frm_Receipt_rpt frm = new frm_Receipt_rpt();
                    frm.ShowDialog();
                }
            }
            else if (rbtn_All.Checked == true)
            {
               //---------------------

            }
            else if (rbtn_Date.Checked == true)
            {
               //---------------------

            }


        }

       

        private void dgv_DevOpsList_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgv_DevOpsList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Printer.Enabled = true;
            btn_Delete.Enabled = true;
            currentID = int.Parse(dgv_DevOpsList.CurrentRow.Cells[0].Value.ToString());
            doctype = int.Parse(dgv_DevOpsList.CurrentRow.Cells[6].Value.ToString());

        }

        private void rbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_All.Checked == true)
            {
                btn_Printer.Enabled = true;
            }
            else
            {
                btn_Printer.Enabled = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbx_FromSite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

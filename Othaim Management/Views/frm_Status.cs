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
    public partial class frm_Status : DevExpress.XtraEditors.XtraForm
    {
        cls_Status stat = new cls_Status();

        void dgvFill()
        {
            dgv_StatusList.Rows.Clear();
            var result = stat.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_StatusList.Rows.Add(1);
                dgv_StatusList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_StatusList.Rows[rowindex].Cells[1].Value = item.status;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_StatusList.Rows.Count.ToString();
        }
        public frm_Status()
        {
            InitializeComponent();
        }

        private void frm_Status_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void dgv_StatusList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_StatusList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Status_Edit frm = new frm_Status_Edit();
            frm.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_StatusList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Status_Edit frm = new frm_Status_Edit();
            frm.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_StatusList.Rows.Count >= 1)
            {


                if (MessageBox.Show("تأكيد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_StatusList.CurrentRow.Cells[0].Value.ToString());
                    stat.Delete(id);
                    dgvFill();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد شئ للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Status_New frm = new frm_Status_New();
            frm.ShowDialog();
        }
    }
}
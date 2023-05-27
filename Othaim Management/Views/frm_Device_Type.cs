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
    public partial class frm_Device_Type : DevExpress.XtraEditors.XtraForm
    {
        cls_DevType type = new cls_DevType();
        void dgvfill()
        {

            dgv_DevTypeList.Rows.Clear();
            var result = type.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                
                dgv_DevTypeList.Rows.Add(1);
                dgv_DevTypeList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_DevTypeList.Rows[rowindex].Cells[1].Value = item.dev_type;
                dgv_DevTypeList.Rows[rowindex].Cells[2].Value = item.sys_Category.Name;
                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_DevTypeList.Rows.Count.ToString();
        }

        public frm_Device_Type()
        {
            InitializeComponent();
        }

        private void frm_Device_Type_Load(object sender, EventArgs e)
        {
            dgvfill();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvfill();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                type.Delete(int.Parse(dgv_DevTypeList.CurrentRow.Cells[0].Value.ToString()));
                frm_Device_Type_Load(null,null);
            }
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_DevTypeList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Device_Type_Edit frm = new frm_Device_Type_Edit();
            frm.ShowDialog();
        }

        private void dgv_DevTypeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_DevTypeList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Device_Type_Edit frm = new frm_Device_Type_Edit();
            frm.ShowDialog();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Device_Type_New frm = new frm_Device_Type_New();
            frm.ShowDialog();
        }
    }
}
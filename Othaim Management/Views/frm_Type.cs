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
    public partial class frm_Type : DevExpress.XtraEditors.XtraForm
    {
        cls_Type type = new cls_Type();

        void dgvFill()
        {
            dgv_TypeList.Rows.Clear();
            var result = type.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_TypeList.Rows.Add(1);
                dgv_TypeList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_TypeList.Rows[rowindex].Cells[1].Value = item.name;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_TypeList.Rows.Count.ToString();
        }

        public frm_Type()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Type_New frm = new frm_Type_New();
            frm.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_TypeList.Rows.Count >= 1)
            {


                Properties.Settings.Default.id = int.Parse(dgv_TypeList.CurrentRow.Cells[0].Value.ToString());
                Properties.Settings.Default.Save();
                frm_Type_Edit frm = new frm_Type_Edit();
                frm.ShowDialog();
            }
            else
            {
                    MessageBox.Show("لا يوجد شئ للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dgv_TypeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_TypeList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Type_Edit frm = new frm_Type_Edit();
            frm.ShowDialog();
        }

        private void frm_Type_Load(object sender, EventArgs e)
        {
            dgvFill();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dgv_TypeList.Rows.Count >= 1)
            {
                if (MessageBox.Show("تأكيد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_TypeList.CurrentRow.Cells[0].Value.ToString());
                    type.Delete(id);
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
    }
}
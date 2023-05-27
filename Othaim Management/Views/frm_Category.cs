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
    public partial class frm_Category : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();

        void dgvfill()
        {
            dgv_CategoryList.Rows.Clear();
            var result = cat.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_CategoryList.Rows.Add(1);
                dgv_CategoryList.Rows[rowindex].Cells[0].Value = item.ID.ToString();
                dgv_CategoryList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_CategoryList.Rows[rowindex].Cells[2].Value = item.shrt_id;


                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_CategoryList.Rows.Count.ToString();
        }
        public frm_Category()
        {
            InitializeComponent();
        }

        private void frmCat_Load(object sender, EventArgs e)
        {
             dgvfill();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Category_New frm = new frm_Category_New();
            frm.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Category_Edit frm = new frm_Category_Edit();
            frm.ShowDialog();
        }

        private void dgv_CategoryList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Category_Edit frm = new frm_Category_Edit();
            frm.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvfill();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("تأكيد الحذف","حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                cat.Delete(int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString()));
                dgvfill();
            }
        }
    }
}
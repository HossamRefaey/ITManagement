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
    public partial class frm_Device_Model : DevExpress.XtraEditors.XtraForm
    {
        cls_DevModel model = new cls_DevModel();
        cls_DevType type = new cls_DevType();
        cls_Category cat = new cls_Category();


        void dgvfill()
        {
            try
            {


                dgv_DevModelList.Rows.Clear();
                var result = model.List();

                int rowindex = 0;

                foreach (var item in result)
                {
                    dgv_DevModelList.Rows.Add(1);
                    dgv_DevModelList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                    dgv_DevModelList.Rows[rowindex].Cells[1].Value = item.Name;
                    if (item.Item_Code == null)
                    {
                        dgv_DevModelList.Rows[rowindex].Cells[2].Value = "";
                    }
                    else
                    {
                        dgv_DevModelList.Rows[rowindex].Cells[2].Value = item.Item_Code;

                    }
                    dgv_DevModelList.Rows[rowindex].Cells[3].Value = item.sys_dev_type.dev_type;

                    rowindex++;
                }
                label1.Text = "عدد السجلات : " + dgv_DevModelList.Rows.Count.ToString();

            }
            catch (Exception)
            {
                return;
            }

        }

        void refresh()
        {
            dgvfill();
        }


        public frm_Device_Model()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Device_Model_New frm = new frm_Device_Model_New();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_DevModelList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Device_Model_Edit frm = new frm_Device_Model_Edit();
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgv_DevModelList.Rows.Count >= 1)
            {
                if (MessageBox.Show("تأكيد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_DevModelList.CurrentRow.Cells[0].Value.ToString());
                    model.Delete(id);
                    dgvfill();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد شئ للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void frm_Device_Model_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgv_DevModelList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.Settings.Default.id = int.Parse(dgv_DevModelList.CurrentRow.Cells[0].Value.ToString());
            Properties.Settings.Default.Save();
            frm_Device_Model_Edit frm = new frm_Device_Model_Edit();
            frm.ShowDialog();
        }
    }
}
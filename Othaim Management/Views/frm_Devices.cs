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
    public partial class frm_Devices : DevExpress.XtraEditors.XtraForm
    {
        cls_Devices dev = new cls_Devices();
        void dgvfill()
        {
            dgv_DevicesList.Rows.Clear();
            var result = dev.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                try
                {
                    dgv_DevicesList.Rows.Add(1);
                    dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                    dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                    dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                    dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                    dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                    dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                    if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                    {
                        dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                    }
                    else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                    
                }
                catch {  }
                




                rowindex++;
            }
            txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
        }
        public frm_Devices()
        {
            InitializeComponent();
        }

        private void frm_Devices_Load(object sender, EventArgs e)
        {
            dgvfill();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_Devices_New frm = new frm_Devices_New();
            frm.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            frm_Devices_Load(null, null);
        }
    }
}
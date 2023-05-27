using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class frm_DevList : Form
    {
        cls_Devices dev = new cls_Devices();

        void dgvFill()
        {

            dgv_DevicesList.Rows.Clear();
            var result = dev.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_DevicesList.Rows.Add(1);
                dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.SN;
                dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_status.status;
                dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_Type.name;




                rowindex++;
            }
        }

        public frm_DevList()
        {
            InitializeComponent();
        }

        private void frm_DevList_Load(object sender, EventArgs e)
        {
            try
            {
                dgvFill();
            }
            catch (Exception) { return; }
        }
    }
}

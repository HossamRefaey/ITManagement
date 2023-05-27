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
    public partial class usr_DeviceCycle : UserControl
    {

        cls_deviceCycle devcycle = new cls_deviceCycle();

        void refresh()
        {
            txt_Search.Focus();
            txt_Search.Clear();
        }
        void SearchBySerial()
        {

            dgv_DevicesList.Rows.Clear();
            var result = devcycle.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                try
                {
                    dgv_DevicesList.Rows.Add(1);
                    dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.device_id.ToString();
                    dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.sys_devices.Name;
                    //dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.
                    if (item.HDR_ID != null)
                    {
                        dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.HDR_ID.ToString();
                    }
                    else
                    {
                        dgv_DevicesList.Rows[rowindex].Cells[3].Value = "";

                    }
                    if (item.DocType_ID != null)
                    {
                        dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_doc_type.doc_type;
                    }
                    else
                    {
                        dgv_DevicesList.Rows[rowindex].Cells[4].Value = "";

                    }
                    dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.To_SIte;

                    dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.date).ToShortDateString();

                    dgv_DevicesList.ClearSelection();

                }
                catch(Exception ex) { MessageBox.Show(ex.Message); return; }

                rowindex++;
            }
            txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();

        }

        public usr_DeviceCycle()
        {
            InitializeComponent();
        }

        private void usr_DeviceCycle_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                SearchBySerial();
            }
            else
            {
                refresh();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }       
}

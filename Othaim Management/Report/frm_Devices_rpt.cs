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

namespace Othaim_Management.Report
{
    public partial class frm_Devices_rpt : DevExpress.XtraEditors.XtraForm
    {
        public frm_Devices_rpt()
        {
            InitializeComponent();
        }



        DataSet Ds = new DataSet();
        DataTable dt = new ds_Devices.DevicesDataTable();
        cls_Devices dev = new cls_Devices();

        void Report()
        {


            try
            {

                var result = dev.FindByBranch(Properties.Settings.Default.id).ToList();
                foreach (var item in result)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item.Device_id;
                    row[1] = item.SN;
                    row[2] = item.sys_dev_model.Name;
                    row[3] = item.sys_dev_type.dev_type;
                    row[4] = item.sys_Category.Name;
                    row[5] = item.sys_status.status;
                    row[6] = item.Notes;
                   



                    dt.Rows.Add(row);
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Ds.Tables.Add(dt);
            DevicesBindingSource.DataSource = Ds;

           


        }


       

        private void frm_Dispose_rpt_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Devices_Load(object sender, EventArgs e)
        {
            Report();
            this.reportViewer1.RefreshReport();

          
        }
    }
}
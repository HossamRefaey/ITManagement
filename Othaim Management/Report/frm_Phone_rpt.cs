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
    public partial class frm_Phone_rpt : DevExpress.XtraEditors.XtraForm
    {
        cls_Phone phone = new cls_Phone();


        DataSet Ds = new DataSet();
        DataTable dt = new ds_Phone.phoneDataTable();


        void Report()
        {


            try
            {

                var result = phone.List();
                foreach (var item in result)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item.phone_id;
                    row[1] = item.simcard;
                    row[2] = item.simCardSerial;
                    row[3] = item.LandLine;
                    row[4] = item.sys_branch.name;
                    row[5] = item.note;
                    row[6] = item.Quota;
                    
                    dt.Rows.Add(row);
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Ds.Tables.Add(dt);


            phoneBindingSource.DataSource = Ds;


        }
        public frm_Phone_rpt()
        {
            InitializeComponent();
        }

        private void frm_Phone_rpt_Load(object sender, EventArgs e)
        {
            Report();
            this.reportViewer1.RefreshReport();
        }

        private void phoneBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
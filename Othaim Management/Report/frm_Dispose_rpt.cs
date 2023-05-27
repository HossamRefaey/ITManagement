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

namespace Othaim_Management.Report
{
    public partial class frm_Dispose_rpt : DevExpress.XtraEditors.XtraForm
    {

        Othaim_Management.Model.OthaimITEntities db = new Model.OthaimITEntities();


        DataSet Ds = new DataSet();
        DataTable dt = new ds_Dispose.DisposeDataTable();
       

        void Report()
        {

           
            try
            {

                var result = db.Dispose(Properties.Settings.Default.id).ToList();
                foreach (var item in result)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item.HDR_ID;
                    row[1] = item.from_Site_Num;
                    row[2] = item.to_Site_Num;
                    row[3] = item.userName;
                    row[4] = item.userCode;
                    row[5] = item.Emp_Name;
                    row[6] = item.Emp_Code;
                    row[7] = item.doc_type;
                    row[8] = item.date;
                    row[9] = item.model_Name;
                    row[10] = item.item_Code;
                    row[11] = item.device_SN;
                    row[12] = item.note;
                    row[13] = item.from_Site_Name;
                    row[14] = item.to_Site_Name;



                    dt.Rows.Add(row);
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Ds.Tables.Add(dt);


            DisposeBindingSource.DataSource = Ds;

            
        }
            

        public frm_Dispose_rpt()
        {
            InitializeComponent();
        }

        private void frm_Dispose_rpt_Load(object sender, EventArgs e)
        {
            Report();
            this.reportViewer1.RefreshReport();
        }
    }
}
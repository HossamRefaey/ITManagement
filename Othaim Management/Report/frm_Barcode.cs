using DevExpress.DocumentServices.ServiceModel.DataContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othaim_Management.Report
{
    public partial class frm_Barcode : Form
    {
        public frm_Barcode()
        {
            InitializeComponent();
        }

        private void frm_Barcode_Load(object sender, EventArgs e)
        {
            //string path = Application.StartupPath + @"\Picture1.png";
            //ReportParameter param = new ReportParameter("pNa", path);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { parameter });
            //this.reportViewer1.RefreshReport();
        }
    }
}

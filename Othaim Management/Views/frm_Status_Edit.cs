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
    public partial class frm_Status_Edit : DevExpress.XtraEditors.XtraForm
    {
        cls_Status stat = new cls_Status();
        public frm_Status_Edit()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int id = Properties.Settings.Default.id;
            stat.Update(id,txt_Name.Text);
            Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Status_Edit_Load(object sender, EventArgs e)
        {
            int id = Properties.Settings.Default.id;
            var result = stat.FindByID(id);
            foreach (var item in result)
            {
                txt_Name.Text = item.status;
            }
        }
    }
}
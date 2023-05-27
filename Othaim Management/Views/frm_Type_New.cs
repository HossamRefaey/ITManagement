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
    public partial class frm_Type_New : DevExpress.XtraEditors.XtraForm
    {
        cls_Type type = new cls_Type();

        public frm_Type_New()
        {
            InitializeComponent();
        }

        private void frm_Type_New_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            type.Create(txt_Name.Text);
            txt_Name.Clear();
            txt_Name.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
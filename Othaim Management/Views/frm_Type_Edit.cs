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
    public partial class frm_Type_Edit : DevExpress.XtraEditors.XtraForm
    {
        cls_Type type = new cls_Type();

        public frm_Type_Edit()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int id = Properties.Settings.Default.id;
            type.Update(id, txt_Name.Text);
            Close();
        }

        private void frm_Type_Edit_Load(object sender, EventArgs e)
        {
            int id = Properties.Settings.Default.id;
            var result = type.FindByID(id);
            foreach (var item in result)
            {
                txt_Name.Text = item.name;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
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
    public partial class frm_Devices_New : DevExpress.XtraEditors.XtraForm
    {
        cls_Category cat = new cls_Category();
        cls_DevType devType = new cls_DevType();
        cls_DevModel model = new cls_DevModel();
        cls_Devices dev = new cls_Devices();
        cls_Type type = new cls_Type();
        cls_Status stat = new cls_Status();

        void cbx_CategoryFill()
        {
            //Fill Category ComboBox

            cbx_CategoryList.DataSource = cat.List();
            cbx_CategoryList.ValueMember = "ID";
            cbx_CategoryList.DisplayMember = "Name";
            //cbx_Category.Text = "Select Category";

        }


        void cbx_TypeFill()
        {

            cbx_Type.DataSource = type.List();
            cbx_Type.ValueMember = "id";
            cbx_Type.DisplayMember = "name";

        }

        void cbx_StatFill()
        {

            cbx_Status.DataSource = stat.List();
            cbx_Status.ValueMember = "id";
            cbx_Status.DisplayMember = "status";

        }


        void refresh()
        {
            cbx_TypeFill();
            cbx_StatFill();
            cbx_CategoryFill();
            

        }

        void resetData()
        {
            txt_Name.Clear();
            txt_SN.Clear();
            txt_Notes.Clear();
            txt_Name.Focus();
        }

        public frm_Devices_New()
        {
            InitializeComponent();
        }

        private void frm_Devices_New_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbx_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbx_CategoryList.SelectedValue.ToString());

                var result = devType.findByCatID(id);
                if (result.Count <= 0)
                {
                    cbx_DevType.DataSource = null;
                }
                else
                {
                    cbx_DevType.DataSource = result;
                    cbx_DevType.ValueMember = "id";
                    cbx_DevType.DisplayMember = "dev_type";
                }


            }
            catch (Exception) { return; }

            
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cbx_DevType.SelectedValue.ToString());

                var result = model.findByTypeID(id);
                if (result.Count <= 0)
                {
                    cbx_DevModel.DataSource = null;
                }
                else
                {
                    cbx_DevModel.DataSource = result;
                    cbx_DevModel.ValueMember = "id";
                    cbx_DevModel.DisplayMember = "Name";
                }


            }
            catch (Exception) { return; }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //dev.Create(txt_Name.Text,txt_SN.Text,int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()), 
            //    int.Parse(cbx_CategoryList.SelectedValue.ToString()), int.Parse(cbx_Type.SelectedValue.ToString())
            //    , int.Parse(cbx_Status.SelectedValue.ToString()),Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd")),txt_Notes.Text);
            //resetData();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
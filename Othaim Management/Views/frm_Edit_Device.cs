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
    public partial class frm_Edit_Device : Form
    {
        Model.JobDBEntities db = new Model.JobDBEntities();
        cls_Devices dev = new cls_Devices();

        void cbx_Model()
        {
            cbx_DevModel.DataSource = db.sys_dev_model.ToList();
            cbx_DevModel.ValueMember = "id";
            cbx_DevModel.DisplayMember = "Name";
        }

        void cbx_Type()
        {
            cbx_DevType.DataSource = db.sys_dev_type.ToList();
            cbx_DevType.ValueMember = "id";
            cbx_DevType.DisplayMember = "dev_Type";
            cbx_DevType.SelectedIndex = -1;
        }

        void cbx_Catigory()
        {
            cbx_Category.DataSource = db.sys_Category.ToList();
            cbx_Category.ValueMember = "id";
            cbx_Category.DisplayMember = "Name";
            cbx_Category.SelectedIndex = -1;
        }
        void Show()
        {
            cbx_Type();
            cbx_Catigory();
            cbx_Model();

            int id = Properties.Settings.Default.id;
            var result = dev.SelectItem(id);
            foreach (var item in result)
            {
                txt_Item_ID.Text = item.id.ToString();
                txt_Item_Serial.Text = item.SN;
                txt_Notes.Text = item.Notes;
                cbx_Status.SelectedItem = item.sys_status.status;
                cbx_Item_Type.SelectedItem = item.sys_Type.name;
                cbx_DevModel.SelectedValue = item.model_id;
            }
        }
        public frm_Edit_Device()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Edit_Device_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void cbx_DevModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dev.Update(int.Parse(txt_Item_ID.Text), txt_Item_Serial.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_Item_Type.SelectedValue.ToString()), int.Parse(cbx_Status.SelectedValue.ToString()), txt_Notes.Text);
            MessageBox.Show("تم التعديل بنجاح");
        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.JobDBEntities db = new Model.JobDBEntities();

            try
            {
                cbx_DevType.DataSource = null;
                var query = from category in db.sys_Category
                            select new
                            {
                                categoryID = category.ID,
                                categoryName = category.Name
                            };

                foreach (var result in query)
                {
                    if (result == null)
                    {
                        cbx_DevType.Text = "none";
                    }
                    else
                    {
                        int cbxid = int.Parse(cbx_Category.SelectedValue.ToString());
                        cbx_DevType.DataSource = db.sys_dev_type.Where(w => w.Category_ID == cbxid).ToList();
                        cbx_DevType.ValueMember = "ID";
                        cbx_DevType.DisplayMember = "Dev_Type";
                    }
                }
            }
            catch (Exception) { return; }
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill DevModel ComboBox From DevType

            try
            {
                cbx_DevModel.DataSource = null;

                var query = from devtype in db.sys_dev_type
                            select new
                            {
                                devtypeid = devtype.id,
                                devtypeName = devtype.dev_type
                            };

                foreach (var result in query)
                {
                    int cbxid = int.Parse(cbx_DevType.SelectedValue.ToString());
                    var x = db.sys_dev_model.Where(w => w.devType_ID == cbxid).ToList();
                    cbx_DevModel.DataSource = x;
                    cbx_DevModel.ValueMember = "id";
                    cbx_DevModel.DisplayMember = "Name";
                }

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}

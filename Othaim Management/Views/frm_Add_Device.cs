using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Model;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class frm_Add_Device : Form
    {
        //OthaimITEntities db = new OthaimITEntities();
        //cls_Devices Dev = new cls_Devices();
        //void SetDefault()
        //{
        //    txt_Notes.Clear();
        //    txt_Serial.Clear();
        //    txt_Serial.Select();

        //    txt_Item_ID.Text = Dev.FirstID().ToString();
        //}

        void cbx_CategoryFill()
        {
            ////Fill Category ComboBox

            //cbx_Category.DataSource = db.sys_Category.ToList();
            //cbx_Category.ValueMember = "ID";
            //cbx_Category.DisplayMember = "Name";
            ////cbx_Category.Text = "Select Category";
            //cbx_Category.SelectedIndex = -1;

        }

        public frm_Add_Device()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (Dev.ChekSerial(txt_Serial.Text) == "")
            //{
            //    int id = int.Parse(txt_Item_ID.Text);
            //    int model_id = int.Parse(cbx_DevModel.SelectedValue.ToString());
            //    int item_Type = int.Parse(cbx_Item_Type.SelectedIndex.ToString());
            //    int Stat = int.Parse(cbx_Status.SelectedIndex.ToString());
            //    DateTime rec_date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //    Dev.Insert(id, txt_Serial.Text, model_id, item_Type, Stat, rec_date, txt_Notes.Text);

            //    //MessageBox.Show("تم إضافة جهاز جديد بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    SetDefault();
            //}
            //else
            //{
            //    MessageBox.Show(Dev.ChekSerial(txt_Serial.Text));
            //}





        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Fill DevType ComboBox From Category

            //try
            //{
            //    cbx_DevType.DataSource = null;
            //    var query = from category in db.sys_Category
            //                select new
            //                {
            //                    categoryID = category.ID,
            //                    categoryName = category.Name
            //                };

            //    foreach (var result in query)
            //    {
            //        if (result == null)
            //        {
            //            cbx_DevType.Text = "none";
            //        }
            //        else
            //        {
            //            int cbxid = int.Parse(cbx_Category.SelectedValue.ToString());
            //            cbx_DevType.DataSource = db.sys_dev_type.Where(w => w.Category_ID == cbxid).ToList();
            //            cbx_DevType.ValueMember = "ID";
            //            cbx_DevType.DisplayMember = "Dev_Type";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill DevModel ComboBox From DevType

            //try
            //{
            //    cbx_DevModel.DataSource = null;

            //    var query = from devtype in db.sys_dev_type
            //                select new
            //                {
            //                    devtypeid = devtype.id,
            //                    devtypeName = devtype.dev_type
            //                };

            //    foreach (var result in query)
            //    {
            //        int cbxid = int.Parse(cbx_DevType.SelectedValue.ToString());
            //        var x = db.sys_dev_model.Where(w => w.devType_ID == cbxid).ToList();
            //        cbx_DevModel.DataSource = x;
            //        cbx_DevModel.ValueMember = "id";
            //        cbx_DevModel.DisplayMember = "Name";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private void frm_Add_Device_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SetDefault();
            //    cbx_CategoryFill();
            //}
            //catch (Exception) { return; }


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

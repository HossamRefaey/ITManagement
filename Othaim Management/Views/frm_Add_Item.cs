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
    public partial class frm_Add_Item : Form
    {

        cls_Devices Dev = new cls_Devices();
        public frm_Add_Item()
        {
            InitializeComponent();
        }

        void refresh()
        {
            dgvfill();
            txt_Search.Select();
        }

       

        void dgvfill()
        {
            try
            {
                dgv_ItemList.Rows.Clear();
                var result = Dev.List();
                //dgv_ItemList.DataSource = result;
                int rowindex = 0;
                foreach (var item in result)
                {
                    dgv_ItemList.Rows.Add(1);
                    dgv_ItemList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                    dgv_ItemList.Rows[rowindex].Cells[1].Value = item.SN;
                    dgv_ItemList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                    dgv_ItemList.Rows[rowindex].Cells[3].Value = item.sys_status.status;
                    dgv_ItemList.Rows[rowindex].Cells[4].Value = item.sys_Type.name;
                    dgv_ItemList.Rows[rowindex].Cells[5].Value = item.Notes;
                    rowindex++;
                }
                dgv_ItemList.ClearSelection();
            }
            catch (Exception) { return; }
            
        }

        void Search()
        {
            dgv_ItemList.Rows.Clear();
            var result = Dev.Search(txt_Search.Text);
            //dgv_ItemList.DataSource = result;
            int rowindex = 0;
            foreach (var item in result)
            {
                dgv_ItemList.Rows.Add(1);
                dgv_ItemList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_ItemList.Rows[rowindex].Cells[1].Value = item.SN;
                dgv_ItemList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                dgv_ItemList.Rows[rowindex].Cells[3].Value = item.sys_status.status;
                dgv_ItemList.Rows[rowindex].Cells[4].Value = item.sys_Type.name;
                dgv_ItemList.Rows[rowindex].Cells[5].Value = item.Notes;
                rowindex++;
            }
            dgv_ItemList.ClearSelection();
        }


        private void frm_Add_Item_Load(object sender, EventArgs e)
        {
            try
            {
                refresh();

            }
            catch (Exception) { return; }
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //var result = db.sys_devices.SingleOrDefault(d => d.SN == txt_Barcode.Text);
                //if ( result != null)
                //{
                //    MessageBox.Show("الصنف موجود من قبل");
                //    txt_Barcode.SelectAll();
                //}
                //else
                //{
                //    cbx_DevType.Select();
                //}

            }
        }

        //void cbx_DeviceModel()
        //{
        //    cbx_DevModel.DataSource = db.sys_dev_model.ToList();
        //    cbx_DevModel.ValueMember = "id";
        //    cbx_DevModel.DisplayMember = "Name";
        //}

        private void dgv_ItemList_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    txt_Barcode.Text = dgv_ItemList.CurrentRow.Cells[1].Value.ToString();
            //    txt_Descreption.Text = dgv_ItemList.CurrentRow.Cells[2].Value.ToString();

            //    string model = dgv_ItemList.CurrentRow.Cells[3].Value.ToString();
            //    var modelid = db.sys_dev_model.Where(x => x.Name == model).FirstOrDefault();
            //    var devtype = db.sys_dev_type.Where(x => x.id == modelid.devType_ID).FirstOrDefault();
            //    var category = db.sys_Category.Where(x => x.ID == devtype.Category_ID).FirstOrDefault();

            //    cbx_Category.Text = category.Name;
            //    cbx_DevType.Text = devtype.dev_type;
            //    cbx_DevModel.Text = model;
            //    cbx_Status.Text = dgv_ItemList.CurrentRow.Cells[4].Value.ToString();

            //    btn_Insert.Enabled = false;
            //    btn_Edit.Enabled = true;
            //    btn_Delete.Enabled = true;
            //    btn_Cancel.Enabled = true;

            //    txt_Barcode.Enabled = false;
            //    txt_Descreption.Enabled = false;
            //    cbx_Category.Enabled = false;
            //    cbx_DevType.Enabled = false;
            //    cbx_DevModel.Enabled = false;
            //    cbx_Status.Enabled = false;
            //}
            //catch (Exception)
            //{
            //}
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            //clearall();
            //btn_New.Enabled = false;
            //btn_Insert.Enabled = true;
            //btn_Delete.Enabled = false;
            //btn_Cancel.Enabled = true;

            //txt_Barcode.Enabled = true;
            //txt_Descreption.Enabled = true;
            //cbx_Category.Enabled = true;
            //cbx_DevType.Enabled = true;
            //cbx_DevModel.Enabled = true;
            //cbx_Status.Enabled = true;
            //txt_Barcode.Select();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //string Serial = txt_Barcode.Text;
            //if (db.sys_devices.Where(x => x.SN == Serial).Count() <= 0)
            //{
            //    db.sys_devices.Add(new sys_devices
            //    {
            //        SN = txt_Barcode.Text,
            //        model_id = int.Parse(cbx_DevModel.SelectedValue.ToString()),
            //        description = txt_Descreption.Text,
            //        status_id = int.Parse(cbx_Status.SelectedValue.ToString())

            //    });

            //    db.SaveChanges();
            //    MessageBox.Show("تم إضافة الجهاز");
            //    clearall();
            //    frm_Add_Item_Load(null, null);
            //}
            //else
            //{
                
            //    MessageBox.Show("مكرر");
                
            //}

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //txt_Barcode.Enabled = true;
            //txt_Descreption.Enabled = true;
            //cbx_Category.Enabled = true;
            //cbx_DevType.Enabled = true;
            //cbx_DevModel.Enabled = true;
            //cbx_Status.Enabled = true;
            //dgv_ItemList.Enabled = false;
            //btn_New.Enabled = false;
            ////btn_Insert.Enabled = true;

            //if (btn_Edit.Text == "تعديل")
            //{
            //    btn_Edit.Text = "تم";

            //}
            //else if (btn_Edit.Text == "تم")
            //{
            //    int devid = int.Parse(dgv_ItemList.CurrentRow.Cells[0].Value.ToString());
            //    var result = db.sys_devices.Single(x => x.id == devid);
            //    result.SN = txt_Barcode.Text;
            //    result.description = txt_Descreption.Text;
            //    result.model_id = int.Parse(cbx_DevModel.SelectedValue.ToString());
            //    result.status_id = int.Parse(cbx_Status.SelectedValue.ToString());
            //    db.SaveChanges();
            //    MessageBox.Show("تم التعديل بنجاح");
            //    btn_Edit.Text = "تعديل";
            //    dgv_ItemList.Enabled = true;
            //    dgvfill();
            //    frm_Add_Item_Load(null, null);

            //}
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //int itemid = int.Parse(dgv_ItemList.CurrentRow.Cells[0].Value.ToString());
            //if (MessageBox.Show("هل أنت متأكد من حذف الصنف المحدد","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    var result = db.sys_devices.SingleOrDefault(x => x.id == itemid);
            //    db.sys_devices.Remove(result);
            //    db.SaveChanges();
            //    MessageBox.Show("تم الحذف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frm_Add_Item_Load(null, null);
            //}
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //btn_New.Enabled = true;
            //btn_Insert.Enabled = false;
            //btn_Edit.Enabled = false;
            //btn_Delete.Enabled = false;
            //btn_Cancel.Enabled = false;
            //btn_Edit.Text = "تعديل";
            //dgv_ItemList.Enabled = true;
            //frm_Add_Item_Load(null, null);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //dgv_ItemList.Rows.Clear();
            //var result = db.sys_devices.Where(d => d.SN.Contains(txt_Search.Text)).ToList();
            ////dgv_ItemList.DataSource = result;
            //int rowindex = 0;
            //foreach (var item in result)
            //{
            //    dgv_ItemList.Rows.Add(1);
            //    dgv_ItemList.Rows[rowindex].Cells[0].Value = item.id.ToString();
            //    dgv_ItemList.Rows[rowindex].Cells[1].Value = item.SN;
            //    dgv_ItemList.Rows[rowindex].Cells[2].Value = item.description;
            //    dgv_ItemList.Rows[rowindex].Cells[3].Value = item.sys_dev_model.Name;
            //    dgv_ItemList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
            //    rowindex++;
            //}
        }

        private void cbx_Category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
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

        private void cbx_DevType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
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

        private void btn_New_Click_1(object sender, EventArgs e)
        {
            frm_Add_Device frm = new frm_Add_Device();
            frm.ShowDialog();
        }

        //private void dgv_ItemList_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    Properties.Settings.Default.id = int.Parse(dgv_ItemList.CurrentRow.Cells[0].Value.ToString());
        //    Properties.Settings.Default.Save();
        //    frm_Edit_Device frm = new frm_Edit_Device();
        //    frm.ShowDialog();
        //}

        //private void btn_Edit_Click_1(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.id = int.Parse(dgv_ItemList.CurrentRow.Cells[0].Value.ToString());
        //    Properties.Settings.Default.Save();
        //    frm_Edit_Device frm = new frm_Edit_Device();
        //    frm.ShowDialog();
        //}

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            frm_Add_Item_Load(null,null);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Search.Text))
            {
                Search();
            }
            else { dgvfill(); }
        }
    }
}

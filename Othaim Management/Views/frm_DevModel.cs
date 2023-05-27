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
using Othaim_Management.Model;
using System.Data.SqlClient;

namespace Othaim_Management.Views
{
    public partial class frm_DevModel : Form
    {
        JobDBEntities db = new JobDBEntities();
        cls_DevModel model = new cls_DevModel();
        cls_DevType type = new cls_DevType();
        cls_Category cat = new cls_Category();

        public frm_DevModel()
        {
            InitializeComponent();
        }

        void cbx_DevTypeFill()
        {
            cbx_DevType.DataSource = type.List();

            cbx_DevType.ValueMember = "ID";
            cbx_DevType.DisplayMember = "dev_type";

        }

        void cbx_CategoryFill()
        {
            cbx_Category.DataSource = cat.List();

            cbx_Category.ValueMember = "ID";
            cbx_Category.DisplayMember = "Name";
        }

        void dgvfill()
        {
            try
            {


                dgv_DevModelList.Rows.Clear();
                var result = model.List();
                
                int rowindex = 0;

                foreach (var item in result)
                {
                    dgv_DevModelList.Rows.Add(1);
                    dgv_DevModelList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                    dgv_DevModelList.Rows[rowindex].Cells[1].Value = item.Name;
                    if (item.Item_Code == null)
                    {
                        dgv_DevModelList.Rows[rowindex].Cells[2].Value = "";
                    }
                    else
                    {
                        dgv_DevModelList.Rows[rowindex].Cells[2].Value = item.Item_Code;

                    }
                    dgv_DevModelList.Rows[rowindex].Cells[3].Value = item.sys_dev_type.dev_type;

                    rowindex++;
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        void refresh()
        {
            dgvfill();
            cbx_CategoryFill();
            cbx_Category.SelectedIndex = -1;
            txt_ItemName.Text = "";
            txt_ItemSysCode.Text = "";

        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbx_DevType.SelectedValue.ToString());
            model.Insert(txt_ItemName.Text, txt_ItemSysCode.Text, id);
            refresh();
        }

        private void frm_DevModel_Load(object sender, EventArgs e)
        {

            refresh();
        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill DevType ComboBox From Category

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
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_DevModelList.CurrentRow.Cells[0].Value.ToString());

            model.Update(id, txt_ItemName.Text, txt_ItemSysCode.Text, int.Parse(cbx_DevType.SelectedValue.ToString()));
            MessageBox.Show("Done");
            refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_DevModelList.CurrentRow.Cells[0].Value.ToString());
            model.Delete(id);
            MessageBox.Show("Done");
            refresh();
        }

        private void dgv_DevModelList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ItemName.Text = dgv_DevModelList.CurrentRow.Cells[1].Value.ToString();
                string s = txt_ItemSysCode.Text = dgv_DevModelList.CurrentRow.Cells[2].Value.ToString();
                
                txt_ItemSysCode.Text = dgv_DevModelList.CurrentRow.Cells[2].Value.ToString();


            }
            catch (Exception)
            {
                return;            }
        }
    }
}

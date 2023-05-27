using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Controller;
namespace Othaim_Management.Views
{
    public partial class usr_Category : UserControl
    {
        public usr_Category()
        {
            InitializeComponent();
        }
        cls_Category cat = new cls_Category();
        cls_TransActions trans = new cls_TransActions();

        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.catNewbtn;
            btn_Edit_Save.Enabled = Properties.Settings.Default.catEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.catDeletebtn;


        }
        void dgvfill()
        {
            dgv_CategoryList.Rows.Clear();
            var result = cat.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_CategoryList.Rows.Add(1);
                dgv_CategoryList.Rows[rowindex].Cells[0].Value = item.category_ID.ToString();
                dgv_CategoryList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_CategoryList.Rows[rowindex].Cells[2].Value = item.shrt_id;


                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_CategoryList.Rows.Count.ToString();
        }

        void Search()
        {
            dgv_CategoryList.Rows.Clear();
            var result = cat.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_CategoryList.Rows.Add(1);
                dgv_CategoryList.Rows[rowindex].Cells[0].Value = item.category_ID.ToString();
                dgv_CategoryList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_CategoryList.Rows[rowindex].Cells[2].Value = item.shrt_id;


                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_CategoryList.Rows.Count.ToString();
        }

        void refresh()
        {
            txt_Name.Clear();
            txt_ShrtName.Clear();
            btn_Save.Visible = false;
            btn_Edit_Save.Visible = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            txt_Name.ReadOnly = true;
            txt_ShrtName.ReadOnly = true;
            dgvfill();
            dgv_CategoryList.ClearSelection();
            txt_Search.Clear();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            permission();
            txt_Name.ReadOnly = true;
            txt_ShrtName.ReadOnly = true;
            dgvfill();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_ShrtName.Clear();
            txt_Name.Focus();
            btn_Save.Visible = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            txt_Name.ReadOnly = false;
            txt_ShrtName.ReadOnly = false;
            dgv_CategoryList.ClearSelection();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Name.ReadOnly = false;
            txt_ShrtName.ReadOnly = false;
            btn_Edit_Save.Visible = true;
            btn_Delete.Enabled = true;
            int id = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
            var result = cat.findByID(id);

            foreach (var item in result)
            {
                txt_Name.Text = item.Name;
                txt_ShrtName.Text = item.shrt_id;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cat.Delete(currentID);
            refresh();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_ShrtName.Text))
            {
                cat.Insert(txt_Name.Text, txt_ShrtName.Text);
                
                txt_Name.Clear();
                txt_ShrtName.Clear();
                txt_Name.Focus();
                txt_Name.Clear();
                txt_ShrtName.Clear();
                txt_Name.Focus();
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void dgv_CategoryList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_ShrtName.Text))
            {
                int id = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
                cat.Update(id, txt_Name.Text, txt_ShrtName.Text);
                txt_Name.Clear();
                txt_ShrtName.Clear();
                btn_Edit_Save.Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int currentID;

        private void dgv_CategoryList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
            currentID = int.Parse(dgv_CategoryList.CurrentRow.Cells[0].Value.ToString());
            btn_Edit.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                Search();

            }
            else
            {
                dgvfill();
            }
        }
    }
}

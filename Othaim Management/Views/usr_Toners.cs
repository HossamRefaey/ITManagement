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
    public partial class usr_Toners : UserControl
    {
        cls_Toners toner = new cls_Toners();
        int currentID;

        void refresh()
        {
            
            txt_Name.ReadOnly = true;
            txt_Av.ReadOnly = true;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_Name.Clear();
            txt_Av.Clear();
            
            dgvfill();
           
        }

        void dgvfill()
        {
            dgv_TonerList.Rows.Clear();

            
            var result = toner.List();
            int rowindex = 0;
            foreach (var item in result)
            {
                try
                {
                    dgv_TonerList.Rows.Add(1);
                    dgv_TonerList.Rows[rowindex].Cells[0].Value = item.Toner_ID.ToString();
                    dgv_TonerList.Rows[rowindex].Cells[1].Value = item.Toner_Name;
                    dgv_TonerList.Rows[rowindex].Cells[2].Value = item.Print_Avarage.ToString();

                    dgv_TonerList.ClearSelection();

                }
                catch { }
                rowindex++;
            }

           
                
           
            txt_Count.Text = dgv_TonerList.Rows.Count.ToString();
        }
        public usr_Toners()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_Name.Text) && !String.IsNullOrEmpty(txt_Av.Text))
            {
                toner.Update(currentID, txt_Name.Text, int.Parse(txt_Av.Text));
                btn_Save_Edit.Visible = false;
                refresh();
            }
            else
            {
                MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var result = toner.Search(txt_Name.Text);
            if (result.Count > 0)
            {
                MessageBox.Show("الحبارة مسجلة من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 

                if (!string.IsNullOrEmpty(txt_Name.Text) && !String.IsNullOrEmpty(txt_Av.Text))
                { 
                    toner.Create(txt_Name.Text, int.Parse(txt_Av.Text));
                    MessageBox.Show("تم حفظ الحبارة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("يرجى إكمال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_Av.Clear();
           
            txt_Name.ReadOnly = false;
            txt_Av.ReadOnly = false;
           
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Visible = true;
            btn_Save_Edit.Visible = false;
           
            txt_Name.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            
            txt_Name.ReadOnly = false;
            txt_Av.ReadOnly = false;
           
            btn_Save_Edit.Visible = true;
            btn_Save.Visible = false;
            
            var result = toner.findByID(currentID);
            foreach (var item in result)
            {
                try
                {
                    txt_Name.Text = item.Toner_Name;
                    txt_Av.Text = item.Print_Avarage.ToString();

                    

                }
                catch { }


            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //devCycle.Delete(currentID);
                toner.Delete(currentID);
                refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgv_TonerList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_TonerList.CurrentRow.Cells[0].Value.ToString());
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void usr_Toners_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

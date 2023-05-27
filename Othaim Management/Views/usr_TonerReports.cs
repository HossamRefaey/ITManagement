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
    public partial class usr_TonerReports : UserControl
    {
        cls_TonerReports toner = new cls_TonerReports();
        cls_Toners tnr = new cls_Toners();
        cls_Users usr = new cls_Users();
        cls_Branch branch = new cls_Branch();
        //int currentID;
        
        public int userID = 0;


        void getUserID()
        {
            var result = usr.SearchByUser(Properties.Settings.Default.userName).ToList();
            foreach (var item in result)
            {
                userID = item.User_id;
            }
        }
        void refresh()
        {
            try
            {

                nud_PrintCount.ReadOnly = true;
                txt_Notes.ReadOnly = true;

                dtp_FirstDate.Enabled = false;
                dtp_LastDate.Enabled = false;

                cbx_BranchList.SelectedIndex = -1;
                cbx_BranchSearch.SelectedIndex = -1;
                cbx_Model_Search.SelectedIndex = -1;
                cbx_TonerModel.SelectedIndex = -1;

                cbx_BranchList.Enabled = false;
                cbx_TonerModel.Enabled = false;

                dtp_FirstDate.Value = DateTime.Now;
                dtp_LastDate.Value = DateTime.Now;
                dtp_From.Value = DateTime.Now;
                dtp_To.Value = DateTime.Now;

                btn_Edit.Enabled = false;
                btn_Save.Visible = false;
                btn_Save_Edit.Visible = false;

                nud_PrintCount.Value = 0;
                txt_Notes.Clear();
                cbxBranchlFill();
                cbxTonerFill();
                dgvfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            

        }

        void cbxTonerFill()
        {
            cbx_TonerModel.DataSource = tnr.List();
            cbx_TonerModel.ValueMember = "Toner_ID";
            cbx_TonerModel.DisplayMember = "Toner_Name";
            cbx_TonerModel.SelectedIndex = -1;
        }
        void cbxBranchlFill()
        {
            try
            {
              

                if (Properties.Settings.Default.Authority == "user")
                {
                    getUserID();
                    cbx_BranchList.DataSource = branch.List();
                    cbx_BranchList.ValueMember = "branch_id";
                    cbx_BranchList.DisplayMember = "branch_id";
                    cbx_BranchList.SelectedIndex = -1;


                    cbx_BranchSearch.DataSource = branch.ListByBranchUser(userID);
                    cbx_BranchSearch.ValueMember = "branch_id";
                    cbx_BranchSearch.DisplayMember = "branch_id";
                    cbx_BranchSearch.SelectedIndex = -1;
                }
                else if (Properties.Settings.Default.Authority == "admin")
                {
                    getUserID();
                    cbx_BranchList.DataSource = branch.List();
                    cbx_BranchList.ValueMember = "branch_id";
                    cbx_BranchList.DisplayMember = "branch_id";
                    cbx_BranchList.SelectedIndex = -1;


                    cbx_BranchSearch.DataSource = branch.List();
                    cbx_BranchSearch.ValueMember = "branch_id";
                    cbx_BranchSearch.DisplayMember = "branch_id";
                    cbx_BranchSearch.SelectedIndex = -1;
                }



            }
            catch { }
        }

        void dgvfill()
        {
            dgv_TonerList.Rows.Clear();

            getUserID();

            if (Properties.Settings.Default.Authority == "user")
            {
                var result = toner.ListByUser(userID);
                int rowindex = 0;

                foreach (var item in result)
                {
                    try
                    {
                        dgv_TonerList.Rows.Add(1);
                        dgv_TonerList.Rows[rowindex].Cells[0].Value = item.ID.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[1].Value = item.Branch_ID.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[2].Value = item.sys_Toners.Toner_Name;
                        dgv_TonerList.Rows[rowindex].Cells[3].Value = item.PrintCount.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[4].Value = Convert.ToDateTime(item.First_Date).ToString("dd/MM/yyyy");
                        dgv_TonerList.Rows[rowindex].Cells[5].Value = Convert.ToDateTime(item.Last_Date).ToString("dd/MM/yyyy");
                        dgv_TonerList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.Order_Date).ToString("dd/MM/yyyy hh:mm tt");
                        dgv_TonerList.Rows[rowindex].Cells[7].Value = item.sys_Users.Name;
                        dgv_TonerList.Rows[rowindex].Cells[8].Value = item.Notes;


                        dgv_TonerList.ClearSelection();

                    }
                    catch { }
                    rowindex++;
                }
            }
            else if (Properties.Settings.Default.Authority == "admin")
            {
                var result = toner.List();
                int rowindex = 0;

                foreach (var item in result)
                {
                    try
                    {
                        dgv_TonerList.Rows.Add(1);
                        dgv_TonerList.Rows[rowindex].Cells[0].Value = item.ID.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[1].Value = item.Branch_ID.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[2].Value = item.sys_Toners.Toner_Name;
                        dgv_TonerList.Rows[rowindex].Cells[3].Value = item.PrintCount.ToString();
                        dgv_TonerList.Rows[rowindex].Cells[4].Value = Convert.ToDateTime(item.First_Date).ToString("dd/MM/yyyy");
                        dgv_TonerList.Rows[rowindex].Cells[5].Value = Convert.ToDateTime(item.Last_Date).ToString("dd/MM/yyyy");
                        dgv_TonerList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.Order_Date).ToString("dd/MM/yyyy hh:mm tt");
                        dgv_TonerList.Rows[rowindex].Cells[7].Value = item.sys_Users.Name;
                        dgv_TonerList.Rows[rowindex].Cells[8].Value = item.Notes;


                        dgv_TonerList.ClearSelection();

                    }
                    catch { }
                    rowindex++;
                }
            }

            




            txt_Count.Text = dgv_TonerList.Rows.Count.ToString();
        }
        public usr_TonerReports()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void usr_TonerReports_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txt_PrintCount.Text) && !String.IsNullOrEmpty(txt_Av.Text))
            //{
            //    toner.Update(currentID, txt_PrintCount.Text, int.Parse(txt_Av.Text));
            //    btn_Save_Edit.Visible = false;
            //    refresh();
            //}
            //else
            //{
            //    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        void CheckToner()
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if (nud_PrintCount.Value > 0 && cbx_BranchList.SelectedValue != null && cbx_TonerModel.SelectedValue != null)
                {
                    if (dtp_FirstDate.Value < DateTime.Now && dtp_FirstDate.Value < dtp_LastDate.Value)
                    {
                        string id = cbx_BranchList.SelectedValue.ToString() + cbx_TonerModel.Text + DateTime.Now.ToString("ddMMyyyy");

                        string orderID = "";
                        var result = toner.Search(id);
                        foreach (var item in result)
                        {
                            orderID = item.ID;
                        }

                        if (orderID != id)
                        {
                            var tonerCheck = toner.findByTonerID(int.Parse(cbx_TonerModel.SelectedValue.ToString()));
                            int count = 0;
                            string check = "";
                            foreach (var item in tonerCheck)
                            {
                                count = int.Parse(item.sys_Toners.Print_Avarage.ToString());
                            }
                            if (nud_PrintCount.Value < count)
                            {
                                check = "الورق المطبوع أقل من الحد المسموح";
                            }

                            DateTime firstDate = dtp_FirstDate.Value;
                            DateTime lastDate = dtp_LastDate.Value;
                            DateTime today = DateTime.Now;

                            

                            toner.Create(id, int.Parse(cbx_BranchList.SelectedValue.ToString()), int.Parse(cbx_TonerModel.SelectedValue.ToString()), userID, int.Parse(nud_PrintCount.Value.ToString()),
                                firstDate,lastDate, today, 
                                txt_Notes.Text+" "+ check);
                            MessageBox.Show("تم حفظ الحبارة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("هذه العملية مكررة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("يرجى إدخال تاريخ التركيب صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("يرجى إكمال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            refresh();
            cbx_BranchList.Enabled = true;
            cbx_TonerModel.Enabled = true;
            dtp_FirstDate.Enabled = true;
            dtp_LastDate.Enabled = true;
            txt_Notes.ReadOnly = false;
            nud_PrintCount.ReadOnly = false;
            btn_Save.Visible = Enabled;


            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //txt_PrintCount.ReadOnly = false;
            //txt_Av.ReadOnly = false;

            //btn_Save_Edit.Visible = true;
            //btn_Save.Visible = false;

            //var result = toner.findByID(currentID);
            //foreach (var item in result)
            //{
            //    try
            //    {
            //        txt_PrintCount.Text = item.Toner_Name;
            //        txt_Av.Text = item.Print_Avarage.ToString();



            //    }
            //    catch { }


            //}
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_AllTime.Checked == true)
            {
                dtp_From.Enabled = false;
                dtp_To.Enabled = false;
            }
            else
            {
                dtp_From.Enabled = true;
                dtp_To.Enabled = true;
            }
        }
    }
}

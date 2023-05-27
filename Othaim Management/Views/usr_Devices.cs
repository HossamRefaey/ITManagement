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
using ZXing;
using System.Drawing.Printing;

namespace Othaim_Management.Views
{
    public partial class usr_Devices : UserControl
    {
        cls_Category cat = new cls_Category();
        cls_DevType dev_type = new cls_DevType();
        cls_DevModel model = new cls_DevModel();
        cls_Status stat = new cls_Status();
        cls_Type type = new cls_Type();
        cls_Devices dev = new cls_Devices();
        cls_Branch branch = new cls_Branch();
        cls_deviceCycle devCycle = new cls_deviceCycle();
        cls_Users usr = new cls_Users();

        public int currentID;
        public string branchName;
        public int userID = 0;

        void getUserID()
        {
            var result = usr.SearchByUser(Properties.Settings.Default.userName).ToList();
            foreach (var item in result)
            {
                userID = item.User_id;
            }
        }

        void autocomplete()
        {
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();

            var result = dev.List();

            int index = 0;
            string[] stringArray = new string[result.Count];

            foreach (var item in result)
            {
                stringArray[index] = item.Name;
                
                index++;
            }

            sourcename.AddRange(stringArray);
            this.txt_Name.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txt_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_Name.AutoCompleteCustomSource = sourcename;
        }



        void cbxCategoryFill()
        {
            cbx_CategoryList.DataSource = cat.List();
            cbx_CategoryList.ValueMember = "category_id";
            cbx_CategoryList.DisplayMember = "Name";
            cbx_CategoryList.SelectedIndex = -1;
        }

        void cbxDevTypeFill()
        {
            try
            {
                
                cbx_DevType.DataSource = dev_type.findByCatID(int.Parse(cbx_CategoryList.SelectedValue.ToString()));
                cbx_DevType.ValueMember = "devType_ID";
                cbx_DevType.DisplayMember = "dev_type";
                cbx_DevType.SelectedIndex = -1;
                
            }
            catch { }
            
        }

        void cbxBranchlFill()
        {
            try
            {
                if (Properties.Settings.Default.stock == false)
                {
                    getUserID();
                    cbx_BranchList.DataSource = branch.ListByBranchUser(userID);
                    cbx_BranchList.ValueMember = "branch_id";
                    cbx_BranchList.DisplayMember = "Name";
                    cbx_BranchList.SelectedIndex = -1;


                    cbx_BranchSearch.DataSource = branch.ListByBranchUser(userID);
                    cbx_BranchSearch.ValueMember = "branch_id";
                    cbx_BranchSearch.DisplayMember = "Name";
                    cbx_BranchSearch.SelectedIndex = -1;
                }
                else if(Properties.Settings.Default.stock == true && Properties.Settings.Default.Authority == "user")
                {
                    getUserID();
                    cbx_BranchList.DataSource = branch.ListByStoreTrueUser(userID);
                    cbx_BranchList.ValueMember = "branch_id";
                    cbx_BranchList.DisplayMember = "Name";
                    cbx_BranchList.SelectedIndex = -1;


                    cbx_BranchSearch.DataSource = branch.List();
                    cbx_BranchSearch.ValueMember = "branch_id";
                    cbx_BranchSearch.DisplayMember = "Name";
                    cbx_BranchSearch.SelectedIndex = -1;
                }

                else if (Properties.Settings.Default.stock == true && Properties.Settings.Default.Authority == "admin")
                {
                    getUserID();
                    cbx_BranchList.DataSource = branch.List();
                    cbx_BranchList.ValueMember = "branch_id";
                    cbx_BranchList.DisplayMember = "Name";
                    cbx_BranchList.SelectedIndex = -1;


                    cbx_BranchSearch.DataSource = branch.List();
                    cbx_BranchSearch.ValueMember = "branch_id";
                    cbx_BranchSearch.DisplayMember = "Name";
                    cbx_BranchSearch.SelectedIndex = -1;
                }


            }
            catch { }
        }
        void cbxModelFill()
        {
            try
            {


                cbx_DevModel.DataSource = model.findByTypeID(int.Parse(cbx_DevType.SelectedValue.ToString()));
                cbx_DevModel.ValueMember = "model_id";
                cbx_DevModel.DisplayMember = "Name";
                cbx_DevModel.SelectedIndex = -1;
            }
            catch { }
        }

       

        

        void cbx_DevModelSearch()
        {
            cbx_Model_Search.DataSource = model.List();
            cbx_Model_Search.ValueMember = "model_id";
            cbx_Model_Search.DisplayMember = "Name";
            cbx_Model_Search.SelectedIndex = -1;
        }
        void refresh()
        {
            
            cbxBranchlFill();
            cbx_DevModelSearch();
            cbxCategoryFill();
            btn_DevicePrint.Enabled = false;
           
            cbx_CategoryList.Enabled = false;
            cbx_DevType.Enabled = false;
            cbx_DevModel.Enabled = false;
            
            cbx_BranchList.Enabled = false;
            txt_Name.ReadOnly = true;
            txt_SN.ReadOnly = true;
            
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            txt_Notes.ReadOnly = true;
            txt_Name.Clear();
            txt_Notes.Clear();
            txt_Search.Clear();
            txt_SN.Clear();
            dgvfill();
            btn_Genirate.Enabled = false;
            btn_Print.Visible = false;
            dgv_DevicesList.Rows.Clear();
            txt_Count.Text = "0";
            cbx_BranchSearch.SelectedIndex = -1;
            cbx_Model_Search.SelectedIndex = -1;
        }

        void dgvfill()
        {
            //dgv_DevicesList.Rows.Clear();

            //if (Properties.Settings.Default.stock == false)
            //{
            //    var result = dev.ListByUser();
            //    int rowindex = 0;


            //    foreach (var item in result)
            //    {
            //        try
            //        {
            //            dgv_DevicesList.Rows.Add(1);
            //            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
            //            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
            //            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
            //            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
            //            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
            //            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
            //            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
            //            {
            //                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
            //            }
            //            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
            //            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

            //            dgv_DevicesList.ClearSelection();

            //        }
            //        catch { }
            //        rowindex++;
            //    }
            //}
            //else
            //{
            //    var result = dev.List();
            //    int rowindex = 0;


            //    foreach (var item in result)
            //    {
            //        try
            //        {
            //            dgv_DevicesList.Rows.Add(1);
            //            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
            //            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
            //            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
            //            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
            //            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
            //            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
            //            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
            //            {
            //                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
            //            }
            //            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
            //            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

            //            dgv_DevicesList.ClearSelection();

            //        }
            //        catch { }
            //        rowindex++;
            //    }
            //}
            
           
            //txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
        }

        void SearchByModel()
        {
            if (Properties.Settings.Default.stock == false)
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.FindByModelWithUser(int.Parse(cbx_Model_Search.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
            else
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.FindByModel(int.Parse(cbx_Model_Search.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }

                
        }

        void SearchByBranch()
        {
            if (Properties.Settings.Default.stock == false)
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.FindByBranchWithUser(int.Parse(cbx_BranchSearch.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
            else
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.FindByBranch(int.Parse(cbx_BranchSearch.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
                
        }

        void SearchBySerial()
        {
            if (Properties.Settings.Default.stock == false)
            {
                dgv_DevicesList.Rows.Clear();
                var result = dev.SearchWithUser(txt_Search.Text);
                int rowindex = 0;


                foreach (var item in result)
                {
                    try
                    {
                        dgv_DevicesList.Rows.Add(1);
                        dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                        dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                        dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                        dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                        dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                        dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                        if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                        {
                            dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                        }
                        else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                        dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                        dgv_DevicesList.ClearSelection();

                    }
                    catch { }





                    rowindex++;
                }
                txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
            }
            else
            {
                dgv_DevicesList.Rows.Clear();
                var result = dev.Search(txt_Search.Text);
                int rowindex = 0;


                foreach (var item in result)
                {
                    try
                    {
                        dgv_DevicesList.Rows.Add(1);
                        dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                        dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                        dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                        dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                        dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                        dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                        if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                        {
                            dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                        }
                        else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                        dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                        dgv_DevicesList.ClearSelection();

                    }
                    catch { }





                    rowindex++;
                }
                txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
            }
                
        }

        public usr_Devices()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_Notes.Clear();
            txt_SN.Clear();
            cbx_CategoryList.Enabled = true;
            cbx_CategoryList.SelectedIndex = -1;
            cbx_DevType.Enabled = true;
            cbx_DevType.SelectedIndex = -1;
            cbx_DevModel.Enabled = true;
            cbx_DevModel.SelectedIndex = -1;
            
            cbx_BranchList.Enabled = true;
            cbx_BranchList.SelectedIndex = -1;
            cbx_BranchSearch.SelectedIndex = -1;
            txt_Name.ReadOnly = false;
            txt_SN.ReadOnly = false;
            
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Visible = true;
            btn_Save_Edit.Visible = false;
            txt_Notes.ReadOnly = false;
            cbx_DevModel.DataSource = null;
            cbx_DevType.DataSource = null;
            
            txt_Name.Focus();
            btn_Genirate.Enabled = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            cbx_CategoryList.Enabled = true;
            
            cbx_DevType.Enabled = true;
            cbx_DevModel.Enabled = true;
            btn_Print.Visible = true;
            cbx_BranchList.Enabled = false;
            txt_Name.ReadOnly = false;
            txt_SN.ReadOnly = false;
            
            btn_Save_Edit.Visible = true;
            btn_Save.Visible = false;
            txt_Notes.ReadOnly = false;
            btn_Genirate.Enabled = true;
            var result = dev.FindByID(currentID);
            foreach (var item in result)
            {
                try
                {
                    txt_Name.Text = item.Name;
                    txt_SN.Text = item.SN;
                    txt_Notes.Text = item.Notes;
                    cbx_CategoryList.SelectedValue = item.category_ID;
                    cbx_DevType.SelectedValue = item.dev_Type_id;
                    cbx_DevModel.SelectedValue = item.model_id;
                    
                    cbx_BranchList.SelectedValue = item.branch_id;
                    //cbx_DeptList.SelectedValue = item.dept_id;
                    
                }
                catch { }
                

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //devCycle.Delete(currentID);
                dev.Delete(currentID);
                refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }


        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.devNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.devEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.devDeletebtn;
            btn_Print.Visible = Properties.Settings.Default.devNewbtn;

        }

        private void usr_Devices_Load(object sender, EventArgs e)
        {
            permission();
         
            refresh();
            autocomplete();

        }

        private void dgv_DevicesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_DevicesList.CurrentRow.Cells[0].Value.ToString());
            branchName = dgv_DevicesList.CurrentRow.Cells[7].Value.ToString();
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                SearchBySerial();
            }
            else
            {
                refresh();
            }
        }

        private void cbx_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDevTypeFill();
        }

        private void cbx_DevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModelFill();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            string username = branch.GetUserID(branchName);
            //string dept;
            //if (cbx_DeptList.SelectedValue != null)
            //{
            //    dept = cbx_DeptList.SelectedValue.ToString();

            //}
            //else
            //{
                

            //}

            if (username == Properties.Settings.Default.userName || Properties.Settings.Default.Authority == "admin")
            {
                if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_SN.Text) && cbx_CategoryList.SelectedItem != null &&
                cbx_DevType.SelectedItem != null && cbx_DevModel.SelectedValue != null && cbx_BranchList.SelectedItem != null)
                {
                    dev.Update(currentID, txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
                    int.Parse(cbx_CategoryList.SelectedValue.ToString()), txt_Notes.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()));
                    devCycle.Update(currentID,txt_SN.Text);
                    btn_Save_Edit.Visible = false;
                    refresh();
                }
                else
                {
                    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("لا يمكن التعديل إلا من طرف المسؤول عن المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        int type_id;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var modelresutl = model.findByID(int.Parse(cbx_DevModel.SelectedValue.ToString()));
                foreach (var item in modelresutl)
                {
                    type_id = int.Parse(item.type_id.ToString());
                }

                int id = dev.FirstID();

                if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_SN.Text) && cbx_CategoryList.SelectedItem != null &&
                    cbx_DevType.SelectedItem != null && cbx_DevModel.SelectedValue != null && cbx_BranchList.SelectedItem != null)
                {
                    var result = dev.ChekSerial(txt_SN.Text);
                    if (result.Count() <= 0)
                    {
                        string tosite = cbx_BranchList.SelectedValue.ToString();
                        //if (cbx_DeptList.SelectedItem != null)
                        //{
                        dev.Create(txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
                        int.Parse(cbx_CategoryList.SelectedValue.ToString()), type_id, 1,
                        Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), txt_Notes.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()));
                        devCycle.CreateDev(id, tosite, txt_SN.Text,5, DateTime.Now);



                            //    dev.Create(txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
                            //   int.Parse(cbx_CategoryList.SelectedValue.ToString()), int.Parse(cbx_Type.SelectedValue.ToString()), int.Parse(cbx_Status.SelectedValue.ToString()),
                            //   Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), txt_Notes.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()), int.Parse(cbx_DeptList.SelectedValue.ToString()));
                            //    devCycle.Create(id, int.Parse(cbx_DeptList.SelectedValue.ToString()), txt_SN.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));

                        //}
                        //else
                        //{


                        //    dev.CreateWithnull(txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
                        //    int.Parse(cbx_CategoryList.SelectedValue.ToString()), int.Parse(cbx_Type.SelectedValue.ToString()), int.Parse(cbx_Status.SelectedValue.ToString()),
                        //    Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), txt_Notes.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()));
                        //    devCycle.Create(id, tosite, txt_SN.Text,5,0, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                        //    //    dev.CreateWithnull(txt_Name.Text, txt_SN.Text, int.Parse(cbx_DevModel.SelectedValue.ToString()), int.Parse(cbx_DevType.SelectedValue.ToString()),
                        //    //   int.Parse(cbx_CategoryList.SelectedValue.ToString()), int.Parse(cbx_Type.SelectedValue.ToString()), int.Parse(cbx_Status.SelectedValue.ToString()),
                        //    //   Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), txt_Notes.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()));
                        //    //    devCycle.CreateWithNull(id, txt_SN.Text, int.Parse(cbx_BranchList.SelectedValue.ToString()), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                        //}

                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("هذا الجهاز مسجل من قبل", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("يرجى إكمال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);return;  }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void cbx_DevModelSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SearchByModel();
            txt_Search.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string mdl = (cbx_Model_Search.SelectedItem != null) ? mdl=cbx_Model_Search.SelectedValue.ToString() : mdl="null";
            //string br = (cbx_BranchSearch.SelectedItem != null) ? br=cbx_BranchSearch.SelectedValue.ToString() : br = "null";

            if (cbx_Model_Search.SelectedItem != null && cbx_BranchSearch.SelectedItem != null)
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.SearchBy_Mdl_NotNull_Br_NotNull(int.Parse(cbx_Model_Search.SelectedValue.ToString()), int.Parse(cbx_BranchSearch.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
            else if (cbx_Model_Search.SelectedItem == null && cbx_BranchSearch.SelectedItem != null)
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.SearchBy_Mdl_Null_Br_NotNull(int.Parse(cbx_BranchSearch.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
            else if (cbx_Model_Search.SelectedItem != null && cbx_BranchSearch.SelectedItem == null)
            {
                try
                {

                    dgv_DevicesList.Rows.Clear();
                    var result = dev.SearchBy_Mdl_NotNull_Br_Null(int.Parse(cbx_Model_Search.SelectedValue.ToString()));
                    int rowindex = 0;


                    foreach (var item in result)
                    {

                        try
                        {
                            dgv_DevicesList.Rows.Add(1);
                            dgv_DevicesList.Rows[rowindex].Cells[0].Value = item.Device_id.ToString();
                            dgv_DevicesList.Rows[rowindex].Cells[1].Value = item.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[2].Value = item.sys_dev_model.Name;
                            dgv_DevicesList.Rows[rowindex].Cells[3].Value = item.sys_Type.name;
                            dgv_DevicesList.Rows[rowindex].Cells[4].Value = item.sys_status.status;
                            dgv_DevicesList.Rows[rowindex].Cells[5].Value = item.Notes;
                            if (!string.IsNullOrWhiteSpace(item.opr_date.ToString()))
                            {
                                dgv_DevicesList.Rows[rowindex].Cells[6].Value = Convert.ToDateTime(item.opr_date).ToShortDateString();
                            }
                            else { dgv_DevicesList.Rows[rowindex].Cells[6].Value = ""; }
                            dgv_DevicesList.Rows[rowindex].Cells[7].Value = item.sys_branch.name;

                            dgv_DevicesList.ClearSelection();

                        }
                        catch { }
                        rowindex++;
                    }
                    txt_Count.Text = dgv_DevicesList.Rows.Count.ToString();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("يرجى تحديد إختيار للبحث","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void btn_Genirate_Click(object sender, EventArgs e)
        {
            Guid gd = Guid.NewGuid();
            string shrt_id="";
            try
            {
                if (cbx_CategoryList.SelectedItem != null)
                {
                    int id = int.Parse(cbx_CategoryList.SelectedValue.ToString());
                    var result = cat.findByID(id);
                    foreach (var item in result)
                    {
                        shrt_id = item.shrt_id;
                    }

                    string trimmed = String.Concat(shrt_id.Where(c => !Char.IsWhiteSpace(c)));
                    string serial = "OTH" + trimmed + gd;
                    string final = serial.Substring(0, 10).ToUpper();

                    txt_SN.Text = final;
                    btn_Print.Visible = true;

                }
                else
                {
                    MessageBox.Show("يرجى إختيار القسم أولا","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception) { return; }



            //frm_CodeGeneration frm = new frm_CodeGeneration();
            //frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbx_BranchSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SearchByBranch();
            txt_Search.Clear();
            btn_DevicePrint.Enabled = true;

        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };


            //pictureBox1.Image = writer.Write(textBox1.Text);
            System.Drawing.Image img = writer.Write(txt_SN.Text);
            //img= new Bitmap(img, new Size(150, 80));
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);
        }
     
        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_SN.Text))
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += PrintPage;
                    pd.Print();
                }
                else
                {
                    MessageBox.Show("يرجى إدخال الباركود أولاً","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txt_SN.Focus();
                }
                
            }
            catch
            {
                MessageBox.Show("يرجى التأكد من تحديد طابعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string strCmdText;
                strCmdText = "control printers";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }

            //frm_CodeGeneration frm = new frm_CodeGeneration();
            //frm.ShowDialog();

            //Properties.Settings.Default.barcode = txt_SN.Text;
            //Properties.Settings.Default.Save();
            //Report.frm_BarcodePrint frm = new Report.frm_BarcodePrint();
            //frm.ShowDialog();
        }

        private void cbx_BranchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cls_Dept dept = new cls_Dept();
            //try
            //{
            //    cbx_DeptList.DataSource = dept.findByBranchID(int.Parse(cbx_BranchList.SelectedValue.ToString()));
            //    cbx_DeptList.ValueMember = "dept_id";
            //    cbx_DeptList.DisplayMember = "name";
            //    cbx_DeptList.SelectedIndex = -1;
            //}
            //catch { return; }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            refresh();

        }

        private void btn_DevicePrint_Click(object sender, EventArgs e)
        {
            if (dgv_DevicesList.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد بيانات للطباعة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return ;
            }
            else if(cbx_BranchSearch.SelectedItem == null)
            {
                MessageBox.Show("يرجى تحديد المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Properties.Settings.Default.id = int.Parse(cbx_BranchSearch.SelectedValue.ToString());
                Properties.Settings.Default.Save();
                Report.frm_Devices_rpt frm = new Report.frm_Devices_rpt();
                frm.ShowDialog();
            }
        }
    }
}

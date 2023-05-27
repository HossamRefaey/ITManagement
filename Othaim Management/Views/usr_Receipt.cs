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
    public partial class usr_Receipt : UserControl
    {
        cls_Users usr = new cls_Users();
        cls_Branch branch = new cls_Branch();
        cls_Dept dept = new cls_Dept();
        cls_Devices dev = new cls_Devices();
        cls_STK_HDR hdr = new cls_STK_HDR();
        cls_STK_DTL dtl = new cls_STK_DTL();
        cls_deviceCycle devCycle = new cls_deviceCycle();
        cls_DevModel Model = new cls_DevModel();

        void getUser()
        {
            var result = usr.Search(Properties.Settings.Default.userName).ToList();
            foreach (var item in result)
            {
                txt_User.Text = item.Name;
                txt_UserEmpCode.Text = item.JobCode.ToString();

            }
        }

        void cbx_StatFill()
        {
            cbx_Status.DataSource = new Dictionary<int, string>()
            {
                {1, "جديد"},
                { 2, "مستعمل"},
                {5, "بحاجة للصيانة"},
                {6, "بحاجة للإهلاك"},
            }.ToList();
            cbx_Status.ValueMember = "Key";
            cbx_Status.DisplayMember = "Value";
            cbx_Status.SelectedIndex = -1;
        }

        void refresh()
        {
            txt_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            getUser();
            cbxBranchlFill();
            cbxStoreFill();
            cbx_FromBranch.SelectedIndex = -1;
            cbx_ToBranch.SelectedIndex = -1;
            cbx_ToDept.SelectedIndex = -1;
            txt_EmpCode.Clear();
            txt_RecevName.Clear();
            dgv_ModelList.Rows.Clear();
            cbx_StatFill();
        }
        public usr_Receipt()
        {
            InitializeComponent();
        }

        void cbxBranchlFill()
        {

            cbx_ToBranch.DataSource = branch.ListByStoreFalse();
            cbx_ToBranch.ValueMember = "branch_id";
            cbx_ToBranch.DisplayMember = "Name";
            cbx_ToBranch.SelectedIndex = -1;



        }
        public int userID = 0;

        void getUserID()
        {
            var result = usr.SearchByUser(Properties.Settings.Default.userName).ToList();
            foreach (var item in result)
            {
                userID = item.User_id;
            }
        }
        void cbxStoreFill()
        {

            if (Properties.Settings.Default.stock == true && Properties.Settings.Default.Authority == "admin")
            {
                getUserID();
                cbx_FromBranch.DataSource = branch.ListByStoreTrue();
                cbx_FromBranch.ValueMember = "branch_id";
                cbx_FromBranch.DisplayMember = "Name";
                cbx_FromBranch.SelectedIndex = -1;
            }
            else if (Properties.Settings.Default.stock == true && Properties.Settings.Default.Authority == "user")
            {
                getUserID();
                cbx_FromBranch.DataSource = branch.ListByStoreTrueUser(userID);
                cbx_FromBranch.ValueMember = "branch_id";
                cbx_FromBranch.DisplayMember = "Name";
                cbx_FromBranch.SelectedIndex = -1;
            }

        }

        void InsertRowByBarcode()
        {
            try
            {

                string barcode = txt_DevSerial.Text;
                int store = int.Parse(cbx_ToBranch.SelectedValue.ToString());

                if (!string.IsNullOrEmpty(txt_DevSerial.Text))
                {
                    var result = dev.ChekSerialInStore(store, barcode);

                    // create table
                    var dt = new DataTable("tableName");

                    if (cbx_ToBranch.SelectedItem != null)
                    {
                        if (result.Count >= 1)
                        {
                            if (cbx_Status.SelectedItem != null)
                            {

                                foreach (var item in result)
                                {


                                    // create Column
                                    dt.Columns.Add("col1", typeof(int));
                                    dt.Columns.Add("col2", typeof(string));
                                    dt.Columns.Add("col3", typeof(string));
                                    dt.Columns.Add("col4", typeof(string));
                                    dt.Columns.Add("col5", typeof(string));
                                    dt.Columns.Add("col6", typeof(string));
                                    dt.Columns.Add("com7", typeof(int));

                                    // insert row values
                                    dt.Rows.Add(new Object[] { item.Device_id, item.sys_dev_model.Item_Code, item.Name, item.SN, item.sys_dev_model.Name, item.sys_dev_type.dev_type, cbx_Status.SelectedValue });

                                }


                                // if scanned duplicated Product qty +1


                                for (int i = 0; i < dgv_ModelList.Rows.Count; i++)
                                {
                                    if (dt.Rows[0][0].ToString() == dgv_ModelList.Rows[i].Cells[0].Value.ToString())
                                    {
                                        MessageBox.Show("مكرر", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txt_DevSerial.Clear();
                                        txt_DevSerial.Focus();
                                        return;

                                    }

                                }

                                // else add new row of product

                                dgv_ModelList.Rows.Add(1);
                                int rowindex = dgv_ModelList.Rows.Count - 1;
                                dgv_ModelList.Rows[rowindex].Cells[0].Value = dt.Rows[0][0].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[1].Value = dt.Rows[0][1].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[2].Value = dt.Rows[0][2].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[3].Value = dt.Rows[0][3].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[4].Value = dt.Rows[0][4].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[5].Value = dt.Rows[0][5].ToString();
                                dgv_ModelList.Rows[rowindex].Cells[6].Value = dt.Rows[0][6].ToString();
                                txt_DevSerial.Clear();
                                txt_DevSerial.Focus();
                                cbx_Status.SelectedIndex = -1;


                            }
                            else
                            {
                                MessageBox.Show("يرجى تحديد حالة الجهاز", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                        else
                        {
                            MessageBox.Show("غير متاج في المخزن المحدد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد المخزن المصروف منه", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("يرجى إدخال سريال الجهاز", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                

            }
            catch (Exception) { return; }

        }

        private void btn_DevAdd_Click(object sender, EventArgs e)
        {
            InsertRowByBarcode();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void usr_Receipt_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_RecevName.Text) && !string.IsNullOrWhiteSpace(txt_EmpCode.Text) && !string.IsNullOrWhiteSpace(txt_User.Text)
                && !string.IsNullOrWhiteSpace(txt_UserEmpCode.Text) && cbx_FromBranch.SelectedItem != null && cbx_ToBranch.SelectedItem != null && dgv_ModelList.Rows.Count >= 1)
            {
                int doctype = 3;
                int id = hdr.FirstID();
                //try
                //{
                string fromsitenum = cbx_ToBranch.SelectedValue.ToString();
                string fromsitename = cbx_ToBranch.Text + " " + cbx_ToDept.Text;
                string tositenum = cbx_FromBranch.SelectedValue.ToString();
                string tositename = cbx_FromBranch.Text;


                //STK_HDR
                hdr.Create(id, fromsitenum, fromsitename, tositenum, tositename, doctype, txt_User.Text, int.Parse(txt_UserEmpCode.Text), txt_RecevName.Text, int.Parse(txt_EmpCode.Text)
                    , Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));


                // STK_DTL
                for (int i = 0; i <= dgv_ModelList.Rows.Count - 1; i++)
                {
                    int proID = int.Parse(dgv_ModelList.Rows[i].Cells[0].Value.ToString());
                    string itemCode = dgv_ModelList.Rows[i].Cells[1].Value.ToString();
                    string ItemName = dgv_ModelList.Rows[i].Cells[2].Value.ToString();
                    string Serial = dgv_ModelList.Rows[i].Cells[3].Value.ToString();
                    string modelName = dgv_ModelList.Rows[i].Cells[4].Value.ToString();
                    int statID = int.Parse(dgv_ModelList.Rows[i].Cells[6].Value.ToString());
                    ////


                    dtl.Create(id, proID, ItemName, Serial, modelName, itemCode);
                    devCycle.Create(proID, tositenum + " " + tositename, Serial, doctype, id, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));

                    dev.UpdateByBranch(proID, int.Parse(cbx_FromBranch.SelectedValue.ToString()), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), statID);
                    ////
                }
                MessageBox.Show("تم إتمام العملية بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.id = id;
                Properties.Settings.Default.Save();
                Report.frm_Receipt_rpt frm = new Report.frm_Receipt_rpt();
                frm.ShowDialog();
                refresh();
                //}
                //catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            }
            else
            {
                MessageBox.Show("يرجى إكمال البيانات الناقصة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_EmpCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_EmpCode.Text))
            {
                txt_CheckEmp.Visible = false;
            }
        }

        private void btn_ChekEmp_Click(object sender, EventArgs e)
        {
            //cls_ZKTeco zkt = new cls_ZKTeco();
            //var result = zkt.FindByID(txt_EmpCode.Text);
            //if (!string.IsNullOrWhiteSpace(txt_EmpCode.Text))
            //{
            //    if (result.Count >= 1)
            //    {
            //        txt_CheckEmp.Text = "الموظف مسجل";
            //        txt_CheckEmp.Visible = true;

            //    }
            //    else
            //    {
            //        txt_CheckEmp.Text = "الموظف غير مسجل";
            //        txt_CheckEmp.Visible = true;
            //    }
            //}
        }

        private void cbx_ToBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbx_ToDept.DataSource = dept.findByBranchID(int.Parse(cbx_ToBranch.SelectedValue.ToString()));
                cbx_ToDept.ValueMember = "dept_id";
                cbx_ToDept.DisplayMember = "name";
                cbx_ToDept.SelectedIndex = -1;
            }
            catch { return; }
        }

        private void btn_CancelITem_Click(object sender, EventArgs e)
        {
            if (dgv_ModelList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_ModelList.SelectedRows)
                {
                    dgv_ModelList.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}

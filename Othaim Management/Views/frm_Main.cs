using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Othaim_Management.Controller;
using System.Net;

namespace Othaim_Management.Views
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void permission()
        {
            
            btnBranch.Enabled = Properties.Settings.Default.brWin;
            btnCategory.Enabled = Properties.Settings.Default.catWin;
            btnDept.Enabled = Properties.Settings.Default.deptWin;
            btnDevices.Enabled = Properties.Settings.Default.devWin;
            btnDevType.Enabled = Properties.Settings.Default.devTypeWin;
            btnModel.Enabled = Properties.Settings.Default.mdlWin;
            btnStat.Enabled = Properties.Settings.Default.statWin;
            btnType.Enabled = Properties.Settings.Default.typeWin;
            btnUsers.Enabled = Properties.Settings.Default.usrWin;
            btn_TransOut.Enabled = Properties.Settings.Default.transout;
            btn_Transin.Enabled = Properties.Settings.Default.transin;
            btn_TransReport.Enabled = Properties.Settings.Default.transReport;
            btn_Manage_FeedBack.Enabled = Properties.Settings.Default.feedBackMgr;
            btn_Phone.Enabled = Properties.Settings.Default.PhoneWin;
            btn_Toner.Enabled = Properties.Settings.Default.Toner;
            btn_TonerReport.Enabled = Properties.Settings.Default.TonerReport;
            btn_DeviceCycle.Enabled = Properties.Settings.Default.deviceCycleReport;
            btn_DeviceReports.Enabled = Properties.Settings.Default.DeviceReport;
            btn_Depreciation.Enabled = Properties.Settings.Default.Depreciation;
            btn_Maintenance.Enabled = Properties.Settings.Default.Maintenance;
            btn_Contact_Branches.Enabled = Properties.Settings.Default.ContactBranchesWin;




        }
        public frm_Main()
        {
            InitializeComponent();
            //if (Properties.Settings.Default.Authority == "admin")
            //{
            //    barButtonItem14_ItemClick_1(null, null);

            //}
            //else
            //{
            //    btn_Home.Enabled = false;
            //}
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Branch category = new usr_Branch();
            var findButton = this.pnl1.Controls.Find("usr_Branch", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                category.Dock = DockStyle.Fill;
                this.pnl1.Controls.Add(category);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Department category = new usr_Department();
            var findButton = this.pnl1.Controls.Find("usr_Department", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                category.Dock = DockStyle.Fill;
                this.pnl1.Controls.Add(category);
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

            usr_Category category = new usr_Category();
            var findButton = this.pnl1.Controls.Find("usr_Category", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                category.Dock = DockStyle.Fill;
                this.pnl1.Controls.Add(category);
            }
            else{  }
            
            
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Device_Type uc = new usr_Device_Type();

            var findButton = this.pnl1.Controls.Find("usr_Device_Type", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);
               
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Device_Model uc = new usr_Device_Model();

            var findButton = this.pnl1.Controls.Find("usr_Device_Model", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);
               
            }


           
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Type uc = new usr_Type();

            var findButton = this.pnl1.Controls.Find("usr_Type", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Status uc = new usr_Status();

            var findButton = this.pnl1.Controls.Find("usr_Status", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Devices uc = new usr_Devices();

            var findButton = this.pnl1.Controls.Find("usr_Devices", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Users uc = new usr_Users();

            var findButton = this.pnl1.Controls.Find("usr_Users", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void frm_Main_Load(object sender, EventArgs e)
        {
            permission();
            lbl_User.Caption = "مرحبا بك : " + Properties.Settings.Default.userName;
            lbl_Version.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void rib_Sittengs_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            usr_Dispose uc = new usr_Dispose();

            var findButton = this.pnl1.Controls.Find("usr_Dispose", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            usr_DeviceOps uc = new usr_DeviceOps();

            var findButton = this.pnl1.Controls.Find("usr_DeviceOps", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

       

        private void btn_FeedBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_FeedBack uc = new usr_FeedBack();

            var findButton = this.pnl1.Controls.Find("usr_FeedBack", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
            
        }

        private void btn_Manage_FeedBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_FeedBackReport uc = new usr_FeedBackReport();

            var findButton = this.pnl1.Controls.Find("usr_FeedBackReport", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            usr_Home uc = new usr_Home();

            var findButton = this.pnl1.Controls.Find("usr_Home", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem14_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            usr_Phone uc = new usr_Phone();

            var findButton = this.pnl1.Controls.Find("usr_Phone", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem14_ItemClick_3(object sender, ItemClickEventArgs e)
        {
            frm_About frm = new frm_About();
            frm.ShowDialog();
        }

        private void barButtonItem17_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            usr_TonerReports uc = new usr_TonerReports();

            var findButton = this.pnl1.Controls.Find("usr_TonerReports", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem18_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Receipt uc = new usr_Receipt();

            var findButton = this.pnl1.Controls.Find("usr_Receipt", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_Toners uc = new usr_Toners();

            var findButton = this.pnl1.Controls.Find("usr_Toners", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_DeviceCycle uc = new usr_DeviceCycle();

            var findButton = this.pnl1.Controls.Find("usr_DeviceCycle", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            usr_DeviceReport uc = new usr_DeviceReport();

            var findButton = this.pnl1.Controls.Find("usr_DeviceReport", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }

        private void barButtonItem18_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            usr_Contact_Branches uc = new usr_Contact_Branches();

            var findButton = this.pnl1.Controls.Find("usr_Contact_Branches", true).ToList();
            if (findButton.Count <= 0)
            {
                this.pnl1.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                this.pnl1.Controls.Add(uc);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Views;
using Othaim_Management.Model;
using System.IO;
using System.Security.Cryptography;
using Othaim_Management.Controller;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Othaim_Management.Views
{

    public partial class frm_Login : Form
    {

        cls_Users usr = new cls_Users();
        cls_TransActions trans = new cls_TransActions();
        string must = "";
        string dis = "";
        
        static string verDate = "2023-05-16";
        DateTime AppVerDate = Convert.ToDateTime(verDate);
        DateTime NewVerDate;

        void Login()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    //pass = txtPassword.Text;

                    var result = usr.SearchByPassword(txtUsername.Text, cls_Encoding.Encrypt(txtPassword.Text));
                    if (result.Count() > 0)
                    {
                        foreach (var item in result)
                        {
                            
                            must = item.mustPassChange.ToString();
                            dis = item.accountDisabled.ToString();
                            Properties.Settings.Default.id = item.User_id;
                            Properties.Settings.Default.userName = item.UserName;
                            Properties.Settings.Default.brWin = item.brWin.Value;
                            Properties.Settings.Default.brNewbtn = item.brNewbtn.Value;
                            Properties.Settings.Default.brEditbtn = item.brEditbtn.Value;
                            Properties.Settings.Default.brDeletebtn = item.brDeletebtn.Value;
                            Properties.Settings.Default.deptWin = item.deptWin.Value;
                            Properties.Settings.Default.deptNewbtn = item.deptNewbtn.Value;
                            Properties.Settings.Default.deptEditbtn = item.deptEditbtn.Value;
                            Properties.Settings.Default.deptDeletebtn = item.deptDeletebtn.Value;
                            Properties.Settings.Default.usrWin = item.usrWin.Value;
                            Properties.Settings.Default.usrNewbtn = item.usrNewbtn.Value;
                            Properties.Settings.Default.usrEditbtn = item.usrEditbtn.Value;
                            Properties.Settings.Default.usrDeletebtn = item.usrDeletebtn.Value;
                            Properties.Settings.Default.catWin = item.catWin.Value;
                            Properties.Settings.Default.catNewbtn = item.catNewbtn.Value;
                            Properties.Settings.Default.catEditbtn = item.catEditbtn.Value;
                            Properties.Settings.Default.catDeletebtn = item.catDeletebtn.Value;
                            Properties.Settings.Default.devTypeWin = item.devTypeWin.Value;
                            Properties.Settings.Default.devTypeNewbtn = item.devTypeNewbtn.Value;
                            Properties.Settings.Default.devTypeEditbtn = item.devTypeEditbtn.Value;
                            Properties.Settings.Default.devTypeDeletebtn = item.devTypeDeletebtn.Value;
                            Properties.Settings.Default.mdlWin = item.mdlWin.Value;
                            Properties.Settings.Default.mdlNewbtn = item.mdlNewbtn.Value;
                            Properties.Settings.Default.mdlEditbtn = item.mdlEditbtn.Value;
                            Properties.Settings.Default.mdlDeletebtn = item.mdlDeletebtn.Value;
                            Properties.Settings.Default.typeWin = item.typeWin.Value;
                            Properties.Settings.Default.typeNewbtn = item.typeNewbtn.Value;
                            Properties.Settings.Default.typeEditbtn = item.typeEditbtn.Value;
                            Properties.Settings.Default.typeDeletebtn = item.typeDeletebtn.Value;
                            Properties.Settings.Default.statWin = item.statWin.Value;
                            Properties.Settings.Default.statNewbtn = item.statNewbtn.Value;
                            Properties.Settings.Default.statEditbtn = item.statEditbtn.Value;
                            Properties.Settings.Default.statDeletebtn = item.statDeletebtn.Value;
                            Properties.Settings.Default.devWin = item.devWin.Value;
                            Properties.Settings.Default.devNewbtn = item.devNewbtn.Value;
                            Properties.Settings.Default.devEditbtn = item.devEditbtn.Value;
                            Properties.Settings.Default.devDeletebtn = item.devDeletebtn.Value;
                            Properties.Settings.Default.transout = item.transoutWin.Value;
                            Properties.Settings.Default.stock = item.stock.Value;
                            Properties.Settings.Default.transin = item.transInWin.Value;
                            Properties.Settings.Default.transReport = item.transReportWin.Value;
                            Properties.Settings.Default.transReportDeletebtn = item.transReportDeletebtn.Value;
                            Properties.Settings.Default.feedBackMgr = item.feedBackMgr.Value;
                            Properties.Settings.Default.Authority = item.Authority;
                            Properties.Settings.Default.PhoneWin = item.PhoneWin.Value;
                            Properties.Settings.Default.phoneNewbtn = item.phoneNewbtn.Value;
                            Properties.Settings.Default.phoneEditbtn = item.phoneEditbtn.Value;
                            Properties.Settings.Default.phoneDeletebtn = item.phoneDeletebtn.Value;
                            Properties.Settings.Default.Toner = item.TonerWin.Value;
                            Properties.Settings.Default.TonerReport = item.TonerReportWin.Value;
                            Properties.Settings.Default.deviceCycleReport = item.DevCycleReportWin.Value;
                            Properties.Settings.Default.DeviceReport = item.DevReportWin.Value;
                            Properties.Settings.Default.Maintenance = item.MaintenanceWin.Value;
                            Properties.Settings.Default.Depreciation = item.DepreciationWin.Value;
                            Properties.Settings.Default.ContactBranchesWin = item.ContactBranchesWin.Value;
                            Properties.Settings.Default.Save();
                        }

                        if (must == "True" && dis == "True")
                        {
                            MessageBox.Show("هذا المستخدم موقوف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (must == "True" && dis == "False")
                        {
                            MessageBox.Show("يجب أولاً تغيير كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Properties.Settings.Default.chk = false;
                            Properties.Settings.Default.Save();
                            frm_ResetPassword frm1 = new frm_ResetPassword();
                            frm1.ShowDialog();

                        }
                        else if (must == "False" && dis == "True")
                        {
                            MessageBox.Show("هذا المستخدم موقوف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (must == "False" && dis == "False")
                        {
                            this.Hide();
                            var frm = new frm_Main();
                            //---------- Login Count ------------//

                            usr.UpdateLoginCount(txtUsername.Text);

                            //---------- Save PC Info --------------//
                            transAction();

                            frm.Closed += (s, args) => this.Close();
                            frm.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("يرجى التأكد من إسم المستخدم وكلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("يرجى إكمال البيانات", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception d)
            {
                MessageBox.Show(d.ToString());
            }
        }


       
        private string _IP()
        {
            String strHostName = string.Empty;
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            string ip = "";

            var result = addr.ToList();
            foreach (var item in result)
            {
                ip += item.MapToIPv4().ToString() + ";";

            }

            return ip;
        }

        public frm_Login()
        {
            InitializeComponent();
        }

        

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Enter User Name");
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Enter Password");
                }
                else
                {
                    panel1_Click(null, null);
                }
            }
        }


        
        public int userID = 0;
        
        void getUserID()
        {
            var result = usr.SearchByUser(txtUsername.Text).ToList();
            foreach (var item in result)
            {
                userID = item.User_id;
            }
        }


        // Get IPv4 From Ethernet and Wireless
        
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        void transAction()
        {
            try
            {
                getUserID();
                //string ip = "Ethernet (" + GetLocalIPv4(NetworkInterfaceType.Ethernet) + ") " + "WIFI (" + GetLocalIPv4(NetworkInterfaceType.Wireless80211) + ")";
                string ip = _IP();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string HostName = Dns.GetHostName();
                trans.Create(ip,userName, HostName,DateTime.Now, userID);
                //MessageBox.Show(ip);
                //MessageBox.Show(userName);
                //MessageBox.Show(HostName);
                //MessageBox.Show(DateTime.Now.ToString());
                //MessageBox.Show(userID.ToString());
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                cls_Update update = new cls_Update();
                var result = update.List();


                foreach (var item in result)
                {
                    NewVerDate = Convert.ToDateTime(item.ver_date);
                }

                if (AppVerDate != NewVerDate)
                {
                    Update frm = new Update();
                    frm.ShowDialog();
                }
                this.BackColor = Color.Blue;
                this.TransparencyKey = Color.Blue;
                lbl_Ver.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            }
            catch
            {
                MessageBox.Show("لايمكن الإتصال بقاعدة البيانات","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                var result = usr.ResetPass(txtUsername.Text);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        Properties.Settings.Default.id = item.User_id;

                    }
                    Properties.Settings.Default.chk = false;
                    Properties.Settings.Default.Save();
                    frm_ResetPassword frm1 = new frm_ResetPassword();
                    frm1.ShowDialog();
                }
                else { MessageBox.Show("اسم المستخدم غير صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("يرجى كتابة اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox2.BackgroundImage = Properties.Resources.hide;
            if (txtPassword.UseSystemPasswordChar == true)
            {
                
            }
            else
            {
                
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox2.BackgroundImage = Properties.Resources.view;
        }
    }
}

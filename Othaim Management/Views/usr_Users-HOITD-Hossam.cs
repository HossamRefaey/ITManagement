using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class usr_Users : UserControl
    {
        cls_Users usr = new cls_Users();
        int currentID;
        public static string encrPass = "";
        void permission()
        {

            btn_Save.Enabled = Properties.Settings.Default.usrNewbtn;
            btn_Save_Edit.Enabled = Properties.Settings.Default.usrEditbtn;
            btn_Delete.Visible = Properties.Settings.Default.usrDeletebtn;


        }
        static string Encrypt()
        {
            try
            {
                string textToEncrypt = encrPass;
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        static string Decrypt()
        {
            
            try
            {
                string textToDecrypt = encrPass;
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        void dgvFill()
        {
            dgv_UsersList.Rows.Clear();
            var result = usr.List();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_UsersList.Rows.Add(1);
                dgv_UsersList.Rows[rowindex].Cells[0].Value = item.User_id.ToString();
                dgv_UsersList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_UsersList.Rows[rowindex].Cells[2].Value = item.Phone;
                dgv_UsersList.Rows[rowindex].Cells[3].Value = item.Email;
                dgv_UsersList.Rows[rowindex].Cells[4].Value = item.JobCode;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_UsersList.Rows.Count.ToString();
            dgv_UsersList.ClearSelection();
        }

        void Search()
        {
            dgv_UsersList.Rows.Clear();
            var result = usr.Search(txt_Search.Text);
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_UsersList.Rows.Add(1);
                dgv_UsersList.Rows[rowindex].Cells[0].Value = item.User_id.ToString();
                dgv_UsersList.Rows[rowindex].Cells[1].Value = item.Name;
                dgv_UsersList.Rows[rowindex].Cells[2].Value = item.Phone;
                dgv_UsersList.Rows[rowindex].Cells[3].Value = item.Email;
                dgv_UsersList.Rows[rowindex].Cells[4].Value = item.JobCode;

                rowindex++;
            }
            label1.Text = "عدد السجلات : " + dgv_UsersList.Rows.Count.ToString();
            dgv_UsersList.ClearSelection();
        }

        void refresh()
        {
            dgvFill();
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            txt_Name.ReadOnly = true;
            txt_Phone.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_JobCode.ReadOnly = true;
            txt_UserName.ReadOnly = true;
            //txt_Password.ReadOnly = true;
            btn_Save.Visible = false;
            btn_Save_Edit.Visible = false;
            btn_SetPerrmission.Visible = false;
            btn_ResetPass.Visible = false;
            chk_MustBeChange.Visible = false;
            chk_UserDesable.Visible = false;
            txt_Pass.Visible = false;
            txt_ConfirmPass.Visible = false;
            label7.Visible = false;
            label9.Visible = false;

            txt_Name.Clear();
            txt_Phone.Clear();
            txt_Email.Clear();
            txt_JobCode.Clear();
            txt_UserName.Clear();
            txt_Pass.Clear();
            txt_ConfirmPass.Clear();
            //txt_Password.Clear();
        }

        public usr_Users()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Name.ReadOnly = false;
            txt_Phone.ReadOnly = false;
            txt_Email.ReadOnly = false;
            txt_JobCode.ReadOnly = false;
            txt_UserName.ReadOnly = false;
            //txt_Password.ReadOnly = false;

            btn_Save.Visible = true;
            txt_ConfirmPass.Visible = true;
            txt_Pass.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            chk_MustBeChange.Visible = true;
            chk_UserDesable.Visible = true;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Name.ReadOnly = false;
            txt_Phone.ReadOnly = false;
            txt_Email.ReadOnly = false; 
            txt_JobCode.ReadOnly = false;
            txt_UserName.ReadOnly = true;
            btn_ResetPass.Visible = true;
            //txt_Password.ReadOnly = false;
            btn_SetPerrmission.Visible = true;
            btn_Save_Edit.Visible = true;

            var result = usr.FindByID(currentID);
            foreach (var item in result)
            {
                txt_Name.Text = item.Name;
                txt_Phone.Text = item.Phone;
                txt_Email.Text = item.Email;
                txt_JobCode.Text = item.JobCode.ToString();
                txt_UserName.Text = item.UserName;
                encrPass = item.Password;
                //try
                //{
                //    string pass = Decrypt();
                //    txt_Password.Text = pass;
                //}
                //catch { txt_Password.Text = "132546789"; }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                usr.Delete(currentID);
                refresh();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {
            try
            { 
                if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_Phone.Text) && !string.IsNullOrWhiteSpace(txt_Email.Text) &&
                    !string.IsNullOrWhiteSpace(txt_JobCode.Text) && !string.IsNullOrWhiteSpace(txt_UserName.Text)/* && !string.IsNullOrWhiteSpace(txt_Password.Text)*/)
                {
                    //encrPass = txt_Password.Text;
                    usr.Update(currentID,txt_Name.Text, txt_Phone.Text, txt_Email.Text, int.Parse(txt_JobCode.Text), txt_UserName.Text/*, Encrypt()*/);
                    refresh();
                }
                else
                {
                    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
}

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_Name.Text) && !string.IsNullOrWhiteSpace(txt_Phone.Text) && !string.IsNullOrWhiteSpace(txt_Email.Text) &&
                !string.IsNullOrWhiteSpace(txt_JobCode.Text) && !string.IsNullOrWhiteSpace(txt_UserName.Text) && !string.IsNullOrWhiteSpace(txt_Pass.Text) && !string.IsNullOrWhiteSpace(txt_ConfirmPass.Text))
                {
                    if (txt_ConfirmPass.Text == txt_Pass.Text)
                    {
                        encrPass = txt_ConfirmPass.Text;
                        bool must = (chk_MustBeChange.Checked == true) ? true : false;
                        bool disabled = (chk_UserDesable.Checked == true) ? true : false;
                        usr.Create(txt_Name.Text, txt_Phone.Text, txt_Email.Text, int.Parse(txt_JobCode.Text), txt_UserName.Text, Encrypt(), must, disabled);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("تأكيد كلمة السر غير متطابق", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_ConfirmPass.Focus();
                        txt_ConfirmPass.Select();

                    }
                }
                else
                {
                    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void dgv_StatusList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentID = int.Parse(dgv_UsersList.CurrentRow.Cells[0].Value.ToString());
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Edit_Click(null, null);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void usr_Users_Load(object sender, EventArgs e)
        {
            permission();
            refresh();
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id = currentID;
            Properties.Settings.Default.chk = true;
            Properties.Settings.Default.Save();
            frm_ResetPassword frm1 = new frm_ResetPassword();
            frm1.ShowDialog();
        }

        private void btn_SetPerrmission_Click(object sender, EventArgs e)
        {
            frm_Permission frm = new frm_Permission();
            frm.ShowDialog();
        }
    }
}

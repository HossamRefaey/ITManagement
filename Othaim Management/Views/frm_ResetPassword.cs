using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Othaim_Management.Controller;
using System.IO;
using System.Security.Cryptography;

namespace Othaim_Management.Views
{
    public partial class frm_ResetPassword : DevExpress.XtraEditors.XtraForm
    {

        cls_Users usr = new cls_Users();
        cls_TransActions trans = new cls_TransActions();
        public static string pass;


       
        void show()
        {
            
            chk_MustBeChange.Visible = Properties.Settings.Default.chk;
            chk_UserDesable.Visible = Properties.Settings.Default.chk;
            if (Properties.Settings.Default.chk == true)
            {
                txt_OldPass.Visible = false;
                label1.Visible = false;
            }

            var result = usr.FindByID(Properties.Settings.Default.id);
            foreach (var item in result)
            {
                string must = item.mustPassChange.ToString();
                string dis = item.accountDisabled.ToString();
                txt_Name.Text = item.Name;
                txt_UserName.Text = item.UserName;
                pass = item.Password;
                if (must == "True") { chk_MustBeChange.Checked = true; } else { chk_MustBeChange.Checked = false; }
                if (dis == "True") { chk_UserDesable.Checked = true; } else { chk_UserDesable.Checked = false; }

            }
        }

        void chekPass()
        {
            // Admin Access
            if (Properties.Settings.Default.chk == true)
            {
                if (chk_UserDesable.Checked == true)
                {

                    usr.accDis(Properties.Settings.Default.id, chk_UserDesable.Checked == true);
                    Close();

                }
                else if (!string.IsNullOrWhiteSpace(txt_NewPass.Text) && !string.IsNullOrWhiteSpace(txt_ConfirmPass.Text))
                {
                    if (txt_ConfirmPass.Text == txt_NewPass.Text)
                    {
                        bool must = (chk_MustBeChange.Checked == true) ? true : false;
                        bool disabled = (chk_UserDesable.Checked == true) ? true : false;
                        //pass = txt_ConfirmPass.Text;
                        if (Properties.Settings.Default.chk == false)
                        { disabled = false; }
                        usr.UpdatePass(Properties.Settings.Default.id, cls_Encoding.Encrypt(txt_ConfirmPass.Text), must, disabled);
                        MessageBox.Show("تم تغيير كلمة المرور بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("تأكيد كلمة المرور غير مطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_ConfirmPass.Select();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                
            }
            // User Access
            else
            {
                if (txt_OldPass.Text == cls_Encoding.Decrypt(pass))
                {
                    if (!string.IsNullOrWhiteSpace(txt_OldPass.Text) && !string.IsNullOrWhiteSpace(txt_NewPass.Text) && !string.IsNullOrWhiteSpace(txt_ConfirmPass.Text))
                    {
                        if (txt_ConfirmPass.Text == txt_NewPass.Text)
                        {
                            if ( txt_ConfirmPass.Text != txt_OldPass.Text)
                            {
                                bool must = false;
                                bool disabled = false;
                                //pass = txt_ConfirmPass.Text;
                                if (Properties.Settings.Default.chk == false)
                                { disabled = false; }
                                usr.UpdatePass(Properties.Settings.Default.id, cls_Encoding.Encrypt(txt_ConfirmPass.Text), must, disabled);
                                MessageBox.Show("تم تغيير كلمة المرور بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show("يرجى كتابة كلمة مرور مختلفة عن الحالية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txt_ConfirmPass.Focus();
                                txt_ConfirmPass.Select();
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("تأكيد كلمة المرور غير مطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_ConfirmPass.Select();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لايمكن ترك حقول فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                }
                else
                {
                    MessageBox.Show("يرجى التأكد من كلمة المرور الحالية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_OldPass.Select();
                    return;
                }
            }
            

        }

        public frm_ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            chekPass();
        }

        private void frm_ResetPassword_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
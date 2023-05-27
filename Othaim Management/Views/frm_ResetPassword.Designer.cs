namespace Othaim_Management.Views
{
    partial class frm_ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ResetPassword));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_UserDesable = new System.Windows.Forms.CheckBox();
            this.chk_MustBeChange = new System.Windows.Forms.CheckBox();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.txt_OldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(12, 21);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(238, 32);
            this.txt_Name.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "الاسم:";
            // 
            // chk_UserDesable
            // 
            this.chk_UserDesable.AutoSize = true;
            this.chk_UserDesable.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.chk_UserDesable.Location = new System.Drawing.Point(12, 224);
            this.chk_UserDesable.Name = "chk_UserDesable";
            this.chk_UserDesable.Size = new System.Drawing.Size(114, 29);
            this.chk_UserDesable.TabIndex = 4;
            this.chk_UserDesable.Text = "توقيف الحساب";
            this.chk_UserDesable.UseVisualStyleBackColor = true;
            // 
            // chk_MustBeChange
            // 
            this.chk_MustBeChange.AutoSize = true;
            this.chk_MustBeChange.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.chk_MustBeChange.Location = new System.Drawing.Point(142, 224);
            this.chk_MustBeChange.Name = "chk_MustBeChange";
            this.chk_MustBeChange.Size = new System.Drawing.Size(168, 29);
            this.chk_MustBeChange.TabIndex = 3;
            this.chk_MustBeChange.Text = "الإلزام بتغيير كلمة المرور";
            this.chk_MustBeChange.UseVisualStyleBackColor = true;
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.Location = new System.Drawing.Point(12, 175);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ConfirmPass.Size = new System.Drawing.Size(238, 32);
            this.txt_ConfirmPass.TabIndex = 2;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 99;
            this.label9.Text = "تأكيد كلمة المرور:";
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Location = new System.Drawing.Point(12, 137);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NewPass.Size = new System.Drawing.Size(238, 32);
            this.txt_NewPass.TabIndex = 1;
            this.txt_NewPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "كلمة المرور الجديدة:";
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Appearance.Options.UseTextOptions = true;
            this.btn_Save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Save.AppearanceHovered.Options.UseFont = true;
            this.btn_Save.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Save.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Save.AppearancePressed.Options.UseFont = true;
            this.btn_Save.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Save.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Save.Location = new System.Drawing.Point(159, 269);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 40);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseTextOptions = true;
            this.btn_close.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_close.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_close.AppearanceHovered.Options.UseFont = true;
            this.btn_close.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_close.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_close.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_close.AppearancePressed.Options.UseFont = true;
            this.btn_close.AppearancePressed.Options.UseTextOptions = true;
            this.btn_close.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_close.Location = new System.Drawing.Point(53, 269);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 40);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "إغلاق";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.Location = new System.Drawing.Point(12, 99);
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_OldPass.Size = new System.Drawing.Size(238, 32);
            this.txt_OldPass.TabIndex = 0;
            this.txt_OldPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "كلمة المرور الحالية:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(12, 61);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_UserName.Size = new System.Drawing.Size(238, 32);
            this.txt_UserName.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "اسم المستخدم:";
            // 
            // frm_ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 334);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_OldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.chk_UserDesable);
            this.Controls.Add(this.chk_MustBeChange);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_ResetPassword.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ResetPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إعادة تعيين كلمة المرور";
            this.Load += new System.EventHandler(this.frm_ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_UserDesable;
        private System.Windows.Forms.CheckBox chk_MustBeChange;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
    }
}
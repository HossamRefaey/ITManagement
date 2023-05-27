namespace Othaim_Management.Views
{
    partial class frm_Device_Model_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Device_Model_Edit));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.cbx_DevType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Category = new System.Windows.Forms.ComboBox();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ModelName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "الكود:";
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemCode.Location = new System.Drawing.Point(25, 164);
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(205, 32);
            this.txt_itemCode.TabIndex = 62;
            // 
            // cbx_DevType
            // 
            this.cbx_DevType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_DevType.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DevType.FormattingEnabled = true;
            this.cbx_DevType.Location = new System.Drawing.Point(25, 66);
            this.cbx_DevType.Name = "cbx_DevType";
            this.cbx_DevType.Size = new System.Drawing.Size(205, 33);
            this.cbx_DevType.TabIndex = 61;
            this.cbx_DevType.SelectedIndexChanged += new System.EventHandler(this.cbx_DevType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "نوع الجهاز:";
            // 
            // cbx_Category
            // 
            this.cbx_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Category.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Category.FormattingEnabled = true;
            this.cbx_Category.Location = new System.Drawing.Point(25, 12);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(205, 33);
            this.cbx_Category.TabIndex = 59;
            this.cbx_Category.SelectedIndexChanged += new System.EventHandler(this.cbx_Category_SelectedIndexChanged_1);
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.Appearance.Options.UseTextOptions = true;
            this.btn_Close.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Close.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Close.AppearanceHovered.Options.UseFont = true;
            this.btn_Close.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Close.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Close.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Close.AppearancePressed.Options.UseFont = true;
            this.btn_Close.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Close.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageOptions.Image")));
            this.btn_Close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Close.Location = new System.Drawing.Point(157, 206);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(73, 80);
            this.btn_Close.TabIndex = 58;
            this.btn_Close.Text = "إغلاق";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.btn_Save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Save.Location = new System.Drawing.Point(241, 206);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(73, 80);
            this.btn_Save.TabIndex = 57;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "القسم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "الموديل:";
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModelName.Location = new System.Drawing.Point(25, 118);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(205, 32);
            this.txt_ModelName.TabIndex = 54;
            // 
            // frm_Device_Model_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_itemCode);
            this.Controls.Add(this.cbx_DevType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Category);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ModelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_Device_Model_Edit.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Device_Model_Edit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل الموديل";
            this.Load += new System.EventHandler(this.frm_Device_Model_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_itemCode;
        private System.Windows.Forms.ComboBox cbx_DevType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Category;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ModelName;
    }
}
namespace Othaim_Management.Views
{
    partial class frm_Edit_Device
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cbx_Item_Type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Item_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.cbx_Category = new System.Windows.Forms.ComboBox();
            this.cbx_DevModel = new System.Windows.Forms.ComboBox();
            this.cbx_DevType = new System.Windows.Forms.ComboBox();
            this.txt_Item_Serial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "ملاحظات:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Notes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(28, 180);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Notes.Size = new System.Drawing.Size(257, 55);
            this.txt_Notes.TabIndex = 33;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(129, 307);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Close.Size = new System.Drawing.Size(75, 35);
            this.btn_Close.TabIndex = 32;
            this.btn_Close.Text = "إغلاق";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cbx_Item_Type
            // 
            this.cbx_Item_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Item_Type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Item_Type.FormattingEnabled = true;
            this.cbx_Item_Type.Items.AddRange(new object[] {
            "أصل",
            "مستهلك"});
            this.cbx_Item_Type.Location = new System.Drawing.Point(28, 255);
            this.cbx_Item_Type.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Item_Type.Name = "cbx_Item_Type";
            this.cbx_Item_Type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Item_Type.Size = new System.Drawing.Size(73, 27);
            this.cbx_Item_Type.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "السريال:";
            // 
            // txt_Item_ID
            // 
            this.txt_Item_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Item_ID.Location = new System.Drawing.Point(229, 34);
            this.txt_Item_ID.Name = "txt_Item_ID";
            this.txt_Item_ID.ReadOnly = true;
            this.txt_Item_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Item_ID.Size = new System.Drawing.Size(56, 26);
            this.txt_Item_ID.TabIndex = 29;
            this.txt_Item_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "طبيعة الصنف:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "الحالة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "الموديل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "النوع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "القسم:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(210, 307);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbx_Status
            // 
            this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "جديد",
            "مستعمل",
            "صيانة"});
            this.cbx_Status.Location = new System.Drawing.Point(210, 255);
            this.cbx_Status.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Status.Size = new System.Drawing.Size(75, 27);
            this.cbx_Status.TabIndex = 17;
            // 
            // cbx_Category
            // 
            this.cbx_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Category.FormattingEnabled = true;
            this.cbx_Category.Location = new System.Drawing.Point(28, 69);
            this.cbx_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Category.Size = new System.Drawing.Size(257, 27);
            this.cbx_Category.TabIndex = 16;
            this.cbx_Category.SelectedIndexChanged += new System.EventHandler(this.cbx_Category_SelectedIndexChanged);
            // 
            // cbx_DevModel
            // 
            this.cbx_DevModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_DevModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DevModel.FormattingEnabled = true;
            this.cbx_DevModel.Location = new System.Drawing.Point(28, 143);
            this.cbx_DevModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_DevModel.Name = "cbx_DevModel";
            this.cbx_DevModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_DevModel.Size = new System.Drawing.Size(257, 27);
            this.cbx_DevModel.TabIndex = 13;
            this.cbx_DevModel.SelectedIndexChanged += new System.EventHandler(this.cbx_DevModel_SelectedIndexChanged);
            // 
            // cbx_DevType
            // 
            this.cbx_DevType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_DevType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DevType.FormattingEnabled = true;
            this.cbx_DevType.Location = new System.Drawing.Point(28, 106);
            this.cbx_DevType.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_DevType.Name = "cbx_DevType";
            this.cbx_DevType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_DevType.Size = new System.Drawing.Size(257, 27);
            this.cbx_DevType.TabIndex = 12;
            this.cbx_DevType.SelectedIndexChanged += new System.EventHandler(this.cbx_DevType_SelectedIndexChanged);
            // 
            // txt_Item_Serial
            // 
            this.txt_Item_Serial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Serial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Item_Serial.Location = new System.Drawing.Point(28, 34);
            this.txt_Item_Serial.Name = "txt_Item_Serial";
            this.txt_Item_Serial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Item_Serial.Size = new System.Drawing.Size(197, 26);
            this.txt_Item_Serial.TabIndex = 11;
            this.txt_Item_Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.cbx_Item_Type);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Item_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cbx_Status);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.cbx_DevModel);
            this.groupBox1.Controls.Add(this.cbx_DevType);
            this.groupBox1.Controls.Add(this.txt_Item_Serial);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(393, 353);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعديل";
            // 
            // frm_Edit_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Edit_Device";
            this.Text = "frm_Edit_Device";
            this.Load += new System.EventHandler(this.frm_Edit_Device_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cbx_Item_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Item_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.ComboBox cbx_Category;
        private System.Windows.Forms.ComboBox cbx_DevModel;
        private System.Windows.Forms.ComboBox cbx_DevType;
        private System.Windows.Forms.TextBox txt_Item_Serial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
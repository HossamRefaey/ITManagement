namespace Othaim_Management.Views
{
    partial class usr_Receipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usr_Receipt));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ModelList = new System.Windows.Forms.DataGridView();
            this.cbx_ToDept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_UserEmpCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.cbx_ToBranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EmpCode = new System.Windows.Forms.TextBox();
            this.cbx_FromBranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RecevName = new System.Windows.Forms.TextBox();
            this.txt_DevSerial = new System.Windows.Forms.TextBox();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CheckEmp = new System.Windows.Forms.TextBox();
            this.btn_ChekEmp = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_DevAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CancelITem = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(969, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "عدد السجلات : 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ModelList
            // 
            this.dgv_ModelList.AllowUserToAddRows = false;
            this.dgv_ModelList.AllowUserToDeleteRows = false;
            this.dgv_ModelList.AllowUserToResizeColumns = false;
            this.dgv_ModelList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_ModelList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ModelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ModelList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ModelList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ModelList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ModelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ModelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ModelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column2,
            this.Column7});
            this.dgv_ModelList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ModelList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ModelList.EnableHeadersVisualStyles = false;
            this.dgv_ModelList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ModelList.Location = new System.Drawing.Point(164, 265);
            this.dgv_ModelList.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_ModelList.MultiSelect = false;
            this.dgv_ModelList.Name = "dgv_ModelList";
            this.dgv_ModelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ModelList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ModelList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.dgv_ModelList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ModelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ModelList.Size = new System.Drawing.Size(917, 212);
            this.dgv_ModelList.TabIndex = 105;
            // 
            // cbx_ToDept
            // 
            this.cbx_ToDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ToDept.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ToDept.FormattingEnabled = true;
            this.cbx_ToDept.Location = new System.Drawing.Point(428, 59);
            this.cbx_ToDept.Name = "cbx_ToDept";
            this.cbx_ToDept.Size = new System.Drawing.Size(205, 33);
            this.cbx_ToDept.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(639, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 93;
            this.label10.Text = "إدارة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "الكود الوظيفي:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 92;
            this.label8.Text = "تاريخ اليوم:";
            // 
            // txt_UserEmpCode
            // 
            this.txt_UserEmpCode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserEmpCode.Location = new System.Drawing.Point(12, 158);
            this.txt_UserEmpCode.Name = "txt_UserEmpCode";
            this.txt_UserEmpCode.ReadOnly = true;
            this.txt_UserEmpCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_UserEmpCode.Size = new System.Drawing.Size(205, 32);
            this.txt_UserEmpCode.TabIndex = 89;
            this.txt_UserEmpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 88;
            this.label4.Text = "مسؤول المخزن:";
            // 
            // txt_Date
            // 
            this.txt_Date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(12, 18);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Date.Size = new System.Drawing.Size(205, 32);
            this.txt_Date.TabIndex = 91;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(12, 112);
            this.txt_User.Name = "txt_User";
            this.txt_User.ReadOnly = true;
            this.txt_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_User.Size = new System.Drawing.Size(205, 32);
            this.txt_User.TabIndex = 87;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_ToBranch
            // 
            this.cbx_ToBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ToBranch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ToBranch.FormattingEnabled = true;
            this.cbx_ToBranch.Location = new System.Drawing.Point(428, 15);
            this.cbx_ToBranch.Name = "cbx_ToBranch";
            this.cbx_ToBranch.Size = new System.Drawing.Size(205, 33);
            this.cbx_ToBranch.TabIndex = 86;
            this.cbx_ToBranch.SelectedIndexChanged += new System.EventHandler(this.cbx_ToBranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "الكود الوظيفي:";
            // 
            // txt_EmpCode
            // 
            this.txt_EmpCode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpCode.Location = new System.Drawing.Point(521, 151);
            this.txt_EmpCode.Name = "txt_EmpCode";
            this.txt_EmpCode.Size = new System.Drawing.Size(112, 32);
            this.txt_EmpCode.TabIndex = 79;
            this.txt_EmpCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_EmpCode_KeyUp);
            // 
            // cbx_FromBranch
            // 
            this.cbx_FromBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_FromBranch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FromBranch.FormattingEnabled = true;
            this.cbx_FromBranch.Location = new System.Drawing.Point(12, 62);
            this.cbx_FromBranch.Name = "cbx_FromBranch";
            this.cbx_FromBranch.Size = new System.Drawing.Size(205, 33);
            this.cbx_FromBranch.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "تحويل من:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(639, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "الاسم:";
            // 
            // txt_RecevName
            // 
            this.txt_RecevName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RecevName.Location = new System.Drawing.Point(428, 105);
            this.txt_RecevName.Name = "txt_RecevName";
            this.txt_RecevName.Size = new System.Drawing.Size(205, 32);
            this.txt_RecevName.TabIndex = 75;
            // 
            // txt_DevSerial
            // 
            this.txt_DevSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DevSerial.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DevSerial.Location = new System.Drawing.Point(773, 224);
            this.txt_DevSerial.Name = "txt_DevSerial";
            this.txt_DevSerial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DevSerial.Size = new System.Drawing.Size(205, 32);
            this.txt_DevSerial.TabIndex = 109;
            this.txt_DevSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_Close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Close.ImageOptions.SvgImage")));
            this.btn_Close.Location = new System.Drawing.Point(5, 10);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 37);
            this.btn_Close.TabIndex = 107;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_CheckEmp);
            this.groupBox1.Controls.Add(this.btn_ChekEmp);
            this.groupBox1.Controls.Add(this.cbx_ToDept);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_UserEmpCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.txt_User);
            this.groupBox1.Controls.Add(this.cbx_ToBranch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_EmpCode);
            this.groupBox1.Controls.Add(this.cbx_FromBranch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_RecevName);
            this.groupBox1.Location = new System.Drawing.Point(338, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 210);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            // 
            // txt_CheckEmp
            // 
            this.txt_CheckEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CheckEmp.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CheckEmp.Location = new System.Drawing.Point(360, 155);
            this.txt_CheckEmp.Name = "txt_CheckEmp";
            this.txt_CheckEmp.ReadOnly = true;
            this.txt_CheckEmp.Size = new System.Drawing.Size(103, 23);
            this.txt_CheckEmp.TabIndex = 107;
            this.txt_CheckEmp.Visible = false;
            // 
            // btn_ChekEmp
            // 
            this.btn_ChekEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChekEmp.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChekEmp.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChekEmp.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_ChekEmp.Appearance.Options.UseBackColor = true;
            this.btn_ChekEmp.Appearance.Options.UseFont = true;
            this.btn_ChekEmp.Appearance.Options.UseTextOptions = true;
            this.btn_ChekEmp.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_ChekEmp.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ChekEmp.AppearanceHovered.Options.UseFont = true;
            this.btn_ChekEmp.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_ChekEmp.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_ChekEmp.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ChekEmp.AppearancePressed.Options.UseFont = true;
            this.btn_ChekEmp.AppearancePressed.Options.UseTextOptions = true;
            this.btn_ChekEmp.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_ChekEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChekEmp.ImageOptions.Image")));
            this.btn_ChekEmp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ChekEmp.Location = new System.Drawing.Point(469, 147);
            this.btn_ChekEmp.Name = "btn_ChekEmp";
            this.btn_ChekEmp.Size = new System.Drawing.Size(46, 40);
            this.btn_ChekEmp.TabIndex = 106;
            this.btn_ChekEmp.Visible = false;
            this.btn_ChekEmp.Click += new System.EventHandler(this.btn_ChekEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "محول إلى مخزن:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(984, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 110;
            this.label9.Text = "سريال الجهاز:";
            // 
            // btn_DevAdd
            // 
            this.btn_DevAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DevAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_DevAdd.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DevAdd.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_DevAdd.Appearance.Options.UseBackColor = true;
            this.btn_DevAdd.Appearance.Options.UseFont = true;
            this.btn_DevAdd.Appearance.Options.UseTextOptions = true;
            this.btn_DevAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_DevAdd.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DevAdd.AppearanceHovered.Options.UseFont = true;
            this.btn_DevAdd.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_DevAdd.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_DevAdd.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DevAdd.AppearancePressed.Options.UseFont = true;
            this.btn_DevAdd.AppearancePressed.Options.UseTextOptions = true;
            this.btn_DevAdd.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_DevAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DevAdd.ImageOptions.Image")));
            this.btn_DevAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_DevAdd.Location = new System.Drawing.Point(408, 219);
            this.btn_DevAdd.Name = "btn_DevAdd";
            this.btn_DevAdd.Size = new System.Drawing.Size(91, 40);
            this.btn_DevAdd.TabIndex = 111;
            this.btn_DevAdd.Text = "إضافة";
            this.btn_DevAdd.Click += new System.EventHandler(this.btn_DevAdd_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Save.Location = new System.Drawing.Point(720, 483);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 40);
            this.btn_Save.TabIndex = 104;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_CancelITem
            // 
            this.btn_CancelITem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelITem.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelITem.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelITem.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_CancelITem.Appearance.Options.UseBackColor = true;
            this.btn_CancelITem.Appearance.Options.UseFont = true;
            this.btn_CancelITem.Appearance.Options.UseTextOptions = true;
            this.btn_CancelITem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_CancelITem.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CancelITem.AppearanceHovered.Options.UseFont = true;
            this.btn_CancelITem.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_CancelITem.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_CancelITem.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_CancelITem.AppearancePressed.Options.UseFont = true;
            this.btn_CancelITem.AppearancePressed.Options.UseTextOptions = true;
            this.btn_CancelITem.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_CancelITem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_CancelITem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CancelITem.ImageOptions.SvgImage")));
            this.btn_CancelITem.Location = new System.Drawing.Point(311, 219);
            this.btn_CancelITem.Name = "btn_CancelITem";
            this.btn_CancelITem.Size = new System.Drawing.Size(91, 40);
            this.btn_CancelITem.TabIndex = 108;
            this.btn_CancelITem.Text = "إزالة";
            this.btn_CancelITem.Click += new System.EventHandler(this.btn_CancelITem_Click);
            // 
            // cbx_Status
            // 
            this.cbx_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Status.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Location = new System.Drawing.Point(518, 224);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(157, 33);
            this.cbx_Status.TabIndex = 109;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(681, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 108;
            this.label11.Text = "حالة الجهاز:";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.28572F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "كود الصنف";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "اسم الصنف";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "الرقم التسلسلي";
            this.Column6.Name = "Column6";
            this.Column6.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الموديل";
            this.Column3.Name = "Column3";
            this.Column3.Width = 220;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 169.7143F;
            this.Column2.HeaderText = "نوع الجهاز";
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الحالة";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 140;
            // 
            // usr_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_CancelITem);
            this.Controls.Add(this.btn_DevAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ModelList);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_DevSerial);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "usr_Receipt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1102, 559);
            this.Load += new System.EventHandler(this.usr_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_DevAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ModelList;
        private System.Windows.Forms.ComboBox cbx_ToDept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_UserEmpCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.ComboBox cbx_ToBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EmpCode;
        private System.Windows.Forms.ComboBox cbx_FromBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_RecevName;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.TextBox txt_DevSerial;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CheckEmp;
        private DevExpress.XtraEditors.SimpleButton btn_ChekEmp;
        private DevExpress.XtraEditors.SimpleButton btn_CancelITem;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

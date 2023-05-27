namespace Othaim_Management.Views
{
    partial class usr_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usr_Category));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_CategoryList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Edit_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ShrtName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(660, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "عدد السجلات : 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_CategoryList
            // 
            this.dgv_CategoryList.AllowUserToAddRows = false;
            this.dgv_CategoryList.AllowUserToDeleteRows = false;
            this.dgv_CategoryList.AllowUserToResizeColumns = false;
            this.dgv_CategoryList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_CategoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CategoryList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CategoryList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CategoryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_CategoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_CategoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CategoryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CategoryList.EnableHeadersVisualStyles = false;
            this.dgv_CategoryList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_CategoryList.Location = new System.Drawing.Point(309, 49);
            this.dgv_CategoryList.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_CategoryList.MultiSelect = false;
            this.dgv_CategoryList.Name = "dgv_CategoryList";
            this.dgv_CategoryList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CategoryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_CategoryList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.dgv_CategoryList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CategoryList.Size = new System.Drawing.Size(463, 369);
            this.dgv_CategoryList.TabIndex = 28;
            this.dgv_CategoryList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CategoryList_CellMouseDoubleClick);
            this.dgv_CategoryList.SelectionChanged += new System.EventHandler(this.dgv_CategoryList_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.28572F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 169.7143F;
            this.Column2.HeaderText = "اسم القسم";
            this.Column2.Name = "Column2";
            this.Column2.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الاسم المختصر";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_New.Appearance.Options.UseBackColor = true;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Appearance.Options.UseTextOptions = true;
            this.btn_New.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_New.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_New.AppearanceHovered.Options.UseFont = true;
            this.btn_New.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_New.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_New.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_New.AppearancePressed.Options.UseFont = true;
            this.btn_New.AppearancePressed.Options.UseTextOptions = true;
            this.btn_New.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_New.Location = new System.Drawing.Point(1032, 12);
            this.btn_New.Margin = new System.Windows.Forms.Padding(6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(57, 77);
            this.btn_New.TabIndex = 31;
            this.btn_New.Text = "جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Refresh.Appearance.Options.UseBackColor = true;
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.Appearance.Options.UseTextOptions = true;
            this.btn_Refresh.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Refresh.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.AppearanceHovered.Options.UseFont = true;
            this.btn_Refresh.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Refresh.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Refresh.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.AppearancePressed.Options.UseFont = true;
            this.btn_Refresh.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Refresh.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Refresh.Location = new System.Drawing.Point(825, 12);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(57, 77);
            this.btn_Refresh.TabIndex = 34;
            this.btn_Refresh.Text = "تحديث";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Edit.Appearance.Options.UseBackColor = true;
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Appearance.Options.UseTextOptions = true;
            this.btn_Edit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.AppearanceHovered.Options.UseFont = true;
            this.btn_Edit.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Edit.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.AppearancePressed.Options.UseFont = true;
            this.btn_Edit.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Edit.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit.Enabled = false;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Edit.Location = new System.Drawing.Point(963, 12);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(57, 77);
            this.btn_Edit.TabIndex = 32;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Appearance.Options.UseTextOptions = true;
            this.btn_Delete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Delete.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.AppearanceHovered.Options.UseFont = true;
            this.btn_Delete.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Delete.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Delete.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.AppearancePressed.Options.UseFont = true;
            this.btn_Delete.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Delete.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Delete.Location = new System.Drawing.Point(894, 12);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(57, 77);
            this.btn_Delete.TabIndex = 33;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Close.Location = new System.Drawing.Point(6, 12);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 37);
            this.btn_Close.TabIndex = 35;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Edit_Save);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ShrtName);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(780, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 329);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // btn_Edit_Save
            // 
            this.btn_Edit_Save.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit_Save.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Save.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Edit_Save.Appearance.Options.UseBackColor = true;
            this.btn_Edit_Save.Appearance.Options.UseFont = true;
            this.btn_Edit_Save.Appearance.Options.UseTextOptions = true;
            this.btn_Edit_Save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit_Save.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Edit_Save.AppearanceHovered.Options.UseFont = true;
            this.btn_Edit_Save.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Edit_Save.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit_Save.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Edit_Save.AppearancePressed.Options.UseFont = true;
            this.btn_Edit_Save.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Edit_Save.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Edit_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit_Save.ImageOptions.Image")));
            this.btn_Edit_Save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Edit_Save.Location = new System.Drawing.Point(122, 141);
            this.btn_Edit_Save.Name = "btn_Edit_Save";
            this.btn_Edit_Save.Size = new System.Drawing.Size(91, 40);
            this.btn_Edit_Save.TabIndex = 29;
            this.btn_Edit_Save.Text = "حفظ";
            this.btn_Edit_Save.Visible = false;
            this.btn_Edit_Save.Click += new System.EventHandler(this.btn_Edit_Save_Click);
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
            this.btn_Save.Location = new System.Drawing.Point(122, 141);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 40);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "اسم مختصر:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "اسم القسم:";
            // 
            // txt_ShrtName
            // 
            this.txt_ShrtName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShrtName.Location = new System.Drawing.Point(8, 91);
            this.txt_ShrtName.Name = "txt_ShrtName";
            this.txt_ShrtName.Size = new System.Drawing.Size(205, 32);
            this.txt_ShrtName.TabIndex = 25;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(8, 44);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(205, 32);
            this.txt_Name.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "بحث بالاسم:";
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(477, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(205, 32);
            this.txt_Search.TabIndex = 37;
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // usr_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_CategoryList);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "usr_Category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1100, 560);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_CategoryList;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ShrtName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Search;
    }
}

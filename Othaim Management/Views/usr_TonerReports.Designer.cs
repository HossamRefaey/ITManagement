namespace Othaim_Management.Views
{
    partial class usr_TonerReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usr_TonerReports));
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_TonerList = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_Model_Search = new System.Windows.Forms.ComboBox();
            this.cbx_BranchSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_BranchList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_TonerModel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_PrintCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.dtp_LastDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_FirstDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.chk_AllTime = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TonerList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PrintCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(793, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 150;
            this.label4.Text = "بحث بالتاريخ:";
            // 
            // dgv_TonerList
            // 
            this.dgv_TonerList.AllowUserToAddRows = false;
            this.dgv_TonerList.AllowUserToDeleteRows = false;
            this.dgv_TonerList.AllowUserToResizeColumns = false;
            this.dgv_TonerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TonerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TonerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TonerList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TonerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TonerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TonerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TonerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TonerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TonerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8});
            this.dgv_TonerList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TonerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TonerList.EnableHeadersVisualStyles = false;
            this.dgv_TonerList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_TonerList.Location = new System.Drawing.Point(6, 97);
            this.dgv_TonerList.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_TonerList.MultiSelect = false;
            this.dgv_TonerList.Name = "dgv_TonerList";
            this.dgv_TonerList.ReadOnly = true;
            this.dgv_TonerList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_TonerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TonerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TonerList.RowHeadersVisible = false;
            this.dgv_TonerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F);
            this.dgv_TonerList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TonerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TonerList.Size = new System.Drawing.Size(880, 380);
            this.dgv_TonerList.TabIndex = 142;
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
            this.btn_Refresh.Location = new System.Drawing.Point(1160, 10);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(57, 67);
            this.btn_Refresh.TabIndex = 147;
            this.btn_Refresh.Text = "تحديث";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.btn_New.Location = new System.Drawing.Point(1229, 10);
            this.btn_New.Margin = new System.Windows.Forms.Padding(6);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(57, 67);
            this.btn_New.TabIndex = 143;
            this.btn_New.Text = "جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Search.Appearance.Options.UseBackColor = true;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Appearance.Options.UseTextOptions = true;
            this.btn_Search.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Search.AppearanceHovered.Options.UseFont = true;
            this.btn_Search.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Search.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Search.AppearancePressed.Options.UseFont = true;
            this.btn_Search.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Search.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Enabled = false;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Search.Location = new System.Drawing.Point(202, 8);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(58, 78);
            this.btn_Search.TabIndex = 154;
            this.btn_Search.Text = "بحث";
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
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Edit.Location = new System.Drawing.Point(992, 10);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(57, 67);
            this.btn_Edit.TabIndex = 145;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(458, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 156;
            this.label13.Text = "الفرع:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 153;
            this.label1.Text = "موديل الحبارة:";
            // 
            // txt_Count
            // 
            this.txt_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Count.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(701, 483);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.ReadOnly = true;
            this.txt_Count.Size = new System.Drawing.Size(100, 16);
            this.txt_Count.TabIndex = 152;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseTextOptions = true;
            this.simpleButton2.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.AppearancePressed.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.Options.UseTextOptions = true;
            this.simpleButton2.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(7, 12);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(36, 37);
            this.simpleButton2.TabIndex = 157;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cbx_Model_Search
            // 
            this.cbx_Model_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Model_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Model_Search.Enabled = false;
            this.cbx_Model_Search.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Model_Search.FormattingEnabled = true;
            this.cbx_Model_Search.Location = new System.Drawing.Point(525, 53);
            this.cbx_Model_Search.Name = "cbx_Model_Search";
            this.cbx_Model_Search.Size = new System.Drawing.Size(217, 33);
            this.cbx_Model_Search.TabIndex = 144;
            // 
            // cbx_BranchSearch
            // 
            this.cbx_BranchSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_BranchSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BranchSearch.Enabled = false;
            this.cbx_BranchSearch.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BranchSearch.FormattingEnabled = true;
            this.cbx_BranchSearch.Location = new System.Drawing.Point(280, 53);
            this.cbx_BranchSearch.Name = "cbx_BranchSearch";
            this.cbx_BranchSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_BranchSearch.Size = new System.Drawing.Size(172, 33);
            this.cbx_BranchSearch.TabIndex = 155;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(798, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 151;
            this.label11.Text = "عدد السجلات:";
            // 
            // cbx_BranchList
            // 
            this.cbx_BranchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BranchList.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BranchList.FormattingEnabled = true;
            this.cbx_BranchList.Location = new System.Drawing.Point(6, 35);
            this.cbx_BranchList.Name = "cbx_BranchList";
            this.cbx_BranchList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_BranchList.Size = new System.Drawing.Size(282, 33);
            this.cbx_BranchList.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "الفرع:";
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
            this.btn_Save.Location = new System.Drawing.Point(241, 395);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 40);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Save_Edit
            // 
            this.btn_Save_Edit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save_Edit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Edit.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Save_Edit.Appearance.Options.UseBackColor = true;
            this.btn_Save_Edit.Appearance.Options.UseFont = true;
            this.btn_Save_Edit.Appearance.Options.UseTextOptions = true;
            this.btn_Save_Edit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save_Edit.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Save_Edit.AppearanceHovered.Options.UseFont = true;
            this.btn_Save_Edit.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Save_Edit.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save_Edit.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Save_Edit.AppearancePressed.Options.UseFont = true;
            this.btn_Save_Edit.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Save_Edit.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Save_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_Edit.ImageOptions.Image")));
            this.btn_Save_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Save_Edit.Location = new System.Drawing.Point(241, 395);
            this.btn_Save_Edit.Name = "btn_Save_Edit";
            this.btn_Save_Edit.Size = new System.Drawing.Size(91, 40);
            this.btn_Save_Edit.TabIndex = 8;
            this.btn_Save_Edit.Text = "حفظ";
            this.btn_Save_Edit.Visible = false;
            this.btn_Save_Edit.Click += new System.EventHandler(this.btn_Save_Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "موديل الحبارة:";
            // 
            // cbx_TonerModel
            // 
            this.cbx_TonerModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TonerModel.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TonerModel.FormattingEnabled = true;
            this.cbx_TonerModel.Location = new System.Drawing.Point(6, 74);
            this.cbx_TonerModel.Name = "cbx_TonerModel";
            this.cbx_TonerModel.Size = new System.Drawing.Size(282, 33);
            this.cbx_TonerModel.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(294, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "عدد الورق:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nud_PrintCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.dtp_LastDate);
            this.groupBox1.Controls.Add(this.dtp_FirstDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbx_TonerModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Save_Edit);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbx_BranchList);
            this.groupBox1.Location = new System.Drawing.Point(895, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 468);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            // 
            // nud_PrintCount
            // 
            this.nud_PrintCount.Location = new System.Drawing.Point(168, 114);
            this.nud_PrintCount.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nud_PrintCount.Name = "nud_PrintCount";
            this.nud_PrintCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nud_PrintCount.Size = new System.Drawing.Size(120, 36);
            this.nud_PrintCount.TabIndex = 75;
            this.nud_PrintCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_PrintCount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "تاريخ الإنتهاء:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "تاريخ التركيب:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "ملاحظات:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(50, 242);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Notes.Size = new System.Drawing.Size(238, 64);
            this.txt_Notes.TabIndex = 71;
            // 
            // dtp_LastDate
            // 
            this.dtp_LastDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_LastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_LastDate.Location = new System.Drawing.Point(88, 200);
            this.dtp_LastDate.Name = "dtp_LastDate";
            this.dtp_LastDate.Size = new System.Drawing.Size(200, 36);
            this.dtp_LastDate.TabIndex = 70;
            // 
            // dtp_FirstDate
            // 
            this.dtp_FirstDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FirstDate.Location = new System.Drawing.Point(88, 158);
            this.dtp_FirstDate.Name = "dtp_FirstDate";
            this.dtp_FirstDate.Size = new System.Drawing.Size(200, 36);
            this.dtp_FirstDate.TabIndex = 69;
            // 
            // dtp_From
            // 
            this.dtp_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_From.Enabled = false;
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(596, 5);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(146, 36);
            this.dtp_From.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(748, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 159;
            this.label3.Text = "من:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 161;
            this.label7.Text = "إلى:";
            // 
            // dtp_To
            // 
            this.dtp_To.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_To.Enabled = false;
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(388, 5);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(146, 36);
            this.dtp_To.TabIndex = 160;
            // 
            // chk_AllTime
            // 
            this.chk_AllTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_AllTime.AutoSize = true;
            this.chk_AllTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_AllTime.Enabled = false;
            this.chk_AllTime.Location = new System.Drawing.Point(280, 8);
            this.chk_AllTime.Name = "chk_AllTime";
            this.chk_AllTime.Size = new System.Drawing.Size(93, 32);
            this.chk_AllTime.TabIndex = 162;
            this.chk_AllTime.Text = "كل الوقت";
            this.chk_AllTime.UseVisualStyleBackColor = true;
            this.chk_AllTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.AppearanceHovered.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.Options.UseTextOptions = true;
            this.simpleButton1.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.AppearancePressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.AppearancePressed.Options.UseFont = true;
            this.simpleButton1.AppearancePressed.Options.UseTextOptions = true;
            this.simpleButton1.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(6, 481);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(136, 38);
            this.simpleButton1.TabIndex = 163;
            this.simpleButton1.Text = "طباعة";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.28572F;
            this.Column1.HeaderText = "الكود";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الفرع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الحبارة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 169.7143F;
            this.Column2.HeaderText = "الورق المطبوع";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "تاريخ التركيب";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "تاريخ الإنتهاء";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "تاريخ التسجيل";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 185;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "المستخدم";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 140;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ملاحظات";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 200;
            // 
            // usr_TonerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.chk_AllTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_TonerList);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cbx_Model_Search);
            this.Controls.Add(this.cbx_BranchSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "usr_TonerReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1301, 537);
            this.Load += new System.EventHandler(this.usr_TonerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TonerList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PrintCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_TonerList;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Count;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cbx_Model_Search;
        private System.Windows.Forms.ComboBox cbx_BranchSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_BranchList;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Save_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_TonerModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.DateTimePicker dtp_LastDate;
        private System.Windows.Forms.DateTimePicker dtp_FirstDate;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_PrintCount;
        private System.Windows.Forms.CheckBox chk_AllTime;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

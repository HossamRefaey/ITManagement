﻿namespace Othaim_Management.Views
{
    partial class frm_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Status));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_StatusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StatusList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(323, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "عدد السجلات : 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 100);
            this.panel1.TabIndex = 29;
            // 
            // btn_New
            // 
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
            this.btn_New.Location = new System.Drawing.Point(364, 11);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(73, 80);
            this.btn_New.TabIndex = 19;
            this.btn_New.Text = "جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Refresh
            // 
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
            this.btn_Refresh.Location = new System.Drawing.Point(127, 11);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(73, 80);
            this.btn_Refresh.TabIndex = 22;
            this.btn_Refresh.Text = "تحديث";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Edit
            // 
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
            this.btn_Edit.Location = new System.Drawing.Point(285, 11);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(73, 80);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
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
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Delete.Location = new System.Drawing.Point(206, 11);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(73, 80);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_StatusList
            // 
            this.dgv_StatusList.AllowUserToAddRows = false;
            this.dgv_StatusList.AllowUserToResizeColumns = false;
            this.dgv_StatusList.AllowUserToResizeRows = false;
            this.dgv_StatusList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_StatusList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_StatusList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_StatusList.ColumnHeadersHeight = 30;
            this.dgv_StatusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_StatusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_StatusList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_StatusList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_StatusList.Location = new System.Drawing.Point(-1, 100);
            this.dgv_StatusList.MultiSelect = false;
            this.dgv_StatusList.Name = "dgv_StatusList";
            this.dgv_StatusList.ReadOnly = true;
            this.dgv_StatusList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_StatusList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_StatusList.RowHeadersVisible = false;
            this.dgv_StatusList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_StatusList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_StatusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StatusList.Size = new System.Drawing.Size(446, 274);
            this.dgv_StatusList.TabIndex = 28;
            this.dgv_StatusList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_StatusList_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.28572F;
            this.Column1.HeaderText = "مسلسل";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 169.7143F;
            this.Column2.HeaderText = "الحالة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 220;
            // 
            // frm_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_StatusList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frm_Status.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Status";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاشة حالة الجهاز";
            this.Load += new System.EventHandler(this.frm_Status_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StatusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private System.Windows.Forms.DataGridView dgv_StatusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
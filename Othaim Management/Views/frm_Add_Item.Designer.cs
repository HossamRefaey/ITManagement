namespace Othaim_Management.Views
{
    partial class frm_Add_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ItemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ItemList
            // 
            this.dgv_ItemList.AllowUserToAddRows = false;
            this.dgv_ItemList.AllowUserToResizeRows = false;
            this.dgv_ItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column6});
            this.dgv_ItemList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ItemList.Location = new System.Drawing.Point(6, 76);
            this.dgv_ItemList.MultiSelect = false;
            this.dgv_ItemList.Name = "dgv_ItemList";
            this.dgv_ItemList.ReadOnly = true;
            this.dgv_ItemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_ItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ItemList.RowHeadersVisible = false;
            this.dgv_ItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ItemList.Size = new System.Drawing.Size(714, 248);
            this.dgv_ItemList.TabIndex = 8;
            this.dgv_ItemList.SelectionChanged += new System.EventHandler(this.dgv_ItemList_SelectionChanged);
            this.dgv_ItemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ItemList_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.28572F;
            this.Column1.HeaderText = "NO.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 169.7143F;
            this.Column2.HeaderText = "Serial";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Model";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Notes";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Refresh);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.dgv_ItemList);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(784, 344);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيانات";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(560, 21);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.Size = new System.Drawing.Size(56, 35);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(684, 21);
            this.btn_New.Name = "btn_New";
            this.btn_New.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_New.Size = new System.Drawing.Size(56, 35);
            this.btn_New.TabIndex = 25;
            this.btn_New.Text = "جديد";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click_1);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(622, 21);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Edit.Size = new System.Drawing.Size(56, 35);
            this.btn_Edit.TabIndex = 24;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(414, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Search.Size = new System.Drawing.Size(56, 35);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(211, 21);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Search.Size = new System.Drawing.Size(197, 21);
            this.txt_Search.TabIndex = 22;
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(498, 21);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Refresh.Size = new System.Drawing.Size(56, 35);
            this.btn_Refresh.TabIndex = 27;
            this.btn_Refresh.Text = "تحديث";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Add_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Item";
            this.Load += new System.EventHandler(this.frm_Add_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ItemList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
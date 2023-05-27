namespace Othaim_Management.Views
{
    partial class frm_DevModel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.txt_ItemSysCode = new System.Windows.Forms.TextBox();
            this.cbx_DevType = new System.Windows.Forms.ComboBox();
            this.cbx_Category = new System.Windows.Forms.ComboBox();
            this.dgv_DevModelList = new System.Windows.Forms.DataGridView();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DevModelList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(12, 12);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(314, 27);
            this.txt_ItemName.TabIndex = 8;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADD.Location = new System.Drawing.Point(11, 191);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(75, 35);
            this.btn_ADD.TabIndex = 7;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // txt_ItemSysCode
            // 
            this.txt_ItemSysCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemSysCode.Location = new System.Drawing.Point(12, 61);
            this.txt_ItemSysCode.Name = "txt_ItemSysCode";
            this.txt_ItemSysCode.Size = new System.Drawing.Size(314, 27);
            this.txt_ItemSysCode.TabIndex = 10;
            // 
            // cbx_DevType
            // 
            this.cbx_DevType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DevType.FormattingEnabled = true;
            this.cbx_DevType.Location = new System.Drawing.Point(11, 145);
            this.cbx_DevType.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_DevType.Name = "cbx_DevType";
            this.cbx_DevType.Size = new System.Drawing.Size(317, 27);
            this.cbx_DevType.TabIndex = 12;
            // 
            // cbx_Category
            // 
            this.cbx_Category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Category.FormattingEnabled = true;
            this.cbx_Category.Location = new System.Drawing.Point(11, 102);
            this.cbx_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(317, 27);
            this.cbx_Category.TabIndex = 13;
            this.cbx_Category.SelectedIndexChanged += new System.EventHandler(this.cbx_Category_SelectedIndexChanged);
            // 
            // dgv_DevModelList
            // 
            this.dgv_DevModelList.AllowUserToAddRows = false;
            this.dgv_DevModelList.AllowUserToResizeRows = false;
            this.dgv_DevModelList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DevModelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DevModelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DevModelList.ColumnHeadersHeight = 30;
            this.dgv_DevModelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DevModelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1});
            this.dgv_DevModelList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_DevModelList.Location = new System.Drawing.Point(348, 12);
            this.dgv_DevModelList.MultiSelect = false;
            this.dgv_DevModelList.Name = "dgv_DevModelList";
            this.dgv_DevModelList.ReadOnly = true;
            this.dgv_DevModelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DevModelList.RowHeadersVisible = false;
            this.dgv_DevModelList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DevModelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DevModelList.Size = new System.Drawing.Size(450, 228);
            this.dgv_DevModelList.TabIndex = 14;
            this.dgv_DevModelList.SelectionChanged += new System.EventHandler(this.dgv_DevModelList_SelectionChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(92, 191);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 35);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(173, 191);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30.28572F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 169.7143F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dev Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // frm_DevModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 424);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_DevModelList);
            this.Controls.Add(this.cbx_Category);
            this.Controls.Add(this.cbx_DevType);
            this.Controls.Add(this.txt_ItemSysCode);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.btn_ADD);
            this.Name = "frm_DevModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DevModel";
            this.Load += new System.EventHandler(this.frm_DevModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DevModelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.TextBox txt_ItemSysCode;
        private System.Windows.Forms.ComboBox cbx_DevType;
        private System.Windows.Forms.ComboBox cbx_Category;
        private System.Windows.Forms.DataGridView dgv_DevModelList;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
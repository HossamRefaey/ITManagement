namespace Othaim_Management.Views
{
    partial class frm_Branch
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cbx_AreaMgr = new System.Windows.Forms.ComboBox();
            this.cbx_Users = new System.Windows.Forms.ComboBox();
            this.dgv_BranchList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(61, 214);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(83, 37);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(61, 63);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(140, 25);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(61, 24);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(140, 25);
            this.txt_ID.TabIndex = 0;
            // 
            // cbx_AreaMgr
            // 
            this.cbx_AreaMgr.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_AreaMgr.FormattingEnabled = true;
            this.cbx_AreaMgr.Location = new System.Drawing.Point(61, 110);
            this.cbx_AreaMgr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_AreaMgr.Name = "cbx_AreaMgr";
            this.cbx_AreaMgr.Size = new System.Drawing.Size(140, 26);
            this.cbx_AreaMgr.TabIndex = 2;
            // 
            // cbx_Users
            // 
            this.cbx_Users.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Users.FormattingEnabled = true;
            this.cbx_Users.Location = new System.Drawing.Point(61, 148);
            this.cbx_Users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Users.Name = "cbx_Users";
            this.cbx_Users.Size = new System.Drawing.Size(140, 26);
            this.cbx_Users.TabIndex = 3;
            // 
            // dgv_BranchList
            // 
            this.dgv_BranchList.AllowUserToAddRows = false;
            this.dgv_BranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BranchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_BranchList.Location = new System.Drawing.Point(254, 24);
            this.dgv_BranchList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_BranchList.Name = "dgv_BranchList";
            this.dgv_BranchList.ReadOnly = true;
            this.dgv_BranchList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_BranchList.RowTemplate.Height = 29;
            this.dgv_BranchList.Size = new System.Drawing.Size(470, 330);
            this.dgv_BranchList.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frm_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 388);
            this.Controls.Add(this.dgv_BranchList);
            this.Controls.Add(this.cbx_Users);
            this.Controls.Add(this.cbx_AreaMgr);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Add);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Branch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Branch";
            this.Load += new System.EventHandler(this.frm_Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BranchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cbx_AreaMgr;
        private System.Windows.Forms.ComboBox cbx_Users;
        private System.Windows.Forms.DataGridView dgv_BranchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
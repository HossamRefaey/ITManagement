namespace Othaim_Management.Report
{
    partial class frm_Dispose_rpt
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_Dispose = new Othaim_Management.Report.ds_Dispose();
            this.DisposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Dispose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisposeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DisposeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Othaim_Management.Report.rpt_Dispose.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(578, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds_Dispose
            // 
            this.ds_Dispose.DataSetName = "ds_Dispose";
            this.ds_Dispose.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DisposeBindingSource
            // 
            this.DisposeBindingSource.DataMember = "Dispose";
            this.DisposeBindingSource.DataSource = this.ds_Dispose;
            // 
            // frm_Dispose_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Dispose_rpt";
            this.Text = "frm_Dispose_rpt";
            this.Load += new System.EventHandler(this.frm_Dispose_rpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Dispose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisposeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DisposeBindingSource;
        private ds_Dispose ds_Dispose;
    }
}
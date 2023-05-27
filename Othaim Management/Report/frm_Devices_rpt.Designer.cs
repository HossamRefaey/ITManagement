namespace Othaim_Management.Report
{
    partial class frm_Devices_rpt
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
            this.ds_Devices = new Othaim_Management.Report.ds_Devices();
            this.DevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DevicesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Othaim_Management.Report.rpt_Devices.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 628);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds_Devices
            // 
            this.ds_Devices.DataSetName = "ds_Devices";
            this.ds_Devices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DevicesBindingSource
            // 
            this.DevicesBindingSource.DataMember = "Devices";
            this.DevicesBindingSource.DataSource = this.ds_Devices;
            // 
            // frm_Devices_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 628);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Devices_rpt";
            this.ShowInTaskbar = false;
            this.Text = "frm_Devices";
            this.Load += new System.EventHandler(this.frm_Devices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DevicesBindingSource;
        private ds_Devices ds_Devices;
    }
}
namespace damminhnhat
{
    partial class In1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In1));
            this.chinhsachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSV1DataSet = new damminhnhat.QLSV1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chinhsachTableAdapter = new damminhnhat.QLSV1DataSetTableAdapters.chinhsachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSV1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chinhsachBindingSource
            // 
            this.chinhsachBindingSource.DataMember = "chinhsach";
            this.chinhsachBindingSource.DataSource = this.QLSV1DataSet;
            // 
            // QLSV1DataSet
            // 
            this.QLSV1DataSet.DataSetName = "QLSV1DataSet";
            this.QLSV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chinhsachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(977, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // chinhsachTableAdapter
            // 
            this.chinhsachTableAdapter.ClearBeforeFill = true;
            // 
            // In1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 253);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "In1";
            this.Text = "Nhóm 9: nhom9@gmail.com";
            this.Load += new System.EventHandler(this.In1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSV1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chinhsachBindingSource;
        private QLSV1DataSet QLSV1DataSet;
        private QLSV1DataSetTableAdapters.chinhsachTableAdapter chinhsachTableAdapter;
    }
}
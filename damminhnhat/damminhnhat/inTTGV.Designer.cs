namespace damminhnhat
{
    partial class inTTGV
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
            this.ttgiaovienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhqlsv1DataSet1 = new damminhnhat.thanhqlsv1DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ttgiaovienTableAdapter = new damminhnhat.thanhqlsv1DataSet1TableAdapters.ttgiaovienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ttgiaovienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ttgiaovienBindingSource
            // 
            this.ttgiaovienBindingSource.DataMember = "ttgiaovien";
            this.ttgiaovienBindingSource.DataSource = this.thanhqlsv1DataSet1;
            // 
            // thanhqlsv1DataSet1
            // 
            this.thanhqlsv1DataSet1.DataSetName = "thanhqlsv1DataSet1";
            this.thanhqlsv1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ttgiaovienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.FormInTTGiaoVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(826, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // ttgiaovienTableAdapter
            // 
            this.ttgiaovienTableAdapter.ClearBeforeFill = true;
            // 
            // inTTGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 472);
            this.Controls.Add(this.reportViewer1);
            this.Name = "inTTGV";
            this.Text = "Thông Tin Giáo Viên";
            this.Load += new System.EventHandler(this.inTTGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ttgiaovienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ttgiaovienBindingSource;
        private thanhqlsv1DataSet1 thanhqlsv1DataSet1;
        private thanhqlsv1DataSet1TableAdapters.ttgiaovienTableAdapter ttgiaovienTableAdapter;
    }
}
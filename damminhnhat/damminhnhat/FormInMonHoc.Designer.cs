namespace damminhnhat
{
    partial class FormInMonHoc
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
            this.thanhqlsv1DataSet4 = new damminhnhat.thanhqlsv1DataSet4();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocTableAdapter = new damminhnhat.thanhqlsv1DataSet4TableAdapters.monhocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.monhocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.InTTMonHoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(667, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // thanhqlsv1DataSet4
            // 
            this.thanhqlsv1DataSet4.DataSetName = "thanhqlsv1DataSet4";
            this.thanhqlsv1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "monhoc";
            this.monhocBindingSource.DataSource = this.thanhqlsv1DataSet4;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // FormInMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 472);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInMonHoc";
            this.Text = "Thông Tin Môn Học";
            this.Load += new System.EventHandler(this.FormInMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private thanhqlsv1DataSet4 thanhqlsv1DataSet4;
        private thanhqlsv1DataSet4TableAdapters.monhocTableAdapter monhocTableAdapter;
    }
}
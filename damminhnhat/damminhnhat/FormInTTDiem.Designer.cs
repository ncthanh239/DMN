namespace damminhnhat
{
    partial class FormInTTDiem
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
            this.thanhqlsv1DataSet6 = new damminhnhat.thanhqlsv1DataSet6();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter = new damminhnhat.thanhqlsv1DataSet6TableAdapters.diemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.diemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.InTTDiem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(705, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // thanhqlsv1DataSet6
            // 
            this.thanhqlsv1DataSet6.DataSetName = "thanhqlsv1DataSet6";
            this.thanhqlsv1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "diem";
            this.diemBindingSource.DataSource = this.thanhqlsv1DataSet6;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // FormInTTDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInTTDiem";
            this.Text = "Thông Tin Điểm";
            this.Load += new System.EventHandler(this.FormInTTDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private thanhqlsv1DataSet6 thanhqlsv1DataSet6;
        private thanhqlsv1DataSet6TableAdapters.diemTableAdapter diemTableAdapter;
    }
}
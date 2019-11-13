namespace damminhnhat
{
    partial class FormInTTCS
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
            this.thanhqlsv1DataSet5 = new damminhnhat.thanhqlsv1DataSet5();
            this.chinhsachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chinhsachTableAdapter = new damminhnhat.thanhqlsv1DataSet5TableAdapters.chinhsachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chinhsachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.InTTCS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 10);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(612, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // thanhqlsv1DataSet5
            // 
            this.thanhqlsv1DataSet5.DataSetName = "thanhqlsv1DataSet5";
            this.thanhqlsv1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhsachBindingSource
            // 
            this.chinhsachBindingSource.DataMember = "chinhsach";
            this.chinhsachBindingSource.DataSource = this.thanhqlsv1DataSet5;
            // 
            // chinhsachTableAdapter
            // 
            this.chinhsachTableAdapter.ClearBeforeFill = true;
            // 
            // FormInTTCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 469);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInTTCS";
            this.Text = "Thông Tin Chính Sách";
            this.Load += new System.EventHandler(this.FormInTTCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhsachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource chinhsachBindingSource;
        private thanhqlsv1DataSet5 thanhqlsv1DataSet5;
        private thanhqlsv1DataSet5TableAdapters.chinhsachTableAdapter chinhsachTableAdapter;
    }
}
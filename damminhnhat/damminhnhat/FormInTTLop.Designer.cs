namespace damminhnhat
{
    partial class FormInTTLop
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
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhqlsv1DataSet2 = new damminhnhat.thanhqlsv1DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lopTableAdapter = new damminhnhat.thanhqlsv1DataSet2TableAdapters.lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.thanhqlsv1DataSet2;
            // 
            // thanhqlsv1DataSet2
            // 
            this.thanhqlsv1DataSet2.DataSetName = "thanhqlsv1DataSet2";
            this.thanhqlsv1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "damminhnhat.inTTLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // FormInTTLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 429);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInTTLop";
            this.Text = "Thông Tin Lớp";
            this.Load += new System.EventHandler(this.FormInTTLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhqlsv1DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private thanhqlsv1DataSet2 thanhqlsv1DataSet2;
        private thanhqlsv1DataSet2TableAdapters.lopTableAdapter lopTableAdapter;
    }
}
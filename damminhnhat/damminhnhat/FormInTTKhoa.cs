using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace damminhnhat
{
    public partial class FormInTTKhoa : Form
    {
        public FormInTTKhoa()
        {
            InitializeComponent();
        }

        private void FormInTTKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thanhqlsv1DataSet.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.thanhqlsv1DataSet.khoa);
            
            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat
{
    public partial class InKhoa : Form
    {
        public InKhoa()
        {
            InitializeComponent();
        }

        private void InKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.QLSV1DataSet.khoa);

            this.reportViewer1.RefreshReport();
        }
    }
}

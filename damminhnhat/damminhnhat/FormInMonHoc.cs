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
    public partial class FormInMonHoc : Form
    {
        public FormInMonHoc()
        {
            InitializeComponent();
        }

        private void FormInMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thanhqlsv1DataSet4.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.thanhqlsv1DataSet4.monhoc);

            this.reportViewer1.RefreshReport();
        }
    }
}

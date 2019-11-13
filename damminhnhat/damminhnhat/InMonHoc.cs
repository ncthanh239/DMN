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
    public partial class InMonHoc : Form
    {
        public InMonHoc()
        {
            InitializeComponent();
        }

        private void InMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.monhoc' table. You can move, or remove it, as needed.
            this.monhocTableAdapter.Fill(this.QLSV1DataSet.monhoc);

            this.reportViewer1.RefreshReport();
        }
    }
}

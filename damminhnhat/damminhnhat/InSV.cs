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
    public partial class InSV : Form
    {
        public InSV()
        {
            InitializeComponent();
        }

        private void InSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.QLSV1DataSet.sinhvien);

            this.reportViewer1.RefreshReport();
        }
    }
}

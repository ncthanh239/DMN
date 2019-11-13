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
    public partial class InGV : Form
    {
        public InGV()
        {
            InitializeComponent();
        }

        private void InGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.giaovien' table. You can move, or remove it, as needed.
            this.giaovienTableAdapter.Fill(this.QLSV1DataSet.giaovien);

            this.reportViewer1.RefreshReport();
        }
    }
}

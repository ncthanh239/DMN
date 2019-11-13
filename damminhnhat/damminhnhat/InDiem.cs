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
    public partial class InDiem : Form
    {
        public InDiem()
        {
            InitializeComponent();
        }

        private void InDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.QLSV1DataSet.diem);

            this.reportViewer1.RefreshReport();
        }
    }
}

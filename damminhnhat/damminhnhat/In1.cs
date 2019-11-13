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
    public partial class In1 : Form
    {
        public In1()
        {
            InitializeComponent();
        }

        private void In1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSV1DataSet.chinhsach' table. You can move, or remove it, as needed.
            this.chinhsachTableAdapter.Fill(this.QLSV1DataSet.chinhsach);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class FormInTTLop : Form
    {
        public FormInTTLop()
        {
            InitializeComponent();
        }

        private void FormInTTLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thanhqlsv1DataSet2.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.thanhqlsv1DataSet2.lop);

            this.reportViewer1.RefreshReport();
        }
    }
}

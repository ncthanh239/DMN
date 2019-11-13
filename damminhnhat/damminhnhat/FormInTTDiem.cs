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
    public partial class FormInTTDiem : Form
    {
        public FormInTTDiem()
        {
            InitializeComponent();
        }

        private void FormInTTDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thanhqlsv1DataSet6.diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.thanhqlsv1DataSet6.diem);

            this.reportViewer1.RefreshReport();
        }
    }
}

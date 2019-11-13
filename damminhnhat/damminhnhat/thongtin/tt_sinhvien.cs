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
    public partial class tt_sinhvien : Form
    {
        public tt_sinhvien()
        {
            InitializeComponent();
        }

        private void tt_sinhvien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from sinhvien");
            comboBox2.DataSource = KetNoiCSDL.Index("select macs from chinhsach");
            comboBox2.DisplayMember = "macs";
            comboBox3.DataSource = KetNoiCSDL.Index("select malop from lop");
            comboBox3.DisplayMember = "malop";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInTTSV tt = new FormInTTSV();
            tt.Show();
        }
    }
}

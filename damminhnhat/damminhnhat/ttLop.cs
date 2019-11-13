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
    public partial class ttLop : Form
    {
        public ttLop()
        {
            InitializeComponent();
        }

        private void ttLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from lop");
            comboBox1.DataSource = KetNoiCSDL.Index("select makhoa from khoa");
            comboBox1.DisplayMember = "makhoa";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInTTLop tt = new FormInTTLop();
            tt.Show();
        }
    }
}

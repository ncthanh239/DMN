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
    public partial class ttMonHoc : Form
    {
        public ttMonHoc()
        {
            InitializeComponent();
        }

        private void ttMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from monhoc");
            comboBox1.DataSource = KetNoiCSDL.Index("select magv from ttgiaovien");
            comboBox1.DisplayMember = "magv";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInMonHoc tt = new FormInMonHoc();
            tt.Show();
        }
    }
}

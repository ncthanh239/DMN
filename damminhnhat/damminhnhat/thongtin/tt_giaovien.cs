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
    public partial class tt_giaovien : Form
    {
        public tt_giaovien()
        {
            InitializeComponent();
        }

        private void tt_giaovien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from ttgiaovien");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            }
            catch (Exception ex)
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inTTGV tt = new inTTGV();
            tt.Show();
        }
    }
}

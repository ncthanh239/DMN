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
    public partial class ttChinhSach : Form
    {
        public ttChinhSach()
        {
            InitializeComponent();
        }

        private void ttChinhSach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from chinhsach");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInTTCS tt = new FormInTTCS();
            tt.Show();
        }
    }
}

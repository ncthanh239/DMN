using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat.Search
{
    public partial class tk_chinhsach : Form
    {
        public tk_chinhsach()
        {
            InitializeComponent();
        }
        void load()
        {
            string sql = "select * from chinhsach";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            dataGridView1.Columns[0].HeaderText = "Mã chính sách";
            dataGridView1.Columns[2].HeaderText = "Tên chính sách";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            textBox1.ResetText();
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ tìm kiếm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phương thức tìm kiếm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql1 = "select count(*) from chinhsach where tencs like '%" + textBox1.Text + "%'";
                string sql2 = "select count(*) from chinhsach where macs like '%" + textBox1.Text.Trim() + "%'";
                int i = KetNoiCSDL.count(sql1);
                int i1 = KetNoiCSDL.count(sql2);
                if ((i1 != 0) && comboBox1.Text.Equals("Mã chính sách"))
                {
                    string sql3 = "select * from chinhsach where macs like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                }
                else if ((i != 0) && comboBox1.Text.Equals("Tên chính sách"))
                {
                    string sql3 = "select * from chinhsach where tencs like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                }

                else
                {
                    MessageBox.Show("Không tìm thấy chính sách!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

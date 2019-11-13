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
    public partial class qlttLop : Form
    {
        public qlttLop()
        {
            InitializeComponent();
        }

        private void qlttLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from lop");
            comboBox1.DataSource = KetNoiCSDL.Index("select makhoa from khoa");
            comboBox1.DisplayMember = "makhoa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from lop where malop ='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Tên Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i != 0)
                {
                    MessageBox.Show("Mã Lớp Đã Được Sử Dụng. Vui Lòng Sử Dụng Tên Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.ResetText();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "insert into lop values('" + textBox1.Text + "', N'" + textBox2.Text + "', N'"+comboBox1.Text+"')";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from lop");
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from lop where malop='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("Mã lớp Không Thay Đổi Được! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update lop set tenlop = N'" + textBox2.Text + "', makhoa = '"+comboBox1.Text+"' where malop = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from lop");
                    MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = "delete from lop where malop = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from lop");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

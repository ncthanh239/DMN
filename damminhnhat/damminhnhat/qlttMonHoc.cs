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
    public partial class qlttMonHoc : Form
    {
        public qlttMonHoc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void qlttMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from monhoc");
            comboBox1.DataSource = KetNoiCSDL.Index("select magv from ttgiaovien");
            comboBox1.DisplayMember = "magv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from monhoc where mamh ='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Tên Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i != 0)
                {
                    MessageBox.Show("Mã Môn Học Đã Được Sử Dụng. Vui Lòng Sử Dụng Tên Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.ResetText();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "insert into monhoc values('" + textBox1.Text + "', N'" + textBox2.Text + "','"+textBox3.Text+"', N'" + comboBox1.Text + "')";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from monhoc");
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, " ^ [0-9]"))
            {
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from monhoc where mamh='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("Mã môn học Không Thay Đổi Được! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.ResetText();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update monhoc set tenmh = N'" + textBox2.Text + "',sotiet = '"+textBox3.Text+"', magv = '" + comboBox1.Text + "' where mamh = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from monhoc");
                    MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = "delete from monhoc where mamh = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from monhoc");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.ResetText();
                textBox1.Focus();




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class qlttGiaoVien : Form
    {
        public qlttGiaoVien()
        {
            InitializeComponent();
        }

        private void qlttGiaoVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from ttgiaovien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsa = "select count(*) from ttgiaovien where magv='" + textBox1.Text + "'";
                if (textBox1.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Mã Giáo Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox2.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Tên Giáo Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBox1.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Chọn Giới Tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dateTimePicker1.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Ngày Sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox4.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox5.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Số Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int i = (int)KetNoiCSDL.count(sqlsa);
                    if (i != 0)
                    {
                        MessageBox.Show("Mã Giáo Viên Đã Được Sử Dụng. Vui Lòng Sử Dụng Tên Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                        textBox2.Clear();
                        
                        textBox4.Clear();
                        textBox5.Clear();
                        
                        textBox1.Focus();
                    }
                    else
                    {

                        string sql = "insert into ttgiaovien values('" + textBox1.Text + "', N'" + textBox2.Text + "', N'"+comboBox1.SelectedItem.ToString()+"', '"+dateTimePicker1.Value.ToString()+"', '"+textBox4.Text+"', N'"+textBox5.Text+"')";
                        KetNoiCSDL.themsuaxoa(sql);
                        dataGridView1.DataSource = KetNoiCSDL.Index("select * from ttgiaovien");
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception l)
            {

                MessageBox.Show(""+l);
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, " ^ [0-9]"))
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from ttgiaovien where magv='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Giáo Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Tên Giáo Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Chọn Giới Tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateTimePicker1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Ngày Sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox4.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox5.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("Mã Giáo Viên Không Thay Đổi Được! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox4.Clear();
                    textBox5.Clear();
                    comboBox1.ResetText();
                    dateTimePicker1.ResetText();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update ttgiaovien set tengv = N'" + textBox2.Text + "', gioitinh = N'"+comboBox1.SelectedItem.ToString()+"', ngaysinh = '"+dateTimePicker1.Value.ToString()+"', sdt = '"+textBox4.Text+"', diachi = N'"+textBox5.Text+"'  where magv = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from ttgiaovien");
                    MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = "delete from ttgiaovien where magv = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from ttgiaovien");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();

                textBox4.Clear();
                textBox5.Clear();
                comboBox1.ResetText();
                dateTimePicker1.ResetText();
                textBox1.Focus();




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox4.Clear();
            textBox5.Clear();
            comboBox1.ResetText();
            dateTimePicker1.ResetText();
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class quanlyTruongKhoa : Form
    {
        public quanlyTruongKhoa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            
           
        }

        private void quanlyTruongKhoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from tktk");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from tktk where tk='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Người Dùng!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i != 0)
                {
                    MessageBox.Show("Tài Khoản Đã Được Đăng Ký. Vui Lòng Sử Dụng Tên Khác! ", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "insert into tktk values('" + textBox1.Text + "', '" + textBox2.Text + "')";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from tktk");
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from tktk where tk='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Người Dùng!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("Tên tài khoản không thay đổi được! ", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update tktk set mk = '" + textBox2.Text + "' where tk = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from tktk");
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

                string sql = "delete from tktk where tk = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from tktk");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
        }
    }
}

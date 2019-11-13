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
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = textBox2.Text;
                string repass = textBox3.Text;
                if (pass.Equals(repass))
                {
                    string sql = "select count(*) from tkuser where tk=N'" + textBox1.Text + "'";
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

                        int i = (int)KetNoiCSDL.count(sql);
                        if (i != 0)
                        {
                            MessageBox.Show("Tài Khoản Đã Được Đăng Ký. Vui Lòng Sử Dụng Tên Khác! ", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox1.Focus();
                        }
                        else
                        {
                            string them = "insert into tkuser values(N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
                            KetNoiCSDL.themsuaxoa(them);
                            MessageBox.Show("Đăng Ký Thành Công. Bạn Có Muốn Đăng Nhập Không?", "Đăng Ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            main f = new main(0);
                            f.Show();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Mật Khẩu Bạn Nhập Không Khớp! Bạn Vui Lòng Kiểm Tra Lại!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao Tác Không Thực Hiện Được! Vui Lòng Kiểm Tra Lại!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dangky_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}

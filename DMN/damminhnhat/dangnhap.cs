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
    public partial class dangnhap : Form
    {
        int sai = 5;
        int tk = 0;
        String kt = "";
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBox1.Text;
                string pass = textBox2.Text;
                if (user.Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Tên Đăng Nhập", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.textBox1.Clear();
                    this.textBox1.Focus();
                }
                else if (pass.Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.textBox2.Clear();
                    this.textBox2.Focus();
                }
                else
                {
                    String sv = "select count(*) from tkuser where tk = N'" + textBox1.Text + "' and mk=N'" + textBox2.Text + "'";
                    int i = KetNoiCSDL.count(sv);
                    String ad = "select count(*) from tkad where tk = N'" + textBox1.Text + "' and mk=N'" + textBox2.Text + "'";
                    int i1 = KetNoiCSDL.count(ad);
                    String gv = "select count(*) from tkgv where tk = N'" + textBox1.Text + "' and mk=N'" + textBox2.Text + "'";
                    int i2 = KetNoiCSDL.count(gv);
                    String tk = "select count(*) from tktk where tk = N'" + textBox1.Text + "' and mk=N'" + textBox2.Text + "'";
                    int i3 = KetNoiCSDL.count(tk);
                    if (sai > 0)
                    {
                        if (i != 0)
                        {
                            this.Close();
                            MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản User!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main Main_chinh = new main(0);
                            Main_chinh.Show();
                        }
                        else if (i1 != 0)
                        {
                            this.Close();
                            MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Admin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main Main_chinh = new main(1);
                            Main_chinh.Show();
                        }
                        else if (i2 != 0)
                        {
                            this.Close();
                            MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Giáo Viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main Main_chinh = new main(2);
                            Main_chinh.Show();
                        }
                        else if (i3 != 0)
                        {
                            this.Close();
                            MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Trưởng Khoa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main Main_chinh = new main(3);
                            Main_chinh.Show();
                        }
                        else
                        {
                            sai = sai - 1;
                            MessageBox.Show("Username Hoặc Password Sai! Bạn Còn " + sai + " Lần Đăng Nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.textBox1.Clear();
                            this.textBox2.Clear();
                            this.textBox1.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã Hết Lượt Truy Cập, Mời Bạn Đăng Nhập Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Form1 f = new Form1();
                        f.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra. Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
              
        }

        private void dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}

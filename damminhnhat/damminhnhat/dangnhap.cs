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
       
        public dangnhap()
        {
            InitializeComponent();
        }
        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private String getMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
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
                    string txt = getMD5(textBox2.Text);
                    String sv = "select count(*) from tkad where tk = N'" + textBox1.Text + "' and mk=N'" + txt + "'";
                    String sv1 = "select * from tkad where tk = N'" + textBox1.Text + "' ";
                    int i = KetNoiCSDL.count(sv);
                    if (sai > 0)
                    {
                        if (i != 0)
                        {
                            DataTable tb = KetNoiCSDL.laybang(sv1);
                            String ten = tb.Rows[0][0].ToString();
                            String status = tb.Rows[0][2].ToString();
                            if (status.Equals("Admin"))
                            {
                                this.Close();
                                MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Admin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main Main_chinh = new main(1,ten);
                                Main_chinh.Show();
                            }
                            else if (status.Equals("User"))
                            {

                                this.Close();
                                MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản User!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main Main_chinh = new main(0,ten);
                                Main_chinh.Show();
                            }
                            else if (status.Equals("Giáo viên"))
                            {

                                this.Close();
                                MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Giáo viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main Main_chinh = new main(3,ten);
                                Main_chinh.Show();
                            }
                            else
                            {

                                this.Close();
                                MessageBox.Show("Bạn Đã Đăng Nhập Vào Tài Khoản Trưởng khoa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main Main_chinh = new main(2,ten);
                                Main_chinh.Show();
                            }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat.hethong
{
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để đổi mật khẩu!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string txt = getMD5(textBox2.Text);
                    string sqlad = "select count(*) from tkad where tk = '" + textBox1.Text + "' and mk ='" + txt + "'";
                    int i = (int)KetNoiCSDL.count(sqlad);

                    if (i != 0)
                    {
                        if (textBox3.Text == textBox4.Text)
                        {
                            string sql = "update tkad set mk= '" + getMD5(textBox3.Text) + "' where tk ='" + textBox1.Text + "' ";
                            KetNoiCSDL.themsuaxoa(sql);
                            MessageBox.Show("Đổi mật khẩu thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Nhập lại sai mật khẩu!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

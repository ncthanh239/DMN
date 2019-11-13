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
    public partial class qlttSinhViencs : Form
    {
        public qlttSinhViencs()
        {
            InitializeComponent();
        }

        private void qlttSinhViencs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from sinhvien");
            comboBox2.DataSource = KetNoiCSDL.Index("select macs from chinhsach");
            comboBox2.DisplayMember = "macs";
            comboBox3.DataSource = KetNoiCSDL.Index("select malop from lop");
            comboBox3.DisplayMember = "malop";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsa = "select count(*) from sinhvien where masv='" + textBox1.Text + "'";
                if (textBox1.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Nhập Mã Sinh Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox2.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn Chưa Tên Sinh Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Mã Sinh Viên Đã Được Sử Dụng. Vui Lòng Sử Dụng Tên Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                        textBox2.Clear();

                        textBox4.Clear();
                        textBox5.Clear();

                        textBox1.Focus();
                        comboBox2.ResetText();
                        comboBox3.ResetText();
                        dateTimePicker1.ResetText();
                    }
                    else
                    {

                        string sql = "insert into sinhvien values('" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + comboBox1.Text + "', '" + dateTimePicker1.Value.ToString() + "', '" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + comboBox2.Text + "', N'" + comboBox3.Text + "')";
                        KetNoiCSDL.themsuaxoa(sql);
                        dataGridView1.DataSource = KetNoiCSDL.Index("select * from sinhvien");
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception l)
            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
                MessageBox.Show("" + l);
            }
           
        }
    }
}

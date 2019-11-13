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
    public partial class tkGiaoVien : Form
    {
        public tkGiaoVien()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {

            dataGridView1.DataSource = KetNoiCSDL.Index("Select * from ttgiaovien");
            dataGridView1.Columns[0].HeaderText = "Mã giáo viên";
            dataGridView1.Columns[1].HeaderText = "Tên giáo viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Sdt";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
        }

        private void tkGiaoVien_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Địa Chỉ");
            this.comboBox1.Items.Add("Tên Giáo Viên");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập từ khóa cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Mời bạn chọn cách cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sqlten = "Select count(*) from ttgiaovien where diachi like '%" + textBox1.Text + "%'";
                String sqlst = "Select count(*) from ttgiaovien where tengv like '%" + textBox1.Text + "%'";
                int i = (int)KetNoiCSDL.count(sqlten);
                int j = (int)KetNoiCSDL.count(sqlst);

                if ((i != 0) && comboBox1.Text.Equals("Địa Chỉ"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select magv[Mã giáo viên], tengv[Tên giáo viên], gioitinh[Giới tính], ngaysinh[Ngày sinh], sdt[Sdt], diachi[Địa chỉ] from ttgiaovien where diachi like '%" + textBox1.Text.Trim() + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.Index(kq);

                }
                else if ((j != 0) && comboBox1.Text.Equals("Tên Giáo Viên"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select magv[Mã giáo viên], tengv[Tên giáo viên], gioitinh[Giới tính], ngaysinh[Ngày sinh], sdt[Sdt], diachi[Địa chỉ] from ttgiaovien where tengv like '%" + textBox1.Text.Trim() + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.Index(kq);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            textBox1.Clear();
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class tkSinhVien : Form
    {
        public tkSinhVien()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("Select * from sinhvien");
            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Giới Tính";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[6].HeaderText = "Mã Chính Sách";
            dataGridView1.Columns[7].HeaderText = "Mã lớp";
        }

        private void tkSinhVien_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Tên Sinh Viên");
            this.comboBox1.Items.Add("Mã Sinh Viên");
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
                String sqlten = "Select count(*) from sinhvien where tensv like '%" + textBox1.Text + "%'";
                String sqlst = "Select count(*) from sinhvien where masv like '%" + textBox1.Text + "%'";
                int i = (int)KetNoiCSDL.count(sqlten);
                int j = (int)KetNoiCSDL.count(sqlst);

                if ((i != 0) && comboBox1.Text.Equals("Tên Sinh Viên"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select masv[Mã sinh viên], tensv[Tên sinh viên], gioitinh[Giới tính], ngaysinh[Ngày sinh], sdt[Sdt], diachi[Địa chỉ], macs[Mã chính sách], tenlop[Tên lớp] from sinhvien join lop on(sinhvien.malop=lop.malop) where tensv like '%" + textBox1.Text.Trim() + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.Index(kq);

                }
                else if ((j != 0) && comboBox1.Text.Equals("Mã Sinh Viên"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select masv[Mã sinh viên], tensv[Tên sinh viên], gioitinh[Giới tính], ngaysinh[Ngày sinh], sdt[Sdt], diachi[Địa chỉ], macs[Mã chính sách], tenlop[Tên lớp] from sinhvien join lop on(sinhvien.malop=lop.malop) where masv like '%" + textBox1.Text.Trim() + "%'";
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

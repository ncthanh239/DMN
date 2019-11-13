using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat.Search
{
    public partial class tk_giaovien : Form
    {
        public tk_giaovien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            string sql = "select * from giaovien";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            dataGridView1.Columns[0].HeaderText = "Mã giáo viên";
            dataGridView1.Columns[1].HeaderText = "Tên giáo viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Số điện thoại";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Load();
            textBox1.ResetText();
            comboBox1.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ tìm kiếm!",  "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phương thức tìm kiếm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql1 = "select count(*) from giaovien where diachi like '%" + textBox1.Text + "%'";
                string sql2 = "select count(*) from giaovien where tengv like '%" + textBox1.Text + "%'";
                int i = KetNoiCSDL.count(sql1);
                int i1 = KetNoiCSDL.count(sql2);
                if ((i != 0) && comboBox1.Text.Equals("Địa chỉ"))
                {
                    string sql3 = "select * from giaovien where diachi like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                }
                else if ((i1 != 0) && comboBox1.Text.Equals("Tên giáo viên"))
                {
                    string sql3 = "select * from giaovien where tengv like '%" + textBox1.Text + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giáo viên!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class tkLop : Form
    {
        public tkLop()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("Select malop,tenlop,tenkhoa from lop join khoa on(lop.makhoa=khoa.makhoa)");
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Tên Khoa";
        }

        private void tkLop_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Tên Lớp");
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
                String sqlten = "Select count(*) from lop where tenlop like '%" + textBox1.Text + "%'";

                int i = (int)KetNoiCSDL.count(sqlten);


                if ((i != 0) && comboBox1.Text.Equals("Tên Lớp"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select malop[Mã lớp], tenlop[Tên Lớp], tenkhoa[Tên Khoa] from lop join khoa on(lop.makhoa=khoa.makhoa) where tenlop like N'%" + textBox1.Text.Trim() + "%'";
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
            comboBox1.Focus();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

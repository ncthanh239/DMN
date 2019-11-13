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
    public partial class tkChinhSach : Form
    {
        public tkChinhSach()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("Select * from chinhsach");
            dataGridView1.Columns[0].HeaderText = "Mã Chính Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Chính Sách";
            
        }

        private void tkChinhSach_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Tên Chính Sách");
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
                String sqlten = "Select count(*) from chinhsach where tencs like N'%" + textBox1.Text + "%'";

                int i = (int)KetNoiCSDL.count(sqlten);


                if ((i != 0) && comboBox1.Text.Equals("Tên Chính Sách"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select * from chinhsach where tencs like N'%" + textBox1.Text.Trim() + "%'";
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

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
    public partial class tkMonHoc : Form
    {
        public tkMonHoc()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
          
            dataGridView1.DataSource = KetNoiCSDL.Index("Select * from monhoc");
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tiết";
            dataGridView1.Columns[3].HeaderText = "Mã giáo viên";
        }

        private void tkMonHoc_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Tên Môn Học");
            this.comboBox1.Items.Add("Số Tiết");
           
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
                String sqlten = "Select count(*) from monhoc where tenmh like '%"+textBox1.Text+"%'";
                String sqlst = "Select count(*) from monhoc where sotiet like '%" + textBox1.Text + "%'";
                int i = (int)KetNoiCSDL.count(sqlten);
                int j = (int)KetNoiCSDL.count(sqlst);

                if ((i != 0) && comboBox1.Text.Equals("Tên Môn Học"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select mamh[Mã môn học], tenmh[Tên môn học], sotiet[Số tiết], tengv[Tên giáo viên] from monhoc join ttgiaovien on(monhoc.magv=ttgiaovien.magv) where tenmh like '%" + textBox1.Text.Trim() + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.Index(kq);
                    
                }
                else if ((j != 0) && comboBox1.Text.Equals("Số Tiết"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select mamh[Mã môn học], tenmh[Tên môn học], sotiet[Số tiết], tengv[Tên giáo viên] from monhoc join ttgiaovien on(monhoc.magv=ttgiaovien.magv) where sotiet like '%" + textBox1.Text.Trim() + "%'";
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class tk_monhoc : Form
    {
        public tk_monhoc()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string sql = "select mamh,tenmh, sotiet, tengv from monhoc join giaovien on(monhoc.magv = giaovien.magv)";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tiết";
            dataGridView1.Columns[3].HeaderText = "Tên giáo viên";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            textBox1.ResetText();
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ tìm kiếm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn phương thức tìm kiếm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql1 = "select count(*) from monhoc where sotiet like '%" + textBox1.Text + "%'" ;
                    string sql2 = "select count(*) from monhoc where tenmh like '%" + textBox1.Text + "%'";
                    int i = KetNoiCSDL.count(sql1);
                    int i1 = KetNoiCSDL.count(sql2);
                    if((i != 0) && comboBox1.Text.Equals("Số tiết"))
                    {
                        string sql3 = "select mamh,tenmh, sotiet, tengv from monhoc join giaovien on(monhoc.magv = giaovien.magv) where sotiet like '%" + textBox1.Text + "%'";
                        dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                    }
                     else if ((i1 != 0) && comboBox1.Text.Equals("Tên môn học"))
                    {
                        string sql3 = "select mamh,tenmh, sotiet, tengv from monhoc join giaovien on(monhoc.magv = giaovien.magv) where tenmh like '%" + textBox1.Text + "%'";
                        dataGridView1.DataSource = KetNoiCSDL.laybang(sql3);
                    }
                    else 
                    {
                        MessageBox.Show("Không tìm thấy môn học!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            
        }
    }
}

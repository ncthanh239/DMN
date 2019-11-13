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
    public partial class tt_khoa : Form
    {
        public tt_khoa()
        {
            InitializeComponent();
        }

        private void tt_khoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from khoa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from khoa where makhoa='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Tên Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i != 0)
                {
                    MessageBox.Show("Mã Khoa Đã Được Sử Dụng. Vui Lòng Sử Dụng Tên Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "insert into khoa values('" + textBox1.Text + "', N'" + textBox2.Text + "')";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from khoa");
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from khoa where makhoa='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("Mã Khoa Không Thay Đổi Được! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update khoa set tenkhoa = N'" + textBox2.Text + "' where makhoa = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from khoa");
                    MessageBox.Show("Update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = "delete from khoa where makhoa = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from khoa");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

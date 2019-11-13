using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat.Quanly
{
    public partial class ql_lop : Form
    {
        public ql_lop()
        {
            InitializeComponent();
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            comboBox1.SelectedIndex = 0;
        }
        void load()
        {
            string sql = "select *from lop";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            comboBox1.DataSource = KetNoiCSDL.laybang("select makhoa from khoa");
            comboBox1.DisplayMember = "makhoa";
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Mã Khoa";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
         
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from lop where malop = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "insert into lop values ('"+textBox1.Text+"',N'"+textBox2.Text+"','"+comboBox1.Text+"') ";
                        KetNoiCSDL.themsuaxoa(sql1);
                        MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();

                    }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from lop where malop = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã lớp!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update lop set tenlop=N'" + textBox2.Text + "', makhoa = '"+comboBox1.Text+"' where malop='" + textBox1.Text + "'";
                        KetNoiCSDL.themsuaxoa(sql1);
                        MessageBox.Show("Sửa thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE from lop where malop = '" + textBox1.Text + "'";
                        KetNoiCSDL.laybang(sql);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox1.Focus();
                        load();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Nhóm 9" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
         
        }
    }
}

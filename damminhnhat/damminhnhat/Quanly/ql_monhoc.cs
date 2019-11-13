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
    public partial class ql_monhoc : Form
    {
        public ql_monhoc()
        {
            InitializeComponent();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load()
        {
            string sql = "select * from monhoc";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            cb1.DataSource = KetNoiCSDL.laybang("select magv from giaovien");
            cb1.DisplayMember = "magv";
            dataGridView1.Columns[0].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[1].HeaderText = "Tên Môn Học";
            dataGridView1.Columns[2].HeaderText = "Số Tiết";
            dataGridView1.Columns[3].HeaderText = "Mã Giáo Viên";
            cb1.SelectedIndex = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select count(*) from monhoc where mamh = '" + textBox1.Text + "'";
                int i = KetNoiCSDL.count(sql);
                if (i > 0)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.ResetText();
                    textBox2.ResetText();
                    textBox3.ResetText();

                    textBox1.Focus();
                }
                else
                {
                    string sql1 = "insert into monhoc values ('" + textBox1.Text + "',N'" + textBox2.Text + "','"+textBox3.Text+"','" + cb1.Text + "') ";
                    KetNoiCSDL.themsuaxoa(sql1);
                    MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();

                }
            }
        }

        private void ql_monhoc_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || cb1.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from monhoc where mamh = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã môn học!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update monhoc set tenmh=N'" + textBox2.Text + "',sotiet = '"+textBox3.Text+"' , magv = '" + cb1.Text + "' where mamh='" + textBox1.Text + "'";
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
                        string sql = "DELETE from monhoc where mamh = '" + textBox1.Text + "'";
                        KetNoiCSDL.laybang(sql);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox3.ResetText();
                        textBox1.Focus();
                        load();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + e, "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            cb1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

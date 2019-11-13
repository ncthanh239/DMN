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
    public partial class ql_gv : Form
    {
        string b;
        public ql_gv()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string sql = "select * from giaovien";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            dataGridView1.Columns[0].HeaderText = "Mã giáo viên";
            dataGridView1.Columns[1].HeaderText = "Tên giáo viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Số điện thoại";
            dataGridView1.Columns[5].HeaderText = "Đại chỉ";
        }
        private void ql_gv_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox4.ResetText();
            textBox4.ResetText();
            dateTimePicker1.ResetText();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                string a = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                if (a.Equals("Nam"))
                {
                    radioButton1.Checked = true;
                }
                else if (a.Equals("Nữ"))
                {
                    radioButton2.Checked = true;
                }
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Value.ToString() == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from giaovien where magv = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Mã giáo viên đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox4.ResetText();
                        textBox4.ResetText();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        dateTimePicker1.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {
                        if (radioButton1.Checked == true)
                        {
                            b = "Nam";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            b = "Nữ";
                        }
                        string sql1 = "insert into giaovien values ('" + textBox1.Text + "', N'" + textBox2.Text + "',N'" + b + "','" + dateTimePicker1.Value.ToString() + "',N'" + textBox4.Text + "',N'" + textBox3.Text + "') ";
                        KetNoiCSDL.themsuaxoa(sql1);
                        MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Value.ToString() == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                         b = "Nam";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        b = "Nữ";
                    }
                    string sql = "select count(*) from giaovien where magv = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã giáo viên!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update giaovien set tengv=N'" + textBox2.Text + "',ngaysinh = '"+dateTimePicker1.Value.ToString()+"' ,gioitinh= N'"+b+"', sdt= '"+textBox4.Text+"', diachi = N'"+textBox3.Text+"' where magv='" + textBox1.Text + "'";
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Value.ToString() == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE from giaovien where magv = '" + textBox1.Text + "'";
                        KetNoiCSDL.laybang(sql);
                        load();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi", "Nhóm 9" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

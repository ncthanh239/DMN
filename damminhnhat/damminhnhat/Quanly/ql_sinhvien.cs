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
    public partial class ql_sinhvien : Form
    {
        string b;
        public ql_sinhvien()
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
            String sql = "SELECT * from sinhvien";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            comboBox1.DataSource = KetNoiCSDL.laybang("select macs from chinhsach");
            comboBox2.DataSource = KetNoiCSDL.laybang("select malop from lop");
            comboBox1.DisplayMember = "macs";
            comboBox2.DisplayMember = "malop";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Tên sinh viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Số điện thoại";
            dataGridView1.Columns[5].HeaderText = "Đại chỉ";
            dataGridView1.Columns[6].HeaderText = "Mã chính sách";
            dataGridView1.Columns[7].HeaderText = "Mã lớp";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            dateTimePicker1.ResetText();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    radioButton3.Checked = true;
                }
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
            }
            catch (Exception ex)
            { }
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
                    string sql = "select count(*) from sinhvien where masv = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox4.ResetText();
                        textBox4.ResetText();
                        dateTimePicker1.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {
                        if (radioButton1.Checked == true)
                        {
                            b = "Nam";
                        }
                        else if (radioButton3.Checked == true)
                        {
                            b = "Nữ";
                        }
                        string sql1 = "insert into sinhvien values ('" + textBox1.Text + "', N'" + textBox2.Text + "',N'"+b+"' ,'"+dateTimePicker1.Value.ToString()+"', '"+textBox3.Text+"',N'"+textBox4.Text+"', '"+comboBox1.Text+"', '"+comboBox2.Text+"') ";
                        KetNoiCSDL.themsuaxoa(sql1);
                        MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại"+ex, "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ql_sinhvien_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE from sinhvien where masv = '" + textBox1.Text + "'";
                        KetNoiCSDL.laybang(sql);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox3.ResetText();
                        textBox4.ResetText();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Value.ToString() == "" || comboBox1.Text =="" || comboBox2.Text =="")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        b = "Nam";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        b = "Nữ";
                    }
                    string sql = "select count(*) from sinhvien where masv = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã sinh viên!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update sinhvien set tensv=N'" + textBox2.Text + "', gioitinh= N'" + b + "', ngaysinh ='"+dateTimePicker1.Value.ToString()+"', sdt= '" + textBox3.Text + "', diachi = N'" + textBox4.Text + "' , macs ='"+comboBox1.Text+"', malop='"+comboBox2.Text+"' where masv='" + textBox1.Text + "'";
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

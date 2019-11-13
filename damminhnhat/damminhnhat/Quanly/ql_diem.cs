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
    public partial class ql_diem : Form
    {
        public ql_diem()
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
            string sql = "select * from diem";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            comboBox1.DataSource = KetNoiCSDL.laybang("select mamh from monhoc");
            comboBox2.DataSource = KetNoiCSDL.laybang("select masv from sinhvien");
            comboBox2.DisplayMember = "masv";
            comboBox1.DisplayMember = "mamh";
            dataGridView1.Columns[0].HeaderText = "Mã điểm";
            dataGridView1.Columns[1].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[2].HeaderText = "Mã môn học";
            dataGridView1.Columns[3].HeaderText = "Điểm";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
  
            textBox4.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE from diem where id = '" + textBox1.Text + "'";
                        KetNoiCSDL.laybang(sql);
                        textBox1.ResetText();
                        comboBox2.ResetText();
                        textBox1.Focus();
                        load();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Lỗi" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from diem where id = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã điểm!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update diem set masv=N'" + comboBox2.Text + "', mamh = '" + comboBox1.Text + "', diem='"+textBox4.Text+"' where id='" + textBox1.Text + "'";
                        KetNoiCSDL.themsuaxoa(sql1);
                        MessageBox.Show("Sửa thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string d = textBox4.Text;
                float diem;
               // bool ok = float.TryParse(d, out diem);
                if (textBox1.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || textBox4.Text=="")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from diem where id = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Trùng ID điểm!");
                        textBox1.ResetText();
                        textBox4.ResetText();
                        comboBox2.ResetText();
                        comboBox1.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {

                        if (int.Parse(textBox4.Text) < 0 || int.Parse(textBox4.Text) > 10)
                        {
                            MessageBox.Show("Nhập điểm lớn hơn 0 và nhỏ hơn 10", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string sql1 = "insert into diem values ('" + textBox1.Text + "',N'" + comboBox2.Text + "','" + comboBox1.Text + "', '" + d + "') ";
                            KetNoiCSDL.themsuaxoa(sql1);
                            MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load();
                        }
                    }
                }
            
            
            }
            catch(Exception ex) {
                MessageBox.Show("Nhập điểm kiểu số!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
        }
    }
}

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
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, " ^ [0-9]" ))
            {
                textBox3.Text = "";
            }
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("select * from diem");
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[3].HeaderText = "Điểm";
            comboBox2.DataSource = KetNoiCSDL.Index("Select masv from sinhvien");
            comboBox1.DataSource = KetNoiCSDL.Index("select mamh from monhoc");
            comboBox1.DisplayMember = "mamh";
            comboBox2.DisplayMember = "masv";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from diem where id ='" + textBox1.Text + "'";
            
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
            else
            {
                float diem = float.Parse(textBox3.Text);
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Mời Bạn Nhập Điểm Chính Xác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = (int)KetNoiCSDL.count(sqlsa);
                    if (i != 0)
                    {
                        MessageBox.Show("ID Đã Được Sử Dụng. Vui Lòng Sử Dụng ID Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();

                        textBox3.Clear();
                        comboBox1.ResetText();
                        comboBox2.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {

                        string sql = "insert into diem values('" + textBox1.Text + "', N'" + comboBox2.Text + "','" + comboBox1.Text + "', N'" + textBox3.Text + "')";
                        KetNoiCSDL.themsuaxoa(sql);
                        dataGridView1.DataSource = KetNoiCSDL.Index("select * from diem");
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlsa = "select count(*) from diem where id ='" + textBox1.Text + "'";
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = (int)KetNoiCSDL.count(sqlsa);
                if (i == 0)
                {
                    MessageBox.Show("ID Đã Được Sử Dụng. Vui Lòng Sử Dụng ID Khác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear(); 
                    textBox3.Clear();
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    textBox1.Focus();
                }
                else
                {

                    string sql = "update diem set masv = N'" + comboBox2.Text + "',mamh = '" + comboBox1.Text + "', diem = '" + textBox3.Text + "' where id = '" + textBox1.Text + "'";
                    KetNoiCSDL.themsuaxoa(sql);
                    dataGridView1.DataSource = KetNoiCSDL.Index("select * from diem");
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

                string sql = "delete from diem where id = '" + textBox1.Text + "'";
                KetNoiCSDL.themsuaxoa(sql);
                dataGridView1.DataSource = KetNoiCSDL.Index("select * from diem");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); 

                textBox3.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
                textBox1.Focus();




            }
        }
    }
}

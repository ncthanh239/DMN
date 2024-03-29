﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace damminhnhat.Quanly
{
    public partial class ql_chinhsach : Form
    {
        public ql_chinhsach()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string sql = "select * from chinhsach";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            dataGridView1.Columns[0].HeaderText = "Mã chính sách";
            dataGridView1.Columns[1].HeaderText = "Tên chính sách";
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

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select count(*) from chinhsach where macs = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("Chính sách đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "insert into chinhsach values ('" + textBox1.Text + "', N'" + textBox2.Text + "') ";
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox1.Focus();
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
                    string sql = "select count(*) from chinhsach where macs = '" + textBox1.Text + "'";
                    int i = KetNoiCSDL.count(sql);
                    if (i == 0)
                    {
                        MessageBox.Show("Không được đổi mã chính sách!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql1 = "update chinhsach set tencs=N'" + textBox2.Text + "' where macs='" + textBox1.Text + "'";
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
                        string sql = "DELETE from chinhsach where macs = '" + textBox1.Text + "'";
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
                MessageBox.Show("Lỗi", "Lỗi" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

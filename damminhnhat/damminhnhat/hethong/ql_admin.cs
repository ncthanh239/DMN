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
    public partial class ql_admin : Form
    {
        int a;
        public ql_admin()
        {
            InitializeComponent();
            load();
        }

        private  void ql_admin_Load(object sender, EventArgs e)
        {
            
        }
        void load()
        {
            string sql = "SELECT tk As N'Tài khoản', mk AS N'Mật khẩu', status AS N'Loại tài khoản' FROM tkad order by status";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
            comboBox1.SelectedIndex = 0;
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txb_username.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txb_pass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txb_username.Focus();
            txb_pass.ResetText();
            txb_username.ResetText();

        }
        private String getMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (txb_pass.Text == null || txb_username.Text == null || comboBox1.Text == null)
                {
                    MessageBox.Show("Không được để trống!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string sql = "select count(*) from tkad where tk = '" + txb_username.Text + "'";
                int i = KetNoiCSDL.count(sql);
                if (i > 0)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_username.ResetText();
                    txb_pass.ResetText();
                    comboBox1.ResetText();
                    txb_username.Focus();
                }
                else
                {
                    string sql1 = "insert into tkad values ('" + txb_username.Text + "', '" + getMD5(txb_pass.Text) + "','"+ comboBox1.Text +"') ";
                    KetNoiCSDL.themsuaxoa(sql1);
                    MessageBox.Show("Thêm thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();

                }
            }
            catch (Exception ex)
            { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from tkad where tk = '" + txb_username.Text + "'";
            int i = KetNoiCSDL.count(sql);
            if (i == 0)
            {
                MessageBox.Show("Không được đổi tên tài khoản!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb_username.Focus();
            }
            else
            {           
                string sql1 = "update tkad set mk='" + getMD5(txb_pass.Text) + "', status ='"+ comboBox1.Text +"' where tk='" + txb_username.Text + "'";
                KetNoiCSDL.themsuaxoa(sql1);
                MessageBox.Show("Sửa thành công!", "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Bạn có muốn xóa không", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE from tkad where tk = '" + txb_username.Text + "'";
                    KetNoiCSDL.laybang(sql);
                    txb_username.ResetText();
                    txb_pass.ResetText();
                    txb_username.Focus();
                    load();
                }
            }
            catch(Exception ex){
                MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}

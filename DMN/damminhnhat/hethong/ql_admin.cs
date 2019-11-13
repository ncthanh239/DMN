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
            string sql = "SELECT * FROM tkad";
            dataGridView1.DataSource = KetNoiCSDL.laybang(sql);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txb_username.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                txb_pass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_pass.Text == null || txb_username.Text == null)
            {
                MessageBox.Show("Không được để trống!");
            }
            string sql = "select count(*) from tkad where tk = '"+txb_username.Text+"'";
            int i = KetNoiCSDL.count(sql);
            if (i > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                txb_username.ResetText();
                txb_pass.ResetText();
                txb_username.Focus();
            }
            else {
                string sql1 = "insert into tkad values ('" + txb_username.Text + "', '" + txb_pass.Text + "') ";
                KetNoiCSDL.themsuaxoa(sql1);
                MessageBox.Show("Thêm thành công!");
                load();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from tkad where tk = '" + txb_username.Text + "'";
            int i = KetNoiCSDL.count(sql);
            if (i == 0)
            {
                MessageBox.Show("Không được đổi tên tài khoản!");
                txb_username.Focus();
            }
            else
            {
                string sql1 = "update tkad set mk='"+txb_pass.Text+"' where tk='"+txb_username.Text+"'";
                KetNoiCSDL.themsuaxoa(sql1);
                MessageBox.Show("Sửa thành công!");
                load();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                string sql = "DELETE from tkad where tk = '" + txb_username.Text + "'";
                KetNoiCSDL.laybang(sql);
                txb_username.ResetText();
                txb_pass.ResetText();
                txb_username.Focus();
                load();
            }
            catch(Exception ex){
                MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main f = new main(1);
            f.Show();
            this.Close();
        }
    }
}

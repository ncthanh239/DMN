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
    public partial class tkKhoa : Form
    {
        public tkKhoa()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = KetNoiCSDL.Index("Select * from khoa");
            dataGridView1.Columns[0].HeaderText = "Mã Khoa";
            dataGridView1.Columns[1].HeaderText = "Tên Khoa";
           
        }

        private void tkKhoa_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Tên Khoa");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập từ khóa cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(comboBox1.Text.Equals("")){
                MessageBox.Show("Mời bạn chọn cách cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sqlten = "Select count(*) from khoa where tenkhoa like '%" + textBox1.Text + "%'";
                
                int i = (int)KetNoiCSDL.count(sqlten);
             

                if ((i != 0) && comboBox1.Text.Equals("Tên Khoa"))
                {
                    MessageBox.Show("Tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String kq = "select * from khoa where tenkhoa like N'%" + textBox1.Text.Trim() + "%'";
                    dataGridView1.DataSource = KetNoiCSDL.Index(kq);

                }
               
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            textBox1.Clear();
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Left <= this.Width)
                label2.Left = label2.Left + 10;
            else
                label2.Left = -label2.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangnhap d = new dangnhap();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dangky d1 = new dangky();
            d1.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tt = "";
            tt += "Phần mềm: QUẢN LÝ SINH VIÊN\n\n";
            tt += "Version: 1.1\n\n";
            tt += "Học Phần Thực Tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n\n";
            tt += "Copy right @ năm 2019\n\n";
            tt += "Designer By: Đàm Minh Nhật\n\n";
            tt += "Email: Nhatha2917@gmail .com";
            MessageBox.Show(tt, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

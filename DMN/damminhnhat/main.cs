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
    public partial class main : Form
    {
        int ltk = 0;
        public main(int ltk)
        {
            this.ltk = ltk;
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (ltk == 0)
            {
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
                ql_gv.Enabled = false;
                ql_tk.Enabled = false;
                ql_user.Enabled = false;
                diem.Enabled = false;
                ql.Enabled = false;
            }
            if (ltk == 1)
            {
                
            }
            if (ltk == 2)
            {
               
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
                ql_gv.Enabled = false;
                ql_tk.Enabled = false;
                ql_user.Enabled = false;
        
            }
            if (ltk == 3)
            {
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
                ql_gv.Enabled = false;
                ql_tk.Enabled = false;
                ql_user.Enabled = false;
                ql.Enabled = false;
            }
            
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ql_admin f = new ql_admin();
            f.Show();
            this.Close();
        }

        private void quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ql_truongkhoa f = new ql_truongkhoa();
            f.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                Form1 f = new Form1();
                f.Show();
                this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_sinhvien f = new tt_sinhvien();
            f.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_giaovien f = new tt_giaovien();
            f.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_khoa f = new tt_khoa();
            f.Show();
        }

        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_lop f = new tt_lop();
            f.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_monhoc f = new tt_monhoc();
            f.Show();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_chinhsach f = new tt_chinhsach();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tt_diem f = new tt_diem();
            f.Show();
        }

        private void ht_dn_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ql_user_Click(object sender, EventArgs e)
        {
            ql_users f = new ql_users();
            f.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            else this.Show();
        }

        private void ql_gv_Click(object sender, EventArgs e)
        {
            ql_giaovien f = new ql_giaovien();
            f.Show();
            this.Close();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\mspaint.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\cmd.exe");
        }

        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\notepad.exe");
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\calc.exe");
        }

        private void microsoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office12\WINWORD.exe");
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tt = "Phần mềm: QUẢN LÝ SINH VIÊN";
            tt += "Phần mềm: QUẢN LÝ SINH VIÊN\n\n";
            tt += "Version: 1.1\n\n";
            tt += "Học Phần Thực Tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n\n";
            tt += "Copy right @ năm 2019\n\n";
            tt += "Designer By: Đàm Minh Nhật\n\n";
            tt += "Email: Nhatha2917@gmail .com";
            MessageBox.Show(tt, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string tt = "Phần mềm: QUẢN LÝ SINH VIÊN";
            tt += "Phần mềm: QUẢN LÝ SINH VIÊN\n\n";
            tt += "Version: 1.1\n\n";       
            tt += "";
            tt += "Lập trình hướng cơ sở dữ liệu\n\n";
            tt += "Copy right @ năm 2019\n\n";
            tt += "Email: Đàm Minh Nhật\n\n";
            tt += "Email: Nhatha2917@gmail .com";
            MessageBox.Show(tt, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trongSuốtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
            tt_sinhvien ttsv = new tt_sinhvien();
            tt_monhoc ttmh = new tt_monhoc();
            tt_lop ttl = new tt_lop();
            tt_khoa ttk = new tt_khoa();
            tt_giaovien ttgv = new tt_giaovien();
            tt_chinhsach ttcs = new tt_chinhsach();
            tt_diem ttd = new tt_diem();
            ql_admin qlad = new ql_admin();
            ql_giaovien qlgv = new ql_giaovien();
            ql_truongkhoa qltk = new ql_truongkhoa();
            ql_users qlu = new ql_users();
            qlu.Opacity = 0.8;
            qltk.Opacity = 0.8;
            qlgv.Opacity = 0.8;
            qlad.Opacity = 0.8;
            ttd.Opacity = 0.8;
            ttcs.Opacity = 0.8;
            ttgv.Opacity = 0.8;
            ttk.Opacity = 0.8;
            ttl.Opacity = 0.8;
            ttmh.Opacity = 0.8;
            ttsv.Opacity = 0.8;
            dn.Opacity = 0.8;
            dk.Opacity = 0.8;
            this.Opacity = 0.8;
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
            tt_sinhvien ttsv = new tt_sinhvien();
            tt_monhoc ttmh = new tt_monhoc();
            tt_lop ttl = new tt_lop();
            tt_khoa ttk = new tt_khoa();
            tt_giaovien ttgv = new tt_giaovien();
            tt_chinhsach ttcs = new tt_chinhsach();
            tt_diem ttd = new tt_diem();
            ql_admin qlad = new ql_admin();
            ql_giaovien qlgv = new ql_giaovien();
            ql_truongkhoa qltk = new ql_truongkhoa();
            ql_users qlu = new ql_users();
            qlu.Opacity = 0.45;
            qltk.Opacity = 0.45;
            qlgv.Opacity = 0.45;
            qlad.Opacity = 0.45;
            ttd.Opacity = 0.45;
            ttcs.Opacity = 0.45;
            ttgv.Opacity = 0.45;
            ttk.Opacity = 0.45;
            ttl.Opacity = 0.45;
            ttmh.Opacity = 0.45;
            ttsv.Opacity = 0.45;
            dn.Opacity = 0.45;
            dk.Opacity = 0.45;
            this.Opacity = 0.45;
        }

        private void mặcĐịnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
            tt_sinhvien ttsv = new tt_sinhvien();
            tt_monhoc ttmh = new tt_monhoc();
            tt_lop ttl = new tt_lop();
            tt_khoa ttk = new tt_khoa();
            tt_giaovien ttgv = new tt_giaovien();
            tt_chinhsach ttcs = new tt_chinhsach();
            tt_diem ttd = new tt_diem();
            ql_admin qlad = new ql_admin();
            ql_giaovien qlgv = new ql_giaovien();
            ql_truongkhoa qltk = new ql_truongkhoa();
            ql_users qlu = new ql_users();
            qlu.Opacity = 1;
            qltk.Opacity = 1;
            qlgv.Opacity = 1;
            qlad.Opacity = 1;
            ttd.Opacity = 1;
            ttcs.Opacity = 1;
            ttgv.Opacity = 1;
            ttk.Opacity = 1;
            ttl.Opacity = 1;
            ttmh.Opacity = 1;
            ttsv.Opacity = 1;
            dn.Opacity = 1;
            dk.Opacity = 1;
            this.Opacity = 1;
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "System";
            thôngTinToolStripMenuItem.Text = "Information";
            tìmKiếmToolStripMenuItem.Text = "Search";
            điểmToolStripMenuItem1.Text = "Point";
            ql.Text = "Manage";
            diem.Text = "Point";
            hiểnThịToolStripMenuItem.Text = "Display";
            tiệnÍchToolStripMenuItem.Text = "Utilities";
            hỗTrợToolStripMenuItem.Text = "Support";
            thoátToolStripMenuItem.Text = "Exit";
            ht_dn.Text = "Login";
            ql_admin.Text = "Manage account admin";
            ql_tk.Text = "Manage account admin";
            ql_gv.Text = "Manage account teacher";
            ql_user.Text = "Manage account users";
            ht_khoa.Text = "Key";
            ht_dmk.Text = "Change password";
            ht_dx.Text = "Logout";
            khoaToolStripMenuItem.Text = "Faculty";
            giáoViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem.Text = "Class";
            sinhViênToolStripMenuItem.Text = "Student";
            mônHọcToolStripMenuItem.Text = "Subjects";
            chínhSáchToolStripMenuItem.Text = "Policy";
            điểmToolStripMenuItem1.Text = "Point";

            khóaToolStripMenuItem1.Text = "Faculty";
            giáoViênToolStripMenuItem1.Text = "Teacher";
            lớpToolStripMenuItem1.Text = "Class";
            sinhViênToolStripMenuItem1.Text = "Student";
            mônHọcToolStripMenuItem1.Text = "Subject";
            chínhSáchToolStripMenuItem1.Text = "Policy";

            khoaToolStripMenuItem1.Text = "Faculty";
            giáoViênToolStripMenuItem2.Text = "Teacher";
            lớpToolStripMenuItem2.Text = "Class";
            sinhViênToolStripMenuItem2.Text = "Student";
            mônHọcToolStripMenuItem2.Text = "Subject";
            chínhSáchToolStripMenuItem2.Text = "Policy";
            điểmToolStripMenuItem2.Text = "Point";

            kiểuXemToolStripMenuItem.Text = "View type";
            ngônNgữToolStripMenuItem.Text = "Language";
            trongSuốtToolStripMenuItem.Text = "Crystal clear(50%)";
            mặcĐịnhToolStripMenuItem.Text = "Crystal clear(100%)";
            mặcĐịnhToolStripMenuItem1.Text = "Default";
            liênHệToolStripMenuItem.Text = "Contact";
            thôngTinToolStripMenuItem1.Text = "Information";
            cậpNhậtToolStripMenuItem.Text = "Update";
            tiếngAnhToolStripMenuItem.Text = "English";
            tiếngViệtToolStripMenuItem.Text = "Vietnamese";
        }

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            thôngTinToolStripMenuItem.Text = "Thông tin";
            tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            điểmToolStripMenuItem1.Text = "Điểm";
            ql.Text = "Quản lý";
            hiểnThịToolStripMenuItem.Text = "Hiển thị";
            tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            thoátToolStripMenuItem.Text = "Thoát";
            ht_dn.Text = "Đăng nhập";
            ql_admin.Text = "Quản lý tài khoản admin";
            ql_tk.Text = "Quản lý tài khoản trưởng khoa";
            ql_gv.Text = "Quản lý tài khoản giáo viên";
            ql_user.Text = "Quản lý tài khoản user";
            ht_khoa.Text = "Khóa";
            ht_dmk.Text = "Đổi mật khẩu";
            ht_dx.Text = "Đăng xuất";
            khoaToolStripMenuItem.Text = "Khoa";
            giáoViênToolStripMenuItem.Text = "Giáo viên";
            lớpToolStripMenuItem.Text = "Lớp";
            sinhViênToolStripMenuItem.Text = "Sinh viên";
            mônHọcToolStripMenuItem.Text = "Môn học";
            chínhSáchToolStripMenuItem.Text = "Chính sách";
            điểmToolStripMenuItem1.Text = "Điểm";

            khóaToolStripMenuItem1.Text = "Khoa";
            giáoViênToolStripMenuItem1.Text = "Giáo viên";
            lớpToolStripMenuItem1.Text = "Lớp";
            sinhViênToolStripMenuItem1.Text = "Sinh viên";
            mônHọcToolStripMenuItem1.Text = "Môn học";
            chínhSáchToolStripMenuItem1.Text = "Chính sách";

            khoaToolStripMenuItem1.Text = "Khoa";
            giáoViênToolStripMenuItem2.Text = "Giáo viên";
            lớpToolStripMenuItem2.Text = "Lớp";
            sinhViênToolStripMenuItem2.Text = "Sinh viên";
            mônHọcToolStripMenuItem2.Text = "Môn học";
            chínhSáchToolStripMenuItem2.Text = "Chính sách";
            điểmToolStripMenuItem2.Text = "Điểm";

            kiểuXemToolStripMenuItem.Text = "Kiểu xem ";
            ngônNgữToolStripMenuItem.Text = "Ngôn ngữ";
            trongSuốtToolStripMenuItem.Text = "Trong suốt(50%)";
            mặcĐịnhToolStripMenuItem.Text = "Trong suốt(100%)";
            mặcĐịnhToolStripMenuItem1.Text = "Mặc định";
            liênHệToolStripMenuItem.Text = "Liên hệ";
            thôngTinToolStripMenuItem1.Text = "Thông tin";
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            tiếngAnhToolStripMenuItem.Text = "Tiếng anh";
            tiếngViệtToolStripMenuItem.Text = "Tiếng việt";
        }

        

    }
}

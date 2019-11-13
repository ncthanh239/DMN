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
        string loai;
        String name;
        public main(int ltk, String name)
        {
            this.ltk = ltk;
            this.name = name;
            InitializeComponent();
        }
        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            
            if (ltk == 0)
            {
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
                 loai = "sinh viên: ";
                diem.Enabled = false;
                ql.Enabled = false;
            }
            if (ltk == 1)
            {
                loai = "admin: "; 
                ht_dn.Enabled = false;
            }
            if (ltk == 2)
            {
                loai = "trưởng khoa: ";
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
               
        
            }
            if (ltk == 3)
            {
                ht_dn.Enabled = false;
                ql_admin.Enabled = false;
                loai = "giáo viên: ";
                ql.Enabled = false;
            }
            label1.Text ="Xin chào "+loai + name;
            
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tksinhvien f = new Search.tksinhvien();
            f.Show();
        }

        private void quảnLýTàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ql_admin f = new ql_admin();
            f.Show();
        }

        private void quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Nhóm 9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Close();
                }
                else this.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InSV f = new InSV();
            f.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InGV f = new InGV();
            f.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InKhoa f = new InKhoa();
           f.Show();
        }
        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           InLop f = new InLop();
            f.Show();
        }
        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InMonHoc f = new InMonHoc();
            f.Show();
        }
        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            In1 f = new In1();
            f.Show();
        }
        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InDiem f = new InDiem();
            f.Show();
        }

        private void ht_dn_Click(object sender, EventArgs e)
        {
            dangnhap f = new dangnhap();
            f.Show();
            this.Hide();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ql_user_Click(object sender, EventArgs e)
        {
          
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Nhóm9", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            else this.Show();
        }

        private void ql_gv_Click(object sender, EventArgs e)
        {
             
          
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
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office15\WINWORD.exe");
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tt = "";
            tt += "Copy right @ năm 2019\n\n";
            tt += "Đàm Minh Nhật\n\n";
            tt += "Ngyễn Chí Thành\n\n";
            tt += "Phan Văn Nam\n\n";
            tt += "Email: nhom9@gmail .com";
            MessageBox.Show(tt, "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string tt = "";
            tt += "Phần mềm: QUẢN LÝ SINH VIÊN\n\n";
            tt += "Version: 1.1\n\n";
            tt += "Học Phần Thực Tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n\n";
            tt += "Copy right @ năm 2019\n\n";
            tt += "Đàm Minh Nhật\n\n";
            tt += "Ngyễn Chí Thành\n\n";
            tt += "Phan Văn Nam\n\n";
            tt += "Email: nhom9@gmail .com";
            MessageBox.Show(tt, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất!", "Nhóm 9!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trongSuốtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
     
            ql_admin qlad = new ql_admin();
            //ql_giaovien qlgv = new ql_giaovien();
            //ql_truongkhoa qltk = new ql_truongkhoa();
            //ql_users qlu = new ql_users();
            //qlu.Opacity = 0.8;
            //qltk.Opacity = 0.8;
            //qlgv.Opacity = 0.8;
            qlad.Opacity = 0.8;
   
            dn.Opacity = 0.8;
            dk.Opacity = 0.8;
            this.Opacity = 0.8;
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
            ql_admin qlad = new ql_admin();
            //ql_giaovien qlgv = new ql_giaovien();
            //ql_truongkhoa qltk = new ql_truongkhoa();
            //ql_users qlu = new ql_users();
            //qlu.Opacity = 0.45;
            //qltk.Opacity = 0.45;
            //qlgv.Opacity = 0.45;
            qlad.Opacity = 0.45;

            dn.Opacity = 0.45;
            dk.Opacity = 0.45;
            this.Opacity = 0.45;
        }

        private void mặcĐịnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dangky dk = new dangky();
         
            ql_admin qlad = new ql_admin();
            //ql_giaovien qlgv = new ql_giaovien();
            //ql_truongkhoa qltk = new ql_truongkhoa();
            //ql_users qlu = new ql_users();
            //qlu.Opacity = 1;
            //qltk.Opacity = 1;
            //qlgv.Opacity = 1;
            qlad.Opacity = 1;
       
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

        private void ht_dmk_Click(object sender, EventArgs e)
        {
            damminhnhat.hethong.doimatkhau dmk = new hethong.doimatkhau();
            dmk.Show();
        }

        private void ht_khoa_Click(object sender, EventArgs e)
        {
            ql_admin.Enabled = false;
   
            ht_dmk.Enabled = false;
            ht_khoa.Enabled = false;
            ht_dx.Enabled = false;
            thôngTinToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            diem.Enabled = false;
            ql.Enabled = false;
            ht_dn.Enabled = true;
            hiểnThịToolStripMenuItem.Enabled = false;
            tiệnÍchToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            //if (label1.Left <= this.Width)
                //label1.Left = label1.Left + 10;
            //else
                //label1.Left = -label1.Width;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quanly.ql_khoa k = new Quanly.ql_khoa();
            k.Show();
        }

        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_chinhsach f = new Quanly.ql_chinhsach();
            f.Show();
        }

        private void giáoViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_gv f = new Quanly.ql_gv();
            f.Show();
        }

        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_lop f = new Quanly.ql_lop();
            f.Show();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_monhoc f = new Quanly.ql_monhoc();
            f.Show();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_sinhvien f = new Quanly.ql_sinhvien();
            f.Show();
        }

        private void điểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quanly.ql_diem f = new Quanly.ql_diem();
            f.Show();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tk_monhoc f = new Search.tk_monhoc();
            f.Show();
        }

        private void khóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tk_khoa f = new Search.tk_khoa();
            f.Show();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tk_giaovien f = new Search.tk_giaovien();
            f.Show();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tk_lop f = new Search.tk_lop();
            f.Show();
        }

        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search.tkchinhsach f = new Search.tkchinhsach();
            f.Show();
        }

        private void diem_Click(object sender, EventArgs e)
        {
            Quanly.ql_diem f = new Quanly.ql_diem();
            f.Show();
        }

        private void ql_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\84965\Documents\HelpNDoc\Output\bbbb.chm");
        }

        private void nhiệmVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tt = "";
            tt += "Nhiệm vụ\n\n";
            tt += "Đàm Minh Nhật: Lập trình, phát triển yêu cầu mở rộng.\n\n";
            tt += "Ngyễn Chí Thành: Lập trình, phát triển yêu cầu mở rộng.\n\n";
            tt += "Phan Văn Nam: Lập trình, thiết kế giao diện\n\n";
            MessageBox.Show(tt, "Nhóm 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace damminhnhat
{
    class KetNoiCSDL
    {
        private static string duongdan = @"Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        private static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(duongdan);
        }
        public static DataTable laybang(string sql)
        {
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, duongdan);
            DataTable t = new DataTable();
            ad.Fill(t);
            ad.Dispose();
            ketnoi.Close();
            return t;
            
        }
        public static void themsuaxoa(string sql)
        {
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlCommand lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            lenh.Dispose();
            ketnoi.Close();
        }

        public static int count(string sql)
        {
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlCommand lenh = new SqlCommand(sql, ketnoi);
            int i = (int)lenh.ExecuteScalar();
            lenh.Dispose();
            ketnoi.Close();
            return i;
        }
    }
}

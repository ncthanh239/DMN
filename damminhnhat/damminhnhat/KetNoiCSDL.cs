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
        private static string duongdan = @"Data Source=DESKTOP-9KN3FKR\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";

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
        public static int getStatus(string sql)
        {
            int status = 0;
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, duongdan);
            DataTable t = new DataTable();
            ad.Fill(t);
            if (t != null)
            {
                foreach (DataRow dr in t.Rows)
                {
                    status = int.Parse(dr["status"].ToString());
                }
            }
            return status;
            
        }

        public static int count(string sql)
        {
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlCommand lenh = new SqlCommand(sql, ketnoi);
            int i = (int)lenh.ExecuteScalar();
            lenh.Dispose();
            ketnoi.Close();
            return i ;
        }
    }
}

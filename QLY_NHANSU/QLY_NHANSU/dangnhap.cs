using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLY_NHANSU
{
    class dangnhap
    {
        Ketnoi db = new Ketnoi();
        public bool DangNhap(string _ten,string _mk)
        {
            string sql = "MATKHAU";
            SqlConnection con = new SqlConnection(Ketnoi.getconect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", _ten);
            cmd.Parameters.AddWithValue("@mk", _mk);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count >0) return true;
            return false;
        }
        public DataTable NHANSU()
        {
            string sql = "show";
            SqlConnection con = new SqlConnection(Ketnoi.getconect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

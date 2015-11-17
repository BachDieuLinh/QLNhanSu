using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLY_NHANSU
{
    public class TimKiem
    {
        KetNoi cn = new KetNoi();
        public DataTable TKMaNV(string MaNV)
        {
            string sql = "Sea_MaNV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        public DataTable TKTenNV(string TenNV)
        {
            string sql = "Sea_TenNV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable TKDiaChiNhanVien(string DIACHI)
        {
             
            string sql = "Sea_DiaChiNV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@DiaChi", DIACHI);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
     
        // Tìm kiếm nhân viên theo giới tính
        public DataTable TKGTNhanVien(string GT)
        {
             
            string sql = "Sea_GTNV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@gt", GT);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable TKSDT(string SDT)
        {

            string sql = "Sea_SDTNV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@SDT", SDT);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        
        
    }
}

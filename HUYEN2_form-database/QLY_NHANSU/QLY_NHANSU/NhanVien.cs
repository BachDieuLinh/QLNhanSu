using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLY_NHANSU
{
    public class NhanVien
    {
        KetNoi cn = new KetNoi();
        public DataTable HienThiNhanVien()
        {
            string sql = "Sho_NV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemNhanVien(string TenNV, string NS, string GT, string ChucVu, string SDT, string Luong, string DiaChi)
        {
            string sql = "Ins_NV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
             
            cmd.Parameters.AddWithValue("@tennv", TenNV);
            cmd.Parameters.AddWithValue("@ns", DateTime.Parse(NS));
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@chucvu", ChucVu);
            cmd.Parameters.AddWithValue("@sdt", SDT);
            cmd.Parameters.AddWithValue("@luong", int.Parse(Luong));
            cmd.Parameters.AddWithValue("@diachi", DiaChi);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaNhanVien(string TenNV, string NS, string GT, string ChucVu, string SDT, string Luong, string DiaChi,string MaNV)
        {
            string sql = "Upd_NV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@tennv", TenNV);
            cmd.Parameters.AddWithValue("@ns", DateTime.Parse(NS));
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@chucvu", ChucVu);
            cmd.Parameters.AddWithValue("@sdt", SDT);
            cmd.Parameters.AddWithValue("@luong", int.Parse(Luong));
            cmd.Parameters.AddWithValue("@diachi", DiaChi);
            cmd.Parameters.AddWithValue("@manv", MaNV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaNhanVien(string MaNV)
        {
            string sql = "Del_NV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", MaNV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}

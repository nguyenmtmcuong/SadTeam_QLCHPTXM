using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangPhuTungXeMay.Properties;

namespace QuanLyCuaHangPhuTungXeMay
{
    class NhanVienModify
    {
        ConnectToSQL cn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn.Connection;
            try
            {
                cn.Connect();
                SqlDataAdapter _da = new SqlDataAdapter(cmd);
                _da.Fill(dt);
                cn.DisConnect();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cn.DisConnect();
            }
            return dt;
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            cmd.CommandText = "INSERT INTO NhanVien values ('" + nv.Ma + "',N'" + nv.Ten + "',N'" + nv.ChucVu + "','" + nv.MatKhau + "',N'" + nv.DiaChi + "','" + nv.SDT + "',N'" + nv.GhiChu + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn.Connection;
            try
            {
                cn.Connect();
                cmd.ExecuteNonQuery();
                cn.DisConnect();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cn.DisConnect();

            }
            return false;
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            cmd.CommandText = "UPDATE NhanVien SET TenNV = N'" + nv.Ten + "',  ChucVu =N'" + nv.ChucVu + "', MatKhau ='" + nv.MatKhau + "', DiaChi =N'" + nv.DiaChi + "', SDT ='" + nv.SDT + "',  GhiChu=N'" + nv.GhiChu + "' Where MaNV= '" + nv.Ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn.Connection;
            try
            {
                cn.Connect();
                cmd.ExecuteNonQuery();
                cn.DisConnect();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cn.DisConnect();

            }
            return false;
        }

        public bool XoaNhanVien(String ma)
        {
            cmd.CommandText = "DELETE NhanVien Where MaNV = '" + ma + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn.Connection;
            try
            {
                cn.Connect();
                cmd.ExecuteNonQuery();
                cn.DisConnect();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cn.DisConnect();

            }
            return false;
        }
    }
}


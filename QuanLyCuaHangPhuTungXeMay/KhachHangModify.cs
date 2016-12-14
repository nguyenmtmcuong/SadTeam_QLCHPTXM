using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyCuaHangPhuTungXeMay.Properties;

namespace QuanLyCuaHangPhuTungXeMay
{
    class KhachHangModify
    {
        ConnectToSQL cn = new ConnectToSQL();  
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM KhachHang";
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

        public bool ThemKhachHang(KhachHang kh)
        {
            cmd.CommandText = "INSERT INTO KhachHang values ('" + kh.Ma + "', N'" + kh.Ten + "', '" + kh.SDT + "', '" + kh.MaLoaiXe + "', '" + kh.BienSo + "', '" + kh.SoLanSuaChua + "', '" + kh.DiemTichLuy + "', '" + kh.GhiChu + "')";
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

        public bool SuaKhachHang(KhachHang kh)
        {
            cmd.CommandText = "UPDATE KhachHang SET TenKH = N'" + kh.Ten + "',  SDT ='" + kh.SDT + "', MaLoaiXe ='" + kh.MaLoaiXe + "', BienSo ='" + kh.BienSo + "', SoLanSuaChua ='" + kh.SoLanSuaChua + "',  DiemTichLuy='" + kh.DiemTichLuy + "', GhiChu = '" + kh.GhiChu + "' Where MaKH= '" + kh.Ma + "'";
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

        public bool XoaKhachHang(String ma)
        {
            cmd.CommandText = "DELETE KhachHang Where MaKH = '" + ma + "' ";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class LoaiXeModel
    {
        ConnectToSQL cn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM LoaiXe";
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

        public DataTable GetDataTim(string sql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from LoaiXe where TenThuongGoi like '%" + sql + "%'";
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

        public bool ThemLoaiXe(LoaiXe lx)
        {
            cmd.CommandText = "INSERT INTO LoaiXe values ('" + lx.Ma + "', N'" + lx.Ten + "', '" + lx.Loai + "', '" + lx.Hang + "', '" + lx.PhanKhoi + "', '" + lx.NamSX + "', '" + lx.NguonNhap + "')";
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

        public bool SuaLoaiXe(LoaiXe lx)
        {
            cmd.CommandText = "UPDATE LoaiXe SET TenThuongGoi = N'" + lx.Ten + "',  Loai ='" + lx.Loai + "', HangXe ='" + lx.Hang + "', PhanKhoi ='" + lx.PhanKhoi + "', NamSanXuat ='" + lx.NamSX + "',  NguonNhap='" + lx.NguonNhap + "' Where MaLX= '" + lx.Ma + "'";
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

        public bool XoaLoaiXe(String ma)
        {
            cmd.CommandText = "DELETE LoaiXe Where MaLX = '" + ma + "' ";
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

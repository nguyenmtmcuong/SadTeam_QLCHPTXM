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
    class HDBHModify
    {
        ConnectToSQL cn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM HoaDonBanHang";
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

        public bool TaoMoiHDBH(HDBH hdbh)
        {
            cmd.CommandText = "INSERT INTO HoaDonBanHang values ('" + hdbh.MaHD + "','"+hdbh.KhuyenMai+"','"+hdbh.TenPT+"','"+hdbh.ThanhTien+"', '" + hdbh.MaKH + "', '" + hdbh.MaNV + "', '" + hdbh.MaPT + "', '" + hdbh.SoLuong + "', '" + hdbh.ThanhTien + "', '" + hdbh.DonGia + "', convert(date,'" + hdbh.Ngay + "',103))";
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

        public bool XoaHDBH(String mahd)
        {
            cmd.CommandText = "DELETE HoaDonBanHang Where MaHD = '" + mahd + "' ";
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



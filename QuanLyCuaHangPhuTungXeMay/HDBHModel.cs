using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyCuaHangPhuTungXeMay
{
    class HDBHModel
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHDBH, hd.NgayLap, nv.TenNV, kh.BienSo from tb_HDBH hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaKH = hd.BienSo and nv.MaNV = hd.NguoiLap";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.Connect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.DisConnect();
            }
            return dt;
        }

        public bool AddData(HDBH hdObj)
        {
            cmd.CommandText = "insert into HDBH values ('" + hdObj.MaHoaDon + "', CONVERT (date,'" + hdObj.NgayLap + "',103),'" + hdObj.NguoiLap + "','" + hdObj.BienSo+ "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.DisConnect();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete HDBH Where MaHDBH = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.DisConnect();
            }
            return false;
        }
    }
}

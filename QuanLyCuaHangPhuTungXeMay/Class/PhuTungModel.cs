using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class PhuTungModel
    {
        ConnectToSQL cn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM PhuTung";
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
            cmd.CommandText = "select * from PhuTung where TenPhuTung like '%" + sql + "%'";
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

        public bool ThemPhuTung(PhuTung pt)
        {
            cmd.CommandText = "INSERT INTO PhuTung values ('" + pt.MaPT + "', '" + pt.MaLoai + "', N'" + pt.TenPT + "', N'" + pt.DonVi + "', '" + pt.GiaNhap + "', '" + pt.GiaBan + "', '" + pt.SLTon + "', '" + pt.GhiChu + "')";
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

        public bool SuaPhuTung(PhuTung pt)
        {
            cmd.CommandText = "UPDATE PhuTung SET TenPhuTung = N'" + pt.TenPT + "',MaLoaiXe = '" + pt.MaLoai + "',  DonVi =N'" + pt.DonVi + "', GhiChu ='" + pt.GhiChu + "', GiaBan ='" + pt.GiaBan + "', GiaNhap ='" + pt.GiaNhap + "',  SoLuongTon='" + pt.SLTon + "' Where MaPT= '" + pt.MaPT + "'";
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

        public bool XoaPhuTung(String mapt)
        {
            cmd.CommandText = "DELETE PhuTung Where MaPT = '" + mapt + "' ";
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

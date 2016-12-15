using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangPhuTungXeMay
{
    class DataTableTimNhanh
    {
        public SqlConnection GetConnect()
        {
            return new SqlConnection("Server = .; Database = QuanLyCuaHangXeMay; Integrated Security = true");
        }

        //public SqlDataReader ExecuteReader(string s)
        //{
        //    SqlConnection con = GetConnect();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(s, con);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    cmd.Dispose();
        //    return reader;
        //}
        //public void ExecuteNonQuery(string s)
        //{
        //    SqlConnection con = GetConnect();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(s, con);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}
        //public string ExecuteScalar(string s)
        //{
        //    SqlConnection con = GetConnect();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(s, con);
        //    string ss = cmd.ExecuteScalar().ToString();
        //    cmd.Dispose();
        //    con.Close();
        //    return ss;
        //}

        public DataTable TimNhanh(string s)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangPhuTungXeMay
{
    class ConnectToSQL
    {
        private SqlConnection _cn;
        private SqlCommand _cmd;

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        public SqlConnection Connection { get { return _cn; } }

        public string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        string cnStr;
        public ConnectToSQL()
        {
            cnStr = "Server = .; Database = QuanLyCuaHangXeMay; Integrated Security = true";
            _cn = new SqlConnection(cnStr);
        }

        public bool Connect()
        {
            try
            {
                if (_cn.State == ConnectionState.Closed)
                    _cn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                //throw;
                return false;
            }
            return true;
        }

        public bool DisConnect()
        {
            try
            {
                if (_cn.State == ConnectionState.Open)
                    _cn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                //throw;
                return false;
            }
            return true;
        }
    }
}

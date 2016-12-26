using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace QuanLyCuaHangPhuTungXeMay
{
    class HoaDonCtr
    {
        HoaDonMod hdMod = new HoaDonMod();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public bool AddData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}

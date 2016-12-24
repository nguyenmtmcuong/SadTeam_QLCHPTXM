using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace QuanLyCuaHangPhuTungXeMay
{
    class HDBHControl
    {
        HDBHModel hdMod = new HDBHModel();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public bool AddData(HDBH hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}

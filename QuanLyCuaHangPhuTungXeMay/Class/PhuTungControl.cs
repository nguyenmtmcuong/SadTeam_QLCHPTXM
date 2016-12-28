using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class PhuTungControl
    {
        PhuTungModel ptMod = new PhuTungModel();

        public DataTable GetData()
        {
            return ptMod.GetData();
        }

        public DataTable GetDataTim(string sql)
        {
            return ptMod.GetDataTim(sql);
        }

        public bool ThemPhuTung(PhuTung pt)
        {
            return ptMod.ThemPhuTung(pt);
        }

        public bool SuaPhuTung(PhuTung pt)
        {
            return ptMod.SuaPhuTung(pt);
        }

        public bool XoaPhuTung(string mapt)
        {
            return ptMod.XoaPhuTung(mapt);
        }
    }
}

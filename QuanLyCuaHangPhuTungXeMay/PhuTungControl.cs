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
        PhuTungModify ptMod = new PhuTungModify();

        public DataTable GetData()
        {
            return ptMod.GetData();
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

using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPhuTungXeMay
{
    class HDBHControl
    {
        HDBHModify HDBHMod = new HDBHModify();

        public DataTable GetData()
        {
            return HDBHMod.GetData();
        }

        public bool ThemHD(HDBH hdbh)
        {
            return HDBHMod.TaoMoiHDBH(hdbh);
        }

        public bool XoaHD(string mahd)
        {
            return HDBHMod.XoaHDBH(mahd);
        }
    }
}

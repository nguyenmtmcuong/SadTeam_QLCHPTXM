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

        public bool ThemNhanVien(HDBH hdbh)
        {
            return HDBHMod.TaoMoiHDBH(hdbh);
        }

        public bool XoaNhanVien(string mahd)
        {
            return HDBHMod.XoaHDBH(mahd);
        }
    }
}

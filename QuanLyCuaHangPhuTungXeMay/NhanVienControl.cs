using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class NhanVienControl
    {
        NhanVienModify nvMod = new NhanVienModify();

        public DataTable GetData()
        {
            return nvMod.GetData();
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            return nvMod.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            return nvMod.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(string ma)
        {
            return nvMod.XoaNhanVien(ma);
        }
    }
}

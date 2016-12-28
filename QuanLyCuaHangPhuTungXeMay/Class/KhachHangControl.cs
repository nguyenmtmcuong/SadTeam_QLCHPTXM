using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class KhachHangControl
    {
        KhachHangModel khMod = new KhachHangModel();

        public DataTable GetData()
        {
            return khMod.GetData();
        }

        public DataTable GetDataTim(string sql)
        {
            return khMod.GetDataTim(sql);
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            return khMod.ThemKhachHang(kh);
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            return khMod.SuaKhachHang(kh);
        }

        public bool XoaKhachHang(string ma)
        {
            return khMod.XoaKhachHang(ma);
        }
    }
}

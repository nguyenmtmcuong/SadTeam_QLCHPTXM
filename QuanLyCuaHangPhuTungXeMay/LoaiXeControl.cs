using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangPhuTungXeMay
{
    class LoaiXeControl
    {
        LoaiXeModify lxMod = new LoaiXeModify();

        public DataTable GetData()
        {
            return lxMod.GetData();
        }

        public bool ThemLoaiXe(LoaiXe lx)
        {
            return lxMod.ThemLoaiXe(lx);
        }

        public bool SuaLoaiXe(LoaiXe lx)
        {
            return lxMod.SuaLoaiXe(lx);
        }

        public bool XoaLoaiXe(string ma)
        {
            return lxMod.XoaLoaiXe(ma);
        }
    }
}

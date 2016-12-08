
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPhuTungXeMay
{
    class KhachHang
    {
        string ma, ten, maloaixe, bienso, ghichu;
        int sdt, diemtichluy, solansuachua;

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public int SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string MaLoaiXe
        {
            get { return maloaixe; }
            set { maloaixe = value; }
        }

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }

        public int SoLanSuaChua
        {
            get { return solansuachua; }
            set { solansuachua = value; }
        }

        public int DiemTichLuy
        {
            get { return diemtichluy; }
            set { diemtichluy = value; }
        }

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public KhachHang() { }
        public KhachHang(string ma, string ten, int sdt, string maloaixe, string bienso, int solansuachua, int diemtichluy, string ghichu)
        {
            this.ma = ma;
            this.ten = ten;
            this.sdt = sdt;
            this.maloaixe = maloaixe;
            this.bienso = bienso;
            this.solansuachua = solansuachua;
            this.diemtichluy = diemtichluy;
            this.ghichu = ghichu;
        }
    }
}

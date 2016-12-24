using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangPhuTungXeMay
{
    class CTHDBH
    {
        string mahd, mahh, khuyenmai;

        public string KhuyenMai
        {
            get { return khuyenmai; }
            set { khuyenmai = value; }
        }

        public string MaHangHoa
        {
            get { return mahh; }
            set { mahh = value; }
        }

        public string MaHoaDon
        {
            get { return mahd; }
            set { mahd = value; }
        }
        int sl, dongia;
        float thanhtien;

        public float ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public int SoLuong
        {
            get { return sl; }
            set { sl = value; }
        }

        
        public CTHDBH() { }

        public CTHDBH(string mahd, string mahh, int sl, int dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.sl = sl;
            this.dongia = dongia;
        }
    }
}

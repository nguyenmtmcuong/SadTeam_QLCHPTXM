using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPhuTungXeMay
{
    class HDBH
    {
        string mahd, manv, bienso, tenpt, ngay, makh, mapt, khuyenmai;
        
        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        public string MaKH
        {
            get { return makh; }
            set { makh = value; }
        }

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }

        public string MaPT
        {
            get { return mapt; }
            set { mapt = value; }
        }

        public string TenPT
        {
            get { return tenpt; }
            set { tenpt = value; }
        }

        public string Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public string KhuyenMai
        {
            get { return khuyenmai; }
            set { khuyenmai = value; }
        }
        int soluong, dongia, thanhtien;

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public int ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public HDBH() { }
        public HDBH(string mahd, string manv, string makh, string bienso, string mapt, string tenpt, string ngay, string khuyenmai, int soluong, int dongia, int thanhtien)
        {
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.bienso = bienso;
            this.mapt = mapt;
            this.tenpt = tenpt;
            this.ngay = ngay;
            this.khuyenmai = khuyenmai;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }
    }
}

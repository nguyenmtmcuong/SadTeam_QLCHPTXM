using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPhuTungXeMay
{
    class PhuTung
    {
        string mapt, maloai, tenpt, donvi, ghichu;
        int gianhap, giaban, slton;

        public string MaPT
        {
            get { return mapt; }
            set { mapt = value; }
        }

        public string MaLoai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        public string TenPT
        {
            get { return tenpt; }
            set { tenpt = value; }
        }

        public string DonVi
        {
            get { return donvi; }
            set { donvi = value; }
        }

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public int GiaNhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }

        public int GiaBan
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public int SLTon
        {
            get { return slton; }
            set { slton = value; }
        }

        public PhuTung() { }
        public PhuTung(string mapt, string maloai, string tenpt, string donvi, int gianhap, int giaban, int slton, string ghichu)
        {
            this.mapt = mapt;
            this.maloai = maloai;
            this.tenpt = tenpt;
            this.donvi = donvi;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.slton = slton;
            this.ghichu = ghichu;
        }
    }
}

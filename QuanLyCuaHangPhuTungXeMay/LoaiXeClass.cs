using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangPhuTungXeMay
{
    class LoaiXe
    {
        string ma, ten, loai, hang, nguonnhap;
        int phankhoi, namsx;

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

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        public string Hang
        {
            get { return hang; }
            set { hang = value; }
        }

        public string NguonNhap
        {
            get { return nguonnhap; }
            set { nguonnhap = value; }
        }

        public int PhanKhoi
        {
            get { return phankhoi; }
            set { phankhoi = value; }
        }

        public int NamSX
        {
            get { return namsx; }
            set { namsx = value; }
        }

        public LoaiXe() { }
        public LoaiXe(string ma, string ten, string loai, string hang, string nguonnhap, int namsx, int phankhoi)
        {
            this.ma = ma;
            this.ten = ten;
            this.loai = loai;
            this.hang = hang;
            this.nguonnhap = nguonnhap;
            this.namsx = namsx;
            this.phankhoi = phankhoi;
        }
    }
}

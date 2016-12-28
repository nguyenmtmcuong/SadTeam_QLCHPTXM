using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangPhuTungXeMay
{
    class NhanVien
    {
        string ma, ten, chucvu, matkhau, diachi, ghichu;
        int sdt;

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

        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public int SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public NhanVien() { }
        public NhanVien(string ma, string ten, string chucvu, string matkhau, string diachi, int sdt, string ghichu)
        {
            this.ma = ma;
            this.ten = ten;
            this.chucvu = chucvu;
            this.matkhau = matkhau;
            this.diachi = diachi;
            this.sdt = sdt;
            this.ghichu = ghichu;
        }
    }
}



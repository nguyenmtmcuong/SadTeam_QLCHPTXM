using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangPhuTungXeMay
{
    class HDBH
    {
        string ma, ngaylap, nguoilap, bienso;

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }



        public string NguoiLap
        {
            get { return nguoilap; }
            set { nguoilap = value; }
        }

        public string NgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string MaHoaDon
        {
            get { return ma; }
            set { ma = value; }
        }

        public HDBH() { }

        public HDBH(string ma, string ngaylap, string nguoilap, string bienso)
        {
            this.ma = ma;
            this.nguoilap = nguoilap;
            this.ngaylap = ngaylap;
            this.bienso = bienso;
        }
    }
}

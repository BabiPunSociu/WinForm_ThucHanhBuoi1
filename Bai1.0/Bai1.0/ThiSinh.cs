using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._0
{
    class ThiSinh
    {
        public string sbd { get; set; }
        public string hoten { get; set; }
        public double m1 { get; set; }
        public double m2 { get; set; }
        public double m3 { get; set; }

        public ThiSinh() { }
        public ThiSinh(string sbd, string hoten, double m1, double m2, double m3)
        {
            this.sbd = sbd;
            this.hoten = hoten;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        //    public void nhap() { }    không dùng
        public virtual double TinhDiem()
        {
            return m1 + m2 + m3;
        }
    }

    class TuyenSinh:ThiSinh
    {
        public int khuVuc { get; set; } // khu vuc 1: +0đ   2: +1đ  3: +2đ

        public TuyenSinh() {}
        public TuyenSinh(string sbd, string hoten, double m1, double m2, double m3,int khuVuc) : base(sbd,hoten,m1,m2,m3)
        {
            this.khuVuc = khuVuc;
        }

        public override double TinhDiem()
        {
            return m1 + m2 + m3 + (khuVuc - 1);
        }
        public string hienThi()
        {
            string d1 = m1.ToString(" 0.00");
            string d2 = m2.ToString(" 0.00");
            string d3 = m3.ToString(" 0.00");
            return $"\n{sbd,-10}|{hoten,-25}|{d1,5}|{d2,5}|{d3,5}|{khuVuc,2}";
        }
    }
}

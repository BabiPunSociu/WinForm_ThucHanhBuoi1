using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    class XeTai : ThueXe
    {
        public XeTai() { }
        public XeTai(string hoten, float soGioThue) : base(hoten, soGioThue) { }

        public override double tinhTien()
        {
            if (soGioThue < 1)
                return soGioThue * 250000;
            else
                return (soGioThue - 1) * 70000 + 250000;
        }
        public override string hienThi()
        {
            string str = string.Format("{0,-15}|{1,-10}|{2,10}|{3,10}", hoten, "xe tải", soGioThue, tinhTien());
            return str;
        }
    }
}

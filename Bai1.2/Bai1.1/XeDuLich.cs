using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    class XeDuLich : ThueXe
    {
        public XeDuLich() { }
        public XeDuLich(string hoten, float soGioThue):base(hoten, soGioThue) { }

        public override double tinhTien()
        {
            if (soGioThue < 1)
                return soGioThue * 250000;
            else
                return (soGioThue - 1) * 70000 + 250000;
        }
        public override string hienThi()
        {
            string str = string.Format("{0,-15}|{1,-10}|{2,10}|{3,10}",hoten,"xe du lịch",soGioThue,tinhTien());
            return str;
        }
    }
}

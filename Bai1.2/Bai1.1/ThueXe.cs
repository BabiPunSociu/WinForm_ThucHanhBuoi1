using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    abstract class ThueXe
    {
        protected string hoten;
        protected float soGioThue;

        public ThueXe(){}
        public ThueXe(string hoten, float soGioThue)
        {
            this.hoten = hoten;
            this.soGioThue = soGioThue;
        }

        public abstract double tinhTien();
        public abstract string hienThi();
    }
}

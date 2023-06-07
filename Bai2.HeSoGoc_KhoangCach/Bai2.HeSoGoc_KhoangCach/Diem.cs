using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2.HeSoGoc_KhoangCach
{
    internal class Diem
    {
        public float x { get; set; }
        public float y { get; set; }
        public Diem(){}
        public Diem(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public double khoangCach(Diem B)
        {
            float bpkc = (x - B.x)*(x - B.x) + (y - B.y)* (y - B.y);
            return Math.Sqrt(bpkc);
        }
        public double heSoGoc(Diem B)
        {
            return (B.y - y)/(B.x - x);
        }

    }
}

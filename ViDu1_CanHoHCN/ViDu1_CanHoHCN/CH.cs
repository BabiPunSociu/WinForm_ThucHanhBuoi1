using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu1_CanHoHCN
{
    internal class CH
    {
        int maphong;
        HCN kichthuoc = new HCN();
        public HCN Kichthuoc
        {
            set { kichthuoc = value; }
            get { return kichthuoc; }
        }
        public void nhapch()
        {
            Console.Write("\nNhap ma phong: ");
            maphong = int.Parse(Console.ReadLine());
            kichthuoc.nhap();
        }
        public void xuatch()
        {
            Console.Write("\nma phong:" + maphong.ToString());
            kichthuoc.xuat();
            Console.Write("dien tich:" + kichthuoc.tinhdt().ToString());
        }
    }
}

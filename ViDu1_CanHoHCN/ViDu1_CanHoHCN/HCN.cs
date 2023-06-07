using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu1_CanHoHCN
{
    internal class HCN
    {
        double cd, cr;
        public void nhap()
        {
            Console.Write("\nNhap chieu dai: ");
            cd = double.Parse(Console.ReadLine());
            Console.Write("\nNhap chieu rong: ");
            cr = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("cd " + cd.ToString("0.00") + " cr " + cr.ToString("0.00"));
        }
        public double Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        public double Cr
        {
            get { return cr; }
            set { cr = value; }
        }
        public double tinhdt()
        {
            return cd * cr;
        }

    }
}

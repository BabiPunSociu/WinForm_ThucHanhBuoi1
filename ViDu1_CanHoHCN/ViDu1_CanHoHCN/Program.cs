using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu1_CanHoHCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CHNew[] h = new CHNew[200];
            Console.Write("Nhap n: n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap can ho thu " + (i + 1));
                h[i] = new CHNew();
                h[i].nhapCHNew();
            }
            for (int i = 0; i < n; i++)
            {
                h[i].xuatCHNew();
            }
            double max = h[0].Kichthuoc.tinhdt();
            CHNew chmax = h[0];

            for (int i = 1; i < n; i++)
                if (max < h[i].Kichthuoc.tinhdt())
                { 
                    max = h[i].Kichthuoc.tinhdt();
                    chmax = h[i];
                }
            Console.Write("can ho co dien tich max:"); chmax.xuatCHNew();



            string huongTk; bool kq = false;
            Console.Write("Huong ban cong muon tim: ");
            huongTk = Console.ReadLine();
            for (int i = 0; i < n; i++)
                if (huongTk == h[i].HuongBanCong)
                { kq = true; break; }
            if (kq == false) Console.Write("Het can huong ", huongTk);
            else
            {
                Console.WriteLine("\nKQ tim:\n");
                for (int i = 0; i < n; i++)
                    if (string.Compare(huongTk, h[i].HuongBanCong) == 0)
                        h[i].xuatCHNew();
            }
            Console.ReadKey();
        }
    }
}

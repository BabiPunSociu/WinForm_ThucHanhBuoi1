/*
Xây dựng lớp thí sinh:
Thuộc tính: sbd, ht, m1,m2,m3
Phương thức: tạo, nhập, tính tổng điểm
Xây dựng lớp Tuyển sinh kế thừa từ lớp thí sinh:
Thuộc tính bổ sung: Khu vực
Phương thức: Nhập, xuất, Tính tổng điểm:
M1 + m2 + m2 + điểmKV; nếu KV là 1 thì điểmKV là 0, nếu KV là 2 thì điểm KV là 1, nếu KV là 3 thì điểmKV là 2. 
Viết chương trình nhập thông tin cho n thí sinh (sbd, ht, m1, m2, m3, khu vực dự thi (1,2,3)). In Nhập điểm chuẩn và in danh sách trúng tuyển.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bait1_0
{
    class ThiSinh
    {
        protected string sdb;
        protected string ht;
        protected float m1, m2, m3;

        public ThiSinh() {}
        public ThiSinh(string sdb, string ht, float m1, float m2, float m3)
        {
            this.sdb = sdb;
            this.ht = ht;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void nhap()
        {
            Console.Write("\nNhap so bao danh: ");
            sdb = Console.ReadLine();
            Console.Write("\nNhap ho ten: ");
            ht = Console.ReadLine();
            Console.Write("\nNhap diem 3 mon: ");
            string str = Console.ReadLine();
            string[] substr = str.Split(" ");
            m1 = float.Parse(substr[0]);
            m2 = float.Parse(substr[1]);
            m3 = float.Parse(substr[2]);
        }

        public virtual float TinhTong()
        {
            return m1 + m2 + m3;
        }
    }
    class TuyenSinh:ThiSinh
    {
        private int KhuVuc; // 1 2 3

        public TuyenSinh() { }
        public TuyenSinh(string sdb, string ht, float m1, float m2, float m3,int khuVuc):base(sdb,ht,m1,m2,m3)
        {
            KhuVuc = khuVuc;
        }

        public void nhap()
        {
            base.nhap();
            do
            {
                Console.Write("\nNhap khu vuc: ");
                KhuVuc = int.Parse(Console.ReadLine());
            } while (KhuVuc < 1 || KhuVuc > 3);
        }

        public override float TinhTong()
        {
            return base.TinhTong() + KhuVuc;
        }

        public void xuat()
        {
            Console.WriteLine("{0,10}|{1,20}|{2,4}|{3,4}|{4,4}|{5,4}",sdb,ht,m1,m2,m3,TinhTong());
        }
    }
}

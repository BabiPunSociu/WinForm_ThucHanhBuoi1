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
    class Program
    {
        static void Main(string[] args)
        {
            List<TuyenSinh> dsts = new List<TuyenSinh>();
            bool tiepTuc = true;
            do
            {
                TuyenSinh ts = new TuyenSinh();
                ts.nhap();
                dsts.Add(ts);

                Console.Write("\nBan muôn tiep tuc them thi sinh moi không? 'Y' or 'N': ");
                string kq = Console.ReadLine();
                kq.Trim();
                tiepTuc = (kq == "N"? false: true);
            } while (tiepTuc);

            double diemChuan;
            do
            {
                Console.Write("\nNhap diem chuan: ");
                diemChuan = double.Parse(Console.ReadLine());
            }while (diemChuan < 0);

            Console.WriteLine("Nhung thi sinh trung tuyen:");
            foreach(TuyenSinh ts in dsts)
            {
                if (ts.TinhTong() >= diemChuan)
                    ts.xuat();
            }
        }
    }
}
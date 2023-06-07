/*
Bài 1_1: Tạo ứng dụng trên Console như sau
-	Xây dựng lớp sinh viên quản lý Họ tên, Ngày sinh, Điểm thi môn Lập trình, Cơ sở dữ liệu, Thiết kế web.
-	Xây dựng lớp danh sách gồm N sinh viên
-	Đưa ra số lượng sinh viên được làm khoá luận tốt nghiệp; Số lượng sinh viên làm chuyên đề tốt nghiệp
    với các điều kiện:
    Làm khoá luận nếu điểm Trung bình >= 8 và không môn nào dưới 5;
    Làm chuyên đề tốt nghiệp nếu Không có môn nào dưới 5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bai1_1
{
    class Program
    {
        static int khoaLuan(List<SinhVien> ds)
        {
            int count = 0;
            foreach(SinhVien sv in ds)
            {
                if(sv.check_KhoaLuan())
                    count++;
            }    
            return count;
        }

        static int ChuyenDe(List<SinhVien> ds)
        {
            int count = 0;
            foreach (SinhVien sv in ds)
            {
                if (sv.check_ChuyenDe())
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            List<SinhVien> dsSV = new List<SinhVien>();
            bool tiepTuc = true;
            do
            {
                SinhVien sv = new SinhVien();
                sv.nhap();
                dsSV.Add(sv);

                Console.Write("\nBan muon tiep tuc them sinh vien moi? 'y' or 'n'");
                string kq = Console.ReadLine();
                tiepTuc = (kq=="y"? true:false);
            }while(tiepTuc);
            
            dsSV = (from m in dsSV orderby m.hoTen select m).ToList();
            
            Console.WriteLine("Danh sach sinh vien");
            foreach(SinhVien sv in dsSV)
            {
                sv.xuat();
            }    

            Console.WriteLine("So luong KHOA LUAN tot nghiep: " + khoaLuan(dsSV));
            foreach(SinhVien sv in dsSV)
            {
                if (sv.check_KhoaLuan())
                    sv.xuat();
            }

            Console.WriteLine("So luong CHUYEN DE tot nghiep: " + ChuyenDe(dsSV));
            foreach (SinhVien sv in dsSV)
            {
                if (sv.check_ChuyenDe())
                    sv.xuat();
            }
        }
    }
}
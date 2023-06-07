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
    class SinhVien
    {
        public  string hoTen;
        private DateTime ngaySinh;
        private float lTrinh, CSDL, tkWeb;

        public SinhVien() { }
        public SinhVien(string hoTen, DateTime ngaySinh, float lTrinh, float cSDL, float tkWeb)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.lTrinh = lTrinh;
            CSDL = cSDL;
            this.tkWeb = tkWeb;
        }
        
        public void nhap()
        {
            Console.Write("\nNhap ho ten: ");
            hoTen = Console.ReadLine();
            
            Console.Write("\nNhap ngay sinh (dd/MM/yyyy): ");
            string str = Console.ReadLine();
            string[] substr = str.Split('/',' ','.');
            DateTime dt = new DateTime(int.Parse(substr[2]), int.Parse(substr[1]), int.Parse(substr[0]));
            ngaySinh = dt;
             

            Console.Write("\nNhap diem 3 mon hoc: ");
            str = Console.ReadLine();
            string[] Substr = str.Split('/', ' ');
            lTrinh = float.Parse(Substr[0]);
            CSDL = float.Parse(Substr[1]);
            tkWeb = float.Parse(Substr[2]);
        }
        
        public void xuat()
        {
            Console.WriteLine("{0,20}|{1,10}|{2,4}|{3,4}|{4,4}|{5,5}",hoTen,ngaySinh.ToString("dd/MM/yyyy"),lTrinh,CSDL,tkWeb,(lTrinh+CSDL+tkWeb));
        }

        public bool check_KhoaLuan()
        {
            if(lTrinh>5 && CSDL>5 && tkWeb>5 && (lTrinh + CSDL + tkWeb)>=8)
                return true;
            return false;
        }
        public bool check_ChuyenDe()
        {
            if (lTrinh > 5 && CSDL > 5 && tkWeb > 5 && (lTrinh + CSDL + tkWeb) < 8)
                return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    class SinhVien
    {
        protected string hoten { get; set; }
        protected DateTime ngaySinh { get; set; }
        protected float lapTrinh { get; set; }
        protected float CSDL { get; set; }
        protected float TKWeb { get; set; }

        public SinhVien() {}
        public SinhVien(string hoten, DateTime ngaySinh, float lapTrinh, float cSDL, float tKWeb)
        {
            this.hoten = hoten;
            this.ngaySinh = ngaySinh;
            this.lapTrinh = lapTrinh;
            CSDL = cSDL;
            TKWeb = tKWeb;
        }
        public float diemTB()
        {
            return (lapTrinh + CSDL + TKWeb) / 3;
        }
        public string hienThi()
        {
            string dateOfBirth = ngaySinh.ToString("dd/MM/yyyy");
            string str = string.Format("{0,-20}||{1,10}||{2,4}||{3,4}||{4,4}||{5,4}", hoten, dateOfBirth, lapTrinh, CSDL, TKWeb, diemTB());
            return str;
        }
        public string phanLoai()
        {
            if (lapTrinh >= 5 && CSDL >= 5 && TKWeb >= 5)
            {
                if (diemTB() >= 8)
                    return "KL";    // Khóa luận
                return "CD";        // Chuyên đề
            }
            return "Toang";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1._1
{
    public partial class Form1 : Form
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ nhập số
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text.Trim()))
            {
                txtHoTen.Clear();
                txtHoTen.Focus();
                MessageBox.Show("Bạn phải nhập họ tên");
                return;
            }
            if (string.IsNullOrEmpty(txtLapTrinh.Text.Trim()) || float.Parse(txtLapTrinh.Text.Trim())<0 || float.Parse(txtLapTrinh.Text.Trim()) > 10)
            {
                txtLapTrinh.Clear();
                txtLapTrinh.Focus();
                MessageBox.Show("Bạn phải nhập điểm lập trình trong [0->10]");
                return;
            }
            if (string.IsNullOrEmpty(txtCSDL.Text.Trim()) || float.Parse(txtCSDL.Text.Trim()) < 0 || float.Parse(txtCSDL.Text.Trim()) > 10)
            {
                txtCSDL.Clear();
                txtCSDL.Focus();
                MessageBox.Show("Bạn phải nhập điểm cơ sở dữ liệu trong [0->10]");
                return;
            }
            if (string.IsNullOrEmpty(txtTKWeb.Text.Trim()) || float.Parse(txtTKWeb.Text.Trim()) < 0 || float.Parse(txtTKWeb.Text.Trim()) > 10)
            {
                txtTKWeb.Clear();
                txtTKWeb.Focus();
                MessageBox.Show("Bạn phải nhập điểm thiết kế web trong [0->10]");
                return;
            }

            DateTime dt = dateTimePicker.Value;
            SinhVien sv = new SinhVien(txtHoTen.Text.Trim(),dt,float.Parse(txtLapTrinh.Text.Trim()), float.Parse(txtCSDL.Text.Trim()), float.Parse(txtTKWeb.Text.Trim()));
            sinhViens.Add(sv);
            MessageBox.Show("Thêm sinh viên " + txtHoTen.Text.Trim() + " thành công");

            txtHoTen.Clear();
            txtLapTrinh.Clear();
            txtCSDL.Clear();
            txtTKWeb.Clear();
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnKhoaLuan_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
            string str = string.Format("{0,-20}||{1,10}||{2,4}||{3,4}||{4,4}||{5,4}", "Họ tên", "Ngày sinh", "LT", "CSDL", "Web", "TB");
            lstKetQua.Items.Add(str);
            foreach (SinhVien sv in sinhViens)
            {
                if(sv.phanLoai() == "KL")
                {
                    lstKetQua.Items.Add(sv.hienThi());
                }    
            }
            lblSoLuong.Text = "Số lượng sinh viên làm khóa luận tốt nghiệp: " + (lstKetQua.Items.Count-1);
        }

        private void btnChuyenDe_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
            string str = string.Format("{0,-20}||{1,10}||{2,4}||{3,4}||{4,4}||{5,4}", "Họ tên", "Ngày sinh", "LT", "CSDL", "Web", "TB");
            lstKetQua.Items.Add(str);
            foreach (SinhVien sv in sinhViens)
            {
                if (sv.phanLoai() == "CD")
                {
                    lstKetQua.Items.Add(sv.hienThi());
                }
            }
            lblSoLuong.Text = "Số lượng sinh viên làm chuyên đề tốt nghiệp: " + (lstKetQua.Items.Count-1);
        }
    }
}

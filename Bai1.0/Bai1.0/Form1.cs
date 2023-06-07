using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1._0
{
    public partial class Form1 : Form
    {
        List<TuyenSinh> TuyenSinhs = new List<TuyenSinh>();
        List<TuyenSinh> TrungTuyen = new List<TuyenSinh>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_keyPress_Enter(object sender, EventArgs e)
        {
            if (txtSBD.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số báo danh thí sinh");
                txtSBD.Focus();
                return;
            }
            if (txthoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên thí sinh");
                txthoten.Focus();
                return;
            }
            if (txtMon1.Text == "" || double.Parse(txtMon1.Text) > 10 || double.Parse(txtMon1.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập điểm trong đoạn [0-10]");
                txtMon1.Focus();
                return;
            }
            if (txtMon2.Text == "" || double.Parse(txtMon2.Text) > 10 || double.Parse(txtMon2.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập điểm trong đoạn [0-10]");
                txtMon2.Focus();
                return;
            }
            if (txtMon3.Text == "" || double.Parse(txtMon3.Text) > 10 || double.Parse(txtMon3.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập điểm trong đoạn [0-10]");
                txtMon3.Focus();
                return;
            }
            if (txtKhuVuc.Text == "" || int.Parse(txtKhuVuc.Text) > 3 || int.Parse(txtKhuVuc.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập khu vực: 1,2,3");
                txtKhuVuc.Focus();
                return;
            }


            btnThem_Click(sender, e);   // Gọi hàm xử lý thêm thí sinh

        }

        private void nhapSo_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
            if (e.KeyChar == 13)
                txt_keyPress_Enter(sender, e);
        }

        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập số
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 13)
                txt_keyPress_Enter(sender, e);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            // Nhập dữ liệu
            TuyenSinh TuyenSinh = new TuyenSinh(txtSBD.Text.Trim(), txthoten.Text.Trim(),double.Parse(txtMon1.Text.Trim()), double.Parse(txtMon2.Text.Trim()),double.Parse(txtMon3.Text.Trim()), int.Parse(txtKhuVuc.Text.Trim()));

            // Kiểm tra thí sinh đã tồn tại chưa
            foreach (TuyenSinh ts in TuyenSinhs)
            {
                if (TuyenSinh.sbd == ts.sbd)
                {
                    MessageBox.Show($"Số báo danh {TuyenSinh.sbd} đã tồn tại");
                    return;
                }
            }
            // Thêm thí sinh vào list
            TuyenSinhs.Add(TuyenSinh);
            // In danh sách thí sinh
            lblThiSinh.Text = $"{"sbd",-10}|{"Họ và tên",-25}|{"môn 1",5}|{"môn 2",5}|{"môn 3",5}|{"KV",2}";
            
            foreach (TuyenSinh ts in TuyenSinhs)
            {
                lblThiSinh.Text += ts.hienThi();
            }
        }

        private void btnDSTrungTuyen_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDiemChuan.Text) || float.Parse(txtDiemChuan.Text) < 0 || float.Parse(txtDiemChuan.Text) > 30)
            {
                MessageBox.Show("Nhập điểm chuẩn");
                txtDiemChuan.Clear();
                txtDiemChuan.Focus();
                return;
            }    
            TuyenSinh tuyenSinh = new TuyenSinh();
            foreach(TuyenSinh ts in TuyenSinhs)
            {
                if(ts.TinhDiem() >= float.Parse(txtDiemChuan.Text))
                {
                    TrungTuyen.Add(ts);
                }    
            }
            // In danh sách thí sinh trúng tuyển
            lblTrungTuyen.Text = $"{"sbd",-10}|{"Họ và tên",-25}|{"môn 1",5}|{"môn 2",5}|{"môn 3",5}|{"KV",2}";

            foreach (TuyenSinh ts in TrungTuyen)
            {
                lblTrungTuyen.Text += ts.hienThi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}

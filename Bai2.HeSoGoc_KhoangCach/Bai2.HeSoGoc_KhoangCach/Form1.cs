using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2.HeSoGoc_KhoangCach
{
    public partial class Form1 : Form
    {
        Diem A;
        Diem B;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtX1.Text.Trim()))
            {
                txtX1.Clear();
                txtX1.Focus();
                MessageBox.Show("Bạn phải nhập giá trị tọa độ X1");
                return;
            }
            if (string.IsNullOrEmpty(txtY1.Text.Trim()))
            {
                txtY1.Clear();
                txtY1.Focus();
                MessageBox.Show("Bạn phải nhập giá trị tọa độ Y1");
                return;
            }
            if (string.IsNullOrEmpty(txtX2.Text.Trim()))
            {
                txtX2.Clear();
                txtX2.Focus();
                MessageBox.Show("Bạn phải nhập giá trị tọa độ X2");
                return;
            }
            if (string.IsNullOrEmpty(txtY2.Text.Trim()))
            {
                txtY2.Clear();
                txtY2.Focus();
                MessageBox.Show("Bạn phải nhập giá trị tọa độ Y2");
                return;
            }
            // Khởi tạo 2 điểm A, B
            A = new Diem(float.Parse(txtX1.Text.Trim()), float.Parse(txtY1.Text.Trim()));
            B = new Diem(float.Parse(txtX2.Text.Trim()), float.Parse(txtY2.Text.Trim()));
            // Tính toán
            txtHeSoGoc.Text = A.heSoGoc(B).ToString();
            txtKhoangCach.Text = A.khoangCach(B).ToString();
            // Reset các ô textbox
            txtX1.Clear();
            txtY1.Clear();
            txtX2.Clear();
            txtY2.Clear();
            txtX1.Focus();
        }

        private void nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar)))
                e.Handled = true;
            if(e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtX1.Text.Trim()))
                {
                    txtX1.Clear();
                    txtX1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtY1.Text.Trim()))
                {
                    txtY1.Clear();
                    txtY1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtX2.Text.Trim()))
                {
                    txtX2.Clear();
                    txtX2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtY2.Text.Trim()))
                {
                    txtY2.Clear();
                    txtY2.Focus();
                    return;
                }
                btnTinhToan_Click(sender, e);
            }    
        }
    }
}

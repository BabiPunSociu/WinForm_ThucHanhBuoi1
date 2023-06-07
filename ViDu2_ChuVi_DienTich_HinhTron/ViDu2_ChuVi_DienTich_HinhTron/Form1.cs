using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu2_ChuVi_DienTich_HinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
            if(e.KeyChar == 13)
                btnTinh_Click(sender, e);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBanKinh.Text))
            {
                txtBanKinh.Clear();
                txtBanKinh.Focus();
                MessageBox.Show("Bạn phải nhập bán kính !!!");
                return;
            }
            txtChuVi.Text = (2 * Math.PI * (double.Parse(txtBanKinh.Text))).ToString();
            txtDientich.Text = (Math.PI * (double.Parse(txtBanKinh.Text)) * (double.Parse(txtBanKinh.Text)) ).ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDientich.Clear();

            txtBanKinh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}

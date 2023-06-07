using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_GiaiPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
            if(e.KeyChar == 13)
            {
                if(string.IsNullOrEmpty(txtA.Text.Trim()))
                {
                    txtA.Clear();
                    txtA.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtB.Text.Trim()))
                {
                    txtB.Clear();
                    txtB.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtC.Text.Trim()))
                {
                    txtC.Clear();
                    txtC.Focus();
                    return;
                }
                btnGiaiPT_Click(sender, e);
            }    
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtA.Text.Trim()))
            {
                txtA.Clear();
                txtA.Focus();
                MessageBox.Show("Bạn phải nhập hệ số a");
                return;
            }
            if (string.IsNullOrEmpty(txtB.Text.Trim()))
            {
                txtB.Clear();
                txtB.Focus();
                MessageBox.Show("Bạn phải nhập hệ số b");
                return;
            }
            if (string.IsNullOrEmpty(txtC.Text.Trim()))
            {
                txtC.Clear();
                txtC.Focus();
                MessageBox.Show("Bạn phải nhập hệ số c");
                return;
            }

            GiaiPTB2 pt = new GiaiPTB2(float.Parse(txtA.Text.Trim()), float.Parse(txtB.Text.Trim()), float.Parse(txtC.Text.Trim()));
            txtKetQua.Text = pt.GiaiPT();

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.LightPink;
            txt.ForeColor = Color.White;
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }

        private void btnGiaiPT_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightPink;
            btn.ForeColor = Color.White;
        }

        private void btnGiaiPT_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}

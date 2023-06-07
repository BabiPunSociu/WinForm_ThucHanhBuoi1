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
        public Form1()
        {
            InitializeComponent();
        }
        void reset_nhap()
        {
            txtHoten.Clear();
            txtGioThue.Clear();
            rdoDuLich.Checked = false;
            rdoXeTai.Checked = false;
        }
        bool IsTonTai(string s)
        {
            string[] subs = s.Split('|');
            foreach (string str in listBox1.Items)
            {
                string[] substr = str.Split('|');
                if (subs[0] == substr[0] && subs[1] == substr[1] && subs[2] == substr[2] && subs[3] == substr[3])
                    return true;
            }
            return false;
        }
        private void txtGioThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoten.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập họ tên");
                txtHoten.Clear();
                txtHoten.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGioThue.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập số giờ thuê");
                txtGioThue.Clear();
                txtGioThue.Focus();
                return;
            }

            if (rdoDuLich.Checked)
            {
                XeDuLich xe = new XeDuLich(txtHoten.Text.Trim(), float.Parse(txtGioThue.Text.Trim()));
                if (IsTonTai(xe.hienThi()))
                {
                    MessageBox.Show(xe.hienThi() + "đã tồn tại");
                    reset_nhap();
                }
                listBox1.Items.Add(xe.hienThi());
                reset_nhap();
                return;
            }
            if (rdoXeTai.Checked)
            {
                XeTai xe = new XeTai(txtHoten.Text.Trim(), float.Parse(txtGioThue.Text.Trim()));
                if (IsTonTai(xe.hienThi()))
                {
                    MessageBox.Show(xe.hienThi() + "đã tồn tại");
                    reset_nhap();
                }
                listBox1.Items.Add(xe.hienThi());
                return;
            }
            MessageBox.Show("Bạn chưa chọn loại xe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            /////
            string str = string.Format("{0,-15}|{1,-10}|{2,10}|{3,10}", "Họ tên", "Loại xe", "Giờ thuê", "Thành tiền");
            listBox1.Items.Add(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (MessageBox.Show("Bạn chắc chắn muốn sửa dữ liệu không?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtHoten.Text.Trim()))
                {
                    MessageBox.Show("Hãy nhập họ tên");
                    txtHoten.Clear();
                    txtHoten.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtGioThue.Text.Trim()))
                {
                    MessageBox.Show("Hãy nhập số giờ thuê");
                    txtGioThue.Clear();
                    txtGioThue.Focus();
                    return;
                }

                if (rdoDuLich.Checked)
                {
                    XeDuLich xe = new XeDuLich(txtHoten.Text.Trim(), float.Parse(txtGioThue.Text.Trim()));
                    listBox1.Items[index] = xe.hienThi();
                    reset_nhap();
                    return;
                }
                if (rdoXeTai.Checked)
                {
                    XeTai xe = new XeTai(txtHoten.Text.Trim(), float.Parse(txtGioThue.Text.Trim()));
                    listBox1.Items[index] = xe.hienThi();
                    reset_nhap();
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn loại xe");
                }
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu đã chọn lên textbox và radio_button
            int index = listBox1.SelectedIndex;
            string str = listBox1.Items[index].ToString();
            string[] substr = str.Split('|');
            txtHoten.Text = substr[0].Trim();
            txtGioThue.Text = substr[2].Trim();
            if (substr[1] == "xe du lịch")
                rdoDuLich.Checked = true;
            else
                rdoXeTai.Checked = true;

            //////////
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa " + listBox1.Items[index] + " không?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(index);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYHOMESTAY
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btDK_Click(object sender, EventArgs e)
        {

            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap dn = new KiemTraDangNhap();
            Form1 frm = new Form1();
            if (dn.CheckLogin(txtTenDN.Text, txtMK.Text) == 1) // Kiểm tra data từ TextBox và data trong database
            {
                this.Hide(); // Form Đăng Nhập sẽ ẩn đi => MainForm sẽ load lên
                frm.ShowDialog();
            }
            else
            {
                lblThongBao.Text = "Sai Tên Người Dùng hoặc Mật Khẩu. Vui lòng thử lại !!!";
                txtTenDN.Clear();
                txtMK.Clear();
            }
        }
    }
}

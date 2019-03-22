using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYHOMESTAY
{
    public partial class frmDangKy : Form
    {
        AccessData acc;
        public frmDangKy()
        {
            InitializeComponent();
             for (int i = 1; i <= 31; i++)
            {
                this.cbDate.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Ngày : 1 - 31 ngày
            }
 
            for (int i = 0; i <= 12; i++)
            {
                this.cbMonth.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Tháng : 1 - 12 tháng
            }
 
            int curYear = DateTime.Now.Year; // Lấy ra năm hiện tại
            for (int i = curYear; i >= 1900; i--)
            {
                this.cbYear.Items.Add(i.ToString()); // Lấy giá trị cho ComboBox Năm: 1900 - Năm hiên tại
            }
        }

        // Bắt sự kiện cho button SignUp => Insert data vào database
        private void btDangKy_Click(object sender, EventArgs e)
        {
             KiemTraNgayThang n = new KiemTraNgayThang(); // Tạo đối tượng Ngày => Kiểm tra tính hợp lệ của ngày
                if (n.KiemTraHopLe(cbDate, cbMonth, cbYear) == 1)
                {
                    acc = new AccessData();
                    string gender = ""; // Tạo biến gender => Để chứa giá trị Male hoặc Female
                    string birth = ""; // Tạo biến birth => Để chứa ngày tháng năm sinh (12/12/1900)
                    if (this.rdNam.Checked == true)
                    {
                        gender = "Nam"; // Nếu RadioButton Male được check => Lưu Male vào gender
                    }
                    else
                    {
                        if (this.rdNu.Checked == true)
                        {
                            gender = "Nữ"; // Nếu RadioButton Female được check => Lưu Female vào gender
                        }
                    }
                    // Lấy ngày tháng năm từ ComboBox và lưu vào cho biến birth
                    birth = cbDate.SelectedItem.ToString() + "/" + cbMonth.SelectedItem.ToString() + "/" + cbYear.SelectedItem.ToString();
                    //
                    string sql = "INSERT INTO USER_INFO VALUES('" + txtTenDK.Text + "', '" + txtMatKhau.Text + "', '" + txtXNMK.Text + "', '" + txtEmail.Text + "', '" + txtDiaChi.Text + "', '" + gender + "', '" + birth + "')"; // Query Insert data
                    acc.ExcuteNonQuery(sql); // Thực thi Query
                    MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Nếu đang ký thành công => Sẽ có thông báo Thành Công và đồng thời các TextBox sẽ mất giá trị do [B]ClearTextBox()[/B].
                    ClearTextBox();
                }
                else
                {
                    // Nếu ngày tháng ko hợp lê thì nó sẽ hiển thị lại bằng các tên bên dưới.
                    cbDate.Text = "Date:";
                    cbMonth.Text = "Month:";
                    cbYear.Text = "Year:";
                }
         
        }

        private void ClearTextBox()
        {
            txtTenDK.Clear();
            txtMatKhau.Clear();
            txtXNMK.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            cbDate.Text = "Day:";
            cbMonth.Text = "Month:";
            cbYear.Text = "Year:";

        }
   
    }
}

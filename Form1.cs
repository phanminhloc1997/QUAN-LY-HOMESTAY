using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYHOMESTAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KetNoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Open();
                string sql = "select * from tbl_PhieuDK";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi();
        }

        int index;

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtPhieuDK.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtNgayDat.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtNgayTra.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtPhong.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtTienCoc.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }

        string them;
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO tbl_PhieuDK VALUES('" + txtPhieuDK.Text + "','" + txtKH.Text + "','" + txtNgayDat.Text + "','" + txtNgayTra.Text + "','" + txtPhong.Text + "','" + txtTienCoc.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                KetNoi();
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG THÊM ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Close();
            }
        }

        string XoaPhieuDK;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Open();
                XoaPhieuDK = "delete tbl_PhieuDK where MaPDK = '" + txtPhieuDK.Text + "'";
                SqlCommand conn = new SqlCommand(XoaPhieuDK, kn);
                conn.ExecuteNonQuery();
                KetNoi();
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG XÓA ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Close();
            }
        }

        string Sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Open();
                Sua = "update tbl_PhieuDK set MaKhachHang ='" + txtKH.Text + "',NgayDat ='" + txtNgayDat.Text + "',NgayDi ='" + txtNgayTra.Text + "',MaPhong='" + txtPhong.Text + "',TienTraTruoc='" + txtTienCoc.Text + "')";
                SqlCommand commandsua = new SqlCommand(Sua, kn);
                commandsua.ExecuteNonQuery();
                KetNoi();
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG SỬA ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=DemoQLDL;Integrated Security=True");
                kn.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

       

        

       
    }
}

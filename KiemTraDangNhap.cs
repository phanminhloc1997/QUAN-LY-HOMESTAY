using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYHOMESTAY
{
    class KiemTraDangNhap
    {

        public int CheckLogin(string username, string password)
        {
            AccessData acc = new AccessData();
            SqlDataReader reader = acc.ExecuteReader("SELECT TenNguoiDung, MatKhau FROM bangDangNhap");
            while (reader.Read())
            {
                if (reader[0].ToString() == username && reader[1].ToString() == password)
                {
                    // reader[0] tương ứng cho textbox Username
                    // reader[1] tương ứng cho textbox Password
                    return 1;
                }
            }
            return 0;
        }
    }
}

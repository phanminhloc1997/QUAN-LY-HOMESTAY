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
            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QUANLYHOMESTAY1;Integrated Security=True");
            kn.Open();
            string sql = "select * from tb1_PhieuDK";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable table = new DataTable();
            com.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi();
        }

    }
}

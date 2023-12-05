using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NhapBanhMuaNgoai
{
    public partial class FormThemPhieuMuaNgoai : Form
    {
        string tenBanh;
        int ton, soLuong, gia;
        string connectString = "Data Source=LAPTOP-KH6CTEK0\\SQLEXPRESS;Initial Catalog=ABC_bakery;Integrated Security=True";
        public FormThemPhieuMuaNgoai()
        {
            InitializeComponent();
        }

        private void FormThemPhieu_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tenBanh = txtTenBanh.Text;
            ton = int.Parse(txtTon.Text);
            soLuong = int.Parse(txtSoLuong.Text);

            gia = int.Parse(txtGia.Text);
            DateTime ex = DateTime.Now;
            DateTime cr = DateTime.Parse("2023-10-29");
            DateTime up = DateTime.Parse("2023-10-29");

            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            string query = "INSERT INTO products (category_id, name, price, is_active, amount, expiration_date, created_at, updated_at, prefix) VALUES (@Category_id, @Name, @Price, @Is_active, @Amount, @Expiration_date, @Created_at, @Updated_at, @Prefix)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Category_id", 4);
            cmd.Parameters.AddWithValue("@Name", tenBanh);
            cmd.Parameters.AddWithValue("@Price", gia);
            cmd.Parameters.AddWithValue("@Is_active", 1);
            cmd.Parameters.AddWithValue("@Amount", soLuong);
            cmd.Parameters.AddWithValue("@Expiration_date", ex);
            cmd.Parameters.AddWithValue("@Created_at", cr);
            cmd.Parameters.AddWithValue("@Updated_at", up);
            cmd.Parameters.AddWithValue("@Prefix", "SP");

            SqlDataReader myReader = cmd.ExecuteReader();
            MessageBox.Show("Save");
            while (myReader.Read())
            {

            }
            conn.Close();
            this.Close();
        }
    }
}

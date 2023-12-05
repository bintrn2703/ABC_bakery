using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ChiTietTonBanh
{
    public partial class ChiTietTonBanh : Form
    {
        public ChiTietTonBanh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_bakeryDataSet1.ImportInToNhapBanhNoiBo' table. You can move, or remove it, as needed.
            this.importInToNhapBanhNoiBoTableAdapter.Fill(this.aBC_bakeryDataSet1.ImportInToNhapBanhNoiBo);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng PrintDocument mới.
            PrintDocument pd = new PrintDocument();

            // Đặt sự kiện PrintPage.
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

            // Gọi phương thức Print của PrintDocument để bắt đầu in.
            pd.Print();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Vẽ DataGridView lên trang in.
            // this.dataGridView1.DrawToBitmap(e.Graphics);

            // Tạo một đối tượng Bitmap mới với kích thước của DataGridView.
            Bitmap bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            // Tạo một đối tượng Rectangle mới với kích thước của DataGridView.
            Rectangle rectangle = new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height);

            // Gọi phương thức DrawToBitmap với các tham số phù hợp.
            dataGridView1.DrawToBitmap(bitmap, rectangle);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

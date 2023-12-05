using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Drawing.Printing;

namespace ChiTietTonBanh
{
    using System;
    using System.Data;
    using System.IO;
    using System.Windows.Forms;
    using OfficeOpenXml;

    public partial class FormChiTietBanHangThuTienMat : Form
    {
        public String connectString = "Data Source=ASUS-X541U;Initial Catalog=ABC_bakery;Integrated Security=True";
        public FormChiTietBanHangThuTienMat()
        {
            InitializeComponent();

        }

        private void FormChiTietBanHangThuTienMat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_bakeryDataSet_chiTietBanHangThuTienMat.chiTietBanBanhThuTienMat' table. You can move, or remove it, as needed.
            this.chiTietBanBanhThuTienMatTableAdapter.Fill(this.aBC_bakeryDataSet_chiTietBanHangThuTienMat.chiTietBanBanhThuTienMat);
            
        }

        private void total_tb_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < chiTietBanHangThuTienMat_dataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(chiTietBanHangThuTienMat_dataGridView.Rows[i].Cells[5].Value);
            }
            total_tb.Text = sum.ToString();

        }

        private void total_tb_load()
        {
            int sum = 0;
            for (int i = 0; i < chiTietBanHangThuTienMat_dataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(chiTietBanHangThuTienMat_dataGridView.Rows[i].Cells[5].Value);
            }
            total_tb.Text = sum.ToString();
        }

        

        private void print_btn_Click(object sender, EventArgs e)
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
            // Tạo một đối tượng Bitmap mới với kích thước của DataGridView.
            Bitmap bitmap = new Bitmap(chiTietBanHangThuTienMat_dataGridView.Width, chiTietBanHangThuTienMat_dataGridView.Height);

            // Tạo một đối tượng Rectangle mới với kích thước của DataGridView.
            Rectangle rectangle = new Rectangle(0, 0, chiTietBanHangThuTienMat_dataGridView.Width, chiTietBanHangThuTienMat_dataGridView.Height);

            // Gọi phương thức DrawToBitmap với các tham số phù hợp.
            chiTietBanHangThuTienMat_dataGridView.DrawToBitmap(bitmap, rectangle);

            // Vẽ Bitmap lên đối tượng Graphics của sự kiện PrintPage.
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void copyAlltoClipboard()
        {
            chiTietBanHangThuTienMat_dataGridView.SelectAll();
            DataObject dataObj = chiTietBanHangThuTienMat_dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "ExportedData.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelExporter.ExportToExcel(chiTietBanHangThuTienMat_dataGridView, saveFileDialog.FileName);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            total_tb_load();
        }
    }

    public static class ExcelExporter
    {
        public static void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                DataTable dataTable = new DataTable();

                // Add columns to the DataTable
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
                }

                // Add rows to the DataTable
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            dataRow[cell.ColumnIndex] = DBNull.Value;
                        }
                        else
                        {
                            dataRow[cell.ColumnIndex] = cell.Value;
                        }
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Export DataTable to Excel
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("ExportedData");
                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                    // Save the Excel file
                    excelPackage.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Xuất file Excel thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}

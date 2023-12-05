using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiTietTonBanh
{
    public partial class FormChiTietBanHangThuTienMat : Form
    {
        public FormChiTietBanHangThuTienMat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChiTietBanHangThuTienMat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_bakeryDataSet_chiTietBanHangThuTienMat.chiTietBanBanhThuTienMat' table. You can move, or remove it, as needed.
            this.chiTietBanBanhThuTienMatTableAdapter.Fill(this.aBC_bakeryDataSet_chiTietBanHangThuTienMat.chiTietBanBanhThuTienMat);

        }


    }
}

﻿using ABC_bakery;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiTietTonBanh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ChiTietTonBanh());
            //Application.Run(new FormChiTietBanHangThuTienMat());
            //Application.Run(new FormChiTietTonBanhTrungThuThuTienMat());
            //Application.Run(new DanhMucKhachHang());
            //Application.Run(new FormChiTietBanBanhNoelThuTienMat());
            Application.Run(new form_danhMucBanh());
        }
    }
}

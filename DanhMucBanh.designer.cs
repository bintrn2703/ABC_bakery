using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery
{
    partial class form_danhMucBanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_danhMucBanh = new System.Windows.Forms.Label();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_xuatExcel = new System.Windows.Forms.Button();
            this.btn_inDanhSach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_themBanh = new System.Windows.Forms.Label();
            this.lb_themTenBanh = new System.Windows.Forms.Label();
            this.lb_themGiaMua = new System.Windows.Forms.Label();
            this.lb_themGiaBan = new System.Windows.Forms.Label();
            this.lb_themLoaiBanh = new System.Windows.Forms.Label();
            this.lb_themDonVi = new System.Windows.Forms.Label();
            this.txt_themTenBanh = new System.Windows.Forms.TextBox();
            this.txt_themGiaMua = new System.Windows.Forms.TextBox();
            this.txt_themGiaBan = new System.Windows.Forms.TextBox();
            this.txt_themLoaiBanh = new System.Windows.Forms.TextBox();
            this.txt_themDonVi = new System.Windows.Forms.TextBox();
            this.txt_suaDonVi = new System.Windows.Forms.TextBox();
            this.txt_suaLoaiBanh = new System.Windows.Forms.TextBox();
            this.txt_suaGiaBan = new System.Windows.Forms.TextBox();
            this.txt_suaGiaMua = new System.Windows.Forms.TextBox();
            this.txt_suaTenBanh = new System.Windows.Forms.TextBox();
            this.lb_suaDonVi = new System.Windows.Forms.Label();
            this.lb_suaLoaiBanh = new System.Windows.Forms.Label();
            this.lb_suaGiaBan = new System.Windows.Forms.Label();
            this.lb_suaGiaMua = new System.Windows.Forms.Label();
            this.lb_suaTenBanh = new System.Windows.Forms.Label();
            this.lb_suaBanh = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.column_loaiBanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_tenBanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_donVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_giaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_hien = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_danhMucBanh
            // 
            this.lb_danhMucBanh.AutoSize = true;
            this.lb_danhMucBanh.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_danhMucBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_danhMucBanh.Location = new System.Drawing.Point(426, 12);
            this.lb_danhMucBanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_danhMucBanh.Name = "lb_danhMucBanh";
            this.lb_danhMucBanh.Size = new System.Drawing.Size(211, 28);
            this.lb_danhMucBanh.TabIndex = 0;
            this.lb_danhMucBanh.Text = "Danh Mục Bánh";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_timKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_timKiem.Location = new System.Drawing.Point(174, 41);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(138, 30);
            this.btn_timKiem.TabIndex = 1;
            this.btn_timKiem.Text = "Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            // 
            // btn_xuatExcel
            // 
            this.btn_xuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_xuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuatExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_xuatExcel.Location = new System.Drawing.Point(1069, 41);
            this.btn_xuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xuatExcel.Name = "btn_xuatExcel";
            this.btn_xuatExcel.Size = new System.Drawing.Size(210, 36);
            this.btn_xuatExcel.TabIndex = 2;
            this.btn_xuatExcel.Text = "Xuất Excel";
            this.btn_xuatExcel.UseVisualStyleBackColor = false;
            // 
            // btn_inDanhSach
            // 
            this.btn_inDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_inDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inDanhSach.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_inDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_inDanhSach.Location = new System.Drawing.Point(792, 41);
            this.btn_inDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inDanhSach.Name = "btn_inDanhSach";
            this.btn_inDanhSach.Size = new System.Drawing.Size(240, 36);
            this.btn_inDanhSach.TabIndex = 3;
            this.btn_inDanhSach.Text = "In Danh Sách";
            this.btn_inDanhSach.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_loaiBanh,
            this.column_ma,
            this.column_tenBanh,
            this.column_donVi,
            this.column_giaMua,
            this.column_giaBan,
            this.column_hien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridView1.Location = new System.Drawing.Point(-5, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 438);
            this.dataGridView1.TabIndex = 4;
            // 
            // lb_themBanh
            // 
            this.lb_themBanh.AutoSize = true;
            this.lb_themBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themBanh.Location = new System.Drawing.Point(152, 536);
            this.lb_themBanh.Name = "lb_themBanh";
            this.lb_themBanh.Size = new System.Drawing.Size(124, 22);
            this.lb_themBanh.TabIndex = 5;
            this.lb_themBanh.Text = "Thêm Bánh";
            // 
            // lb_themTenBanh
            // 
            this.lb_themTenBanh.AutoSize = true;
            this.lb_themTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themTenBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themTenBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themTenBanh.Location = new System.Drawing.Point(12, 578);
            this.lb_themTenBanh.Name = "lb_themTenBanh";
            this.lb_themTenBanh.Size = new System.Drawing.Size(105, 22);
            this.lb_themTenBanh.TabIndex = 6;
            this.lb_themTenBanh.Text = "Tên Bánh";
            // 
            // lb_themGiaMua
            // 
            this.lb_themGiaMua.AutoSize = true;
            this.lb_themGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themGiaMua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themGiaMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themGiaMua.Location = new System.Drawing.Point(21, 608);
            this.lb_themGiaMua.Name = "lb_themGiaMua";
            this.lb_themGiaMua.Size = new System.Drawing.Size(91, 22);
            this.lb_themGiaMua.TabIndex = 7;
            this.lb_themGiaMua.Text = "Giá Mua";
            // 
            // lb_themGiaBan
            // 
            this.lb_themGiaBan.AutoSize = true;
            this.lb_themGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themGiaBan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themGiaBan.Location = new System.Drawing.Point(24, 637);
            this.lb_themGiaBan.Name = "lb_themGiaBan";
            this.lb_themGiaBan.Size = new System.Drawing.Size(88, 22);
            this.lb_themGiaBan.TabIndex = 8;
            this.lb_themGiaBan.Text = "Giá Bán";
            // 
            // lb_themLoaiBanh
            // 
            this.lb_themLoaiBanh.AutoSize = true;
            this.lb_themLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themLoaiBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themLoaiBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themLoaiBanh.Location = new System.Drawing.Point(8, 667);
            this.lb_themLoaiBanh.Name = "lb_themLoaiBanh";
            this.lb_themLoaiBanh.Size = new System.Drawing.Size(109, 22);
            this.lb_themLoaiBanh.TabIndex = 9;
            this.lb_themLoaiBanh.Text = "Loại Bánh";
            // 
            // lb_themDonVi
            // 
            this.lb_themDonVi.AutoSize = true;
            this.lb_themDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_themDonVi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_themDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_themDonVi.Location = new System.Drawing.Point(293, 574);
            this.lb_themDonVi.Name = "lb_themDonVi";
            this.lb_themDonVi.Size = new System.Drawing.Size(76, 22);
            this.lb_themDonVi.TabIndex = 10;
            this.lb_themDonVi.Text = "Đơn Vị";
            // 
            // txt_themTenBanh
            // 
            this.txt_themTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_themTenBanh.Location = new System.Drawing.Point(123, 574);
            this.txt_themTenBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_themTenBanh.Name = "txt_themTenBanh";
            this.txt_themTenBanh.Size = new System.Drawing.Size(153, 26);
            this.txt_themTenBanh.TabIndex = 11;
            // 
            // txt_themGiaMua
            // 
            this.txt_themGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_themGiaMua.Location = new System.Drawing.Point(123, 604);
            this.txt_themGiaMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_themGiaMua.Name = "txt_themGiaMua";
            this.txt_themGiaMua.Size = new System.Drawing.Size(153, 26);
            this.txt_themGiaMua.TabIndex = 12;
            // 
            // txt_themGiaBan
            // 
            this.txt_themGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_themGiaBan.Location = new System.Drawing.Point(123, 633);
            this.txt_themGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_themGiaBan.Name = "txt_themGiaBan";
            this.txt_themGiaBan.Size = new System.Drawing.Size(153, 26);
            this.txt_themGiaBan.TabIndex = 13;
            // 
            // txt_themLoaiBanh
            // 
            this.txt_themLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_themLoaiBanh.Location = new System.Drawing.Point(123, 663);
            this.txt_themLoaiBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_themLoaiBanh.Name = "txt_themLoaiBanh";
            this.txt_themLoaiBanh.Size = new System.Drawing.Size(153, 26);
            this.txt_themLoaiBanh.TabIndex = 14;
            // 
            // txt_themDonVi
            // 
            this.txt_themDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_themDonVi.Location = new System.Drawing.Point(384, 573);
            this.txt_themDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_themDonVi.Name = "txt_themDonVi";
            this.txt_themDonVi.Size = new System.Drawing.Size(75, 26);
            this.txt_themDonVi.TabIndex = 15;
            // 
            // txt_suaDonVi
            // 
            this.txt_suaDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaDonVi.Location = new System.Drawing.Point(1072, 579);
            this.txt_suaDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaDonVi.Name = "txt_suaDonVi";
            this.txt_suaDonVi.Size = new System.Drawing.Size(75, 26);
            this.txt_suaDonVi.TabIndex = 26;
            // 
            // txt_suaLoaiBanh
            // 
            this.txt_suaLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaLoaiBanh.Location = new System.Drawing.Point(1284, 667);
            this.txt_suaLoaiBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaLoaiBanh.Name = "txt_suaLoaiBanh";
            this.txt_suaLoaiBanh.Size = new System.Drawing.Size(153, 26);
            this.txt_suaLoaiBanh.TabIndex = 25;
            // 
            // txt_suaGiaBan
            // 
            this.txt_suaGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaGiaBan.Location = new System.Drawing.Point(1284, 637);
            this.txt_suaGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaGiaBan.Name = "txt_suaGiaBan";
            this.txt_suaGiaBan.Size = new System.Drawing.Size(153, 26);
            this.txt_suaGiaBan.TabIndex = 24;
            // 
            // txt_suaGiaMua
            // 
            this.txt_suaGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaGiaMua.Location = new System.Drawing.Point(1284, 608);
            this.txt_suaGiaMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaGiaMua.Name = "txt_suaGiaMua";
            this.txt_suaGiaMua.Size = new System.Drawing.Size(153, 26);
            this.txt_suaGiaMua.TabIndex = 23;
            // 
            // txt_suaTenBanh
            // 
            this.txt_suaTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.txt_suaTenBanh.Location = new System.Drawing.Point(1284, 578);
            this.txt_suaTenBanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_suaTenBanh.Name = "txt_suaTenBanh";
            this.txt_suaTenBanh.Size = new System.Drawing.Size(153, 26);
            this.txt_suaTenBanh.TabIndex = 22;
            // 
            // lb_suaDonVi
            // 
            this.lb_suaDonVi.AutoSize = true;
            this.lb_suaDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaDonVi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaDonVi.Location = new System.Drawing.Point(986, 583);
            this.lb_suaDonVi.Name = "lb_suaDonVi";
            this.lb_suaDonVi.Size = new System.Drawing.Size(76, 22);
            this.lb_suaDonVi.TabIndex = 21;
            this.lb_suaDonVi.Text = "Đơn Vị";
            this.lb_suaDonVi.Click += new System.EventHandler(this.lb_suaDonVi_Click);
            // 
            // lb_suaLoaiBanh
            // 
            this.lb_suaLoaiBanh.AutoSize = true;
            this.lb_suaLoaiBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaLoaiBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaLoaiBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaLoaiBanh.Location = new System.Drawing.Point(1170, 668);
            this.lb_suaLoaiBanh.Name = "lb_suaLoaiBanh";
            this.lb_suaLoaiBanh.Size = new System.Drawing.Size(109, 22);
            this.lb_suaLoaiBanh.TabIndex = 20;
            this.lb_suaLoaiBanh.Text = "Loại Bánh";
            // 
            // lb_suaGiaBan
            // 
            this.lb_suaGiaBan.AutoSize = true;
            this.lb_suaGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaGiaBan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaGiaBan.Location = new System.Drawing.Point(1186, 638);
            this.lb_suaGiaBan.Name = "lb_suaGiaBan";
            this.lb_suaGiaBan.Size = new System.Drawing.Size(88, 22);
            this.lb_suaGiaBan.TabIndex = 19;
            this.lb_suaGiaBan.Text = "Giá Bán";
            // 
            // lb_suaGiaMua
            // 
            this.lb_suaGiaMua.AutoSize = true;
            this.lb_suaGiaMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaGiaMua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaGiaMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaGiaMua.Location = new System.Drawing.Point(1183, 609);
            this.lb_suaGiaMua.Name = "lb_suaGiaMua";
            this.lb_suaGiaMua.Size = new System.Drawing.Size(91, 22);
            this.lb_suaGiaMua.TabIndex = 18;
            this.lb_suaGiaMua.Text = "Giá Mua";
            // 
            // lb_suaTenBanh
            // 
            this.lb_suaTenBanh.AutoSize = true;
            this.lb_suaTenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaTenBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaTenBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaTenBanh.Location = new System.Drawing.Point(1173, 579);
            this.lb_suaTenBanh.Name = "lb_suaTenBanh";
            this.lb_suaTenBanh.Size = new System.Drawing.Size(105, 22);
            this.lb_suaTenBanh.TabIndex = 17;
            this.lb_suaTenBanh.Text = "Tên Bánh";
            // 
            // lb_suaBanh
            // 
            this.lb_suaBanh.AutoSize = true;
            this.lb_suaBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.lb_suaBanh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lb_suaBanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lb_suaBanh.Location = new System.Drawing.Point(1183, 536);
            this.lb_suaBanh.Name = "lb_suaBanh";
            this.lb_suaBanh.Size = new System.Drawing.Size(107, 22);
            this.lb_suaBanh.TabIndex = 16;
            this.lb_suaBanh.Text = "Sửa Bánh";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btn_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_them.Location = new System.Drawing.Point(310, 617);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 64);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_sua.Location = new System.Drawing.Point(990, 622);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 64);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // column_loaiBanh
            // 
            this.column_loaiBanh.FillWeight = 200F;
            this.column_loaiBanh.HeaderText = "Loại Bánh";
            this.column_loaiBanh.MinimumWidth = 8;
            this.column_loaiBanh.Name = "column_loaiBanh";
            this.column_loaiBanh.Width = 300;
            // 
            // column_ma
            // 
            this.column_ma.HeaderText = "Mã";
            this.column_ma.MinimumWidth = 8;
            this.column_ma.Name = "column_ma";
            this.column_ma.Width = 150;
            // 
            // column_tenBanh
            // 
            this.column_tenBanh.HeaderText = "Tên Bánh";
            this.column_tenBanh.MinimumWidth = 8;
            this.column_tenBanh.Name = "column_tenBanh";
            this.column_tenBanh.Width = 400;
            // 
            // column_donVi
            // 
            this.column_donVi.HeaderText = "Đơn Vị";
            this.column_donVi.MinimumWidth = 8;
            this.column_donVi.Name = "column_donVi";
            this.column_donVi.Width = 150;
            // 
            // column_giaMua
            // 
            this.column_giaMua.HeaderText = "Giá Mua";
            this.column_giaMua.MinimumWidth = 8;
            this.column_giaMua.Name = "column_giaMua";
            this.column_giaMua.Width = 150;
            // 
            // column_giaBan
            // 
            this.column_giaBan.HeaderText = "Giá Bán";
            this.column_giaBan.MinimumWidth = 8;
            this.column_giaBan.Name = "column_giaBan";
            this.column_giaBan.Width = 150;
            // 
            // column_hien
            // 
            this.column_hien.HeaderText = "Hiện";
            this.column_hien.MinimumWidth = 8;
            this.column_hien.Name = "column_hien";
            this.column_hien.Width = 60;
            // 
            // form_danhMucBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1438, 709);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_suaDonVi);
            this.Controls.Add(this.txt_suaLoaiBanh);
            this.Controls.Add(this.txt_suaGiaBan);
            this.Controls.Add(this.txt_suaGiaMua);
            this.Controls.Add(this.txt_suaTenBanh);
            this.Controls.Add(this.lb_suaDonVi);
            this.Controls.Add(this.lb_suaLoaiBanh);
            this.Controls.Add(this.lb_suaGiaBan);
            this.Controls.Add(this.lb_suaGiaMua);
            this.Controls.Add(this.lb_suaTenBanh);
            this.Controls.Add(this.lb_suaBanh);
            this.Controls.Add(this.txt_themDonVi);
            this.Controls.Add(this.txt_themLoaiBanh);
            this.Controls.Add(this.txt_themGiaBan);
            this.Controls.Add(this.txt_themGiaMua);
            this.Controls.Add(this.txt_themTenBanh);
            this.Controls.Add(this.lb_themDonVi);
            this.Controls.Add(this.lb_themLoaiBanh);
            this.Controls.Add(this.lb_themGiaBan);
            this.Controls.Add(this.lb_themGiaMua);
            this.Controls.Add(this.lb_themTenBanh);
            this.Controls.Add(this.lb_themBanh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_inDanhSach);
            this.Controls.Add(this.btn_xuatExcel);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.lb_danhMucBanh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_danhMucBanh";
            this.Text = "Danh Mục Bánh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_danhMucBanh;
        private Button btn_timKiem;
        private Button btn_xuatExcel;
        private Button btn_inDanhSach;
        private DataGridView dataGridView1;
        private Label lb_themBanh;
        private Label lb_themTenBanh;
        private Label lb_themGiaMua;
        private Label lb_themGiaBan;
        private Label lb_themLoaiBanh;
        private Label lb_themDonVi;
        private TextBox txt_themTenBanh;
        private TextBox txt_themGiaMua;
        private TextBox txt_themGiaBan;
        private TextBox txt_themLoaiBanh;
        private TextBox txt_themDonVi;
        private TextBox txt_suaDonVi;
        private TextBox txt_suaLoaiBanh;
        private TextBox txt_suaGiaBan;
        private TextBox txt_suaGiaMua;
        private TextBox txt_suaTenBanh;
        private Label lb_suaDonVi;
        private Label lb_suaLoaiBanh;
        private Label lb_suaGiaBan;
        private Label lb_suaGiaMua;
        private Label lb_suaTenBanh;
        private Label lb_suaBanh;
        private Button btn_them;
        private Button btn_sua;
        private DataGridViewTextBoxColumn column_loaiBanh;
        private DataGridViewTextBoxColumn column_ma;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_donVi;
        private DataGridViewTextBoxColumn column_giaMua;
        private DataGridViewTextBoxColumn column_giaBan;
        private DataGridViewCheckBoxColumn column_hien;
    }
}
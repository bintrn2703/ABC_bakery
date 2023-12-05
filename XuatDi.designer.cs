using System.Drawing;
using System.Windows.Forms;

namespace ABC_bakery
{
    partial class form_XuatDi
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
            this.lb_maPhieu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoaPhieu = new System.Windows.Forms.Button();
            this.btn_themPhieu = new System.Windows.Forms.Button();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.txt_tongSoLuong = new System.Windows.Forms.TextBox();
            this.txt_tongTienHang = new System.Windows.Forms.TextBox();
            this.lb_ghiChu = new System.Windows.Forms.Label();
            this.lb_tongSoLuong = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.column_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.column_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_donVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_tenBanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.column_thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_after = new System.Windows.Forms.Button();
            this.btn_before = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_maPhieu = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_xuatCho = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_luuGhiChu = new System.Windows.Forms.Button();
            this.lb_PhieuXuatDi = new System.Windows.Forms.Label();
            this.lb_tongTienHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_maPhieu
            // 
            this.lb_maPhieu.AutoSize = true;
            this.lb_maPhieu.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_maPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_maPhieu.Location = new System.Drawing.Point(46, 58);
            this.lb_maPhieu.Name = "lb_maPhieu";
            this.lb_maPhieu.Size = new System.Drawing.Size(119, 29);
            this.lb_maPhieu.TabIndex = 77;
            this.lb_maPhieu.Text = "Mã Phiếu";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(927, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 99;
            this.button1.Text = "Đổi Ngày";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_xoaPhieu
            // 
            this.btn_xoaPhieu.Location = new System.Drawing.Point(406, 520);
            this.btn_xoaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoaPhieu.Name = "btn_xoaPhieu";
            this.btn_xoaPhieu.Size = new System.Drawing.Size(85, 76);
            this.btn_xoaPhieu.TabIndex = 97;
            this.btn_xoaPhieu.Text = "Xóa Phiếu";
            this.btn_xoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btn_themPhieu
            // 
            this.btn_themPhieu.Location = new System.Drawing.Point(294, 520);
            this.btn_themPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themPhieu.Name = "btn_themPhieu";
            this.btn_themPhieu.Size = new System.Drawing.Size(85, 76);
            this.btn_themPhieu.TabIndex = 96;
            this.btn_themPhieu.Text = "Thêm Phiếu";
            this.btn_themPhieu.UseVisualStyleBackColor = true;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(0, 564);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(169, 26);
            this.txt_ghiChu.TabIndex = 95;
            // 
            // txt_tongSoLuong
            // 
            this.txt_tongSoLuong.Location = new System.Drawing.Point(544, 476);
            this.txt_tongSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongSoLuong.Name = "txt_tongSoLuong";
            this.txt_tongSoLuong.Size = new System.Drawing.Size(181, 26);
            this.txt_tongSoLuong.TabIndex = 94;
            // 
            // txt_tongTienHang
            // 
            this.txt_tongTienHang.Location = new System.Drawing.Point(176, 476);
            this.txt_tongTienHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongTienHang.Name = "txt_tongTienHang";
            this.txt_tongTienHang.Size = new System.Drawing.Size(181, 26);
            this.txt_tongTienHang.TabIndex = 93;
            // 
            // lb_ghiChu
            // 
            this.lb_ghiChu.AutoSize = true;
            this.lb_ghiChu.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_ghiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_ghiChu.Location = new System.Drawing.Point(0, 518);
            this.lb_ghiChu.Name = "lb_ghiChu";
            this.lb_ghiChu.Size = new System.Drawing.Size(108, 29);
            this.lb_ghiChu.TabIndex = 92;
            this.lb_ghiChu.Text = "Ghi Chú";
            // 
            // lb_tongSoLuong
            // 
            this.lb_tongSoLuong.AutoSize = true;
            this.lb_tongSoLuong.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_tongSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_tongSoLuong.Location = new System.Drawing.Point(366, 482);
            this.lb_tongSoLuong.Name = "lb_tongSoLuong";
            this.lb_tongSoLuong.Size = new System.Drawing.Size(194, 29);
            this.lb_tongSoLuong.TabIndex = 91;
            this.lb_tongSoLuong.Text = "Tổng Số Lượng";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(522, 520);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(85, 76);
            this.btn_in.TabIndex = 98;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // column_xoa
            // 
            this.column_xoa.HeaderText = "Xóa";
            this.column_xoa.MinimumWidth = 8;
            this.column_xoa.Name = "column_xoa";
            this.column_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.column_xoa.UseColumnTextForButtonValue = true;
            this.column_xoa.Width = 150;
            // 
            // column_gia
            // 
            this.column_gia.HeaderText = "Giá";
            this.column_gia.MinimumWidth = 8;
            this.column_gia.Name = "column_gia";
            this.column_gia.Width = 150;
            // 
            // column_donVi
            // 
            this.column_donVi.HeaderText = "Đơn Vị";
            this.column_donVi.MinimumWidth = 8;
            this.column_donVi.Name = "column_donVi";
            this.column_donVi.Width = 150;
            // 
            // column_soLuong
            // 
            this.column_soLuong.HeaderText = "Số Lượng";
            this.column_soLuong.MinimumWidth = 8;
            this.column_soLuong.Name = "column_soLuong";
            this.column_soLuong.Width = 150;
            // 
            // column_tong
            // 
            this.column_tong.HeaderText = "Tổng";
            this.column_tong.MinimumWidth = 8;
            this.column_tong.Name = "column_tong";
            this.column_tong.Width = 150;
            // 
            // column_tenBanh
            // 
            this.column_tenBanh.HeaderText = "Tên Bánh";
            this.column_tenBanh.MinimumWidth = 8;
            this.column_tenBanh.Name = "column_tenBanh";
            this.column_tenBanh.Width = 150;
            // 
            // column_ma
            // 
            this.column_ma.HeaderText = "Mã";
            this.column_ma.MinimumWidth = 8;
            this.column_ma.Name = "column_ma";
            this.column_ma.Width = 150;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ma,
            this.column_tenBanh,
            this.column_tong,
            this.column_soLuong,
            this.column_donVi,
            this.column_gia,
            this.column_thanhTien,
            this.column_xoa});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(-9, 114);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1047, 354);
            this.dataGridView.TabIndex = 89;
            // 
            // column_thanhTien
            // 
            this.column_thanhTien.HeaderText = "Thành Tiền";
            this.column_thanhTien.MinimumWidth = 8;
            this.column_thanhTien.Name = "column_thanhTien";
            this.column_thanhTien.Width = 150;
            // 
            // btn_after
            // 
            this.btn_after.BackgroundImage = global::ChiTietTonBanh.Properties.Resources.rightArrow;
            this.btn_after.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_after.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_after.Location = new System.Drawing.Point(388, 52);
            this.btn_after.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_after.Name = "btn_after";
            this.btn_after.Size = new System.Drawing.Size(40, 32);
            this.btn_after.TabIndex = 88;
            this.btn_after.Text = " ";
            this.btn_after.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_after.UseVisualStyleBackColor = true;
            // 
            // btn_before
            // 
            this.btn_before.BackgroundImage = global::ChiTietTonBanh.Properties.Resources.leftArrow;
            this.btn_before.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_before.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_before.Location = new System.Drawing.Point(348, 52);
            this.btn_before.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_before.Name = "btn_before";
            this.btn_before.Size = new System.Drawing.Size(40, 32);
            this.btn_before.TabIndex = 87;
            this.btn_before.Text = " ";
            this.btn_before.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_before.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(910, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 26);
            this.textBox2.TabIndex = 86;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 85;
            // 
            // txt_maPhieu
            // 
            this.txt_maPhieu.Location = new System.Drawing.Point(158, 52);
            this.txt_maPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maPhieu.Name = "txt_maPhieu";
            this.txt_maPhieu.Size = new System.Drawing.Size(181, 26);
            this.txt_maPhieu.TabIndex = 84;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChiTietTonBanh.Properties.Resources.bread;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(715, 46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 38);
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // lb_xuatCho
            // 
            this.lb_xuatCho.AutoSize = true;
            this.lb_xuatCho.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_xuatCho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_xuatCho.Location = new System.Drawing.Point(770, 60);
            this.lb_xuatCho.Name = "lb_xuatCho";
            this.lb_xuatCho.Size = new System.Drawing.Size(122, 29);
            this.lb_xuatCho.TabIndex = 82;
            this.lb_xuatCho.Text = "Xuất Cho";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ChiTietTonBanh.Properties.Resources.bread;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(436, 45);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_ngay.Location = new System.Drawing.Point(492, 58);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(74, 29);
            this.lb_ngay.TabIndex = 80;
            this.lb_ngay.Text = "Ngày";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChiTietTonBanh.Properties.Resources.bread;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btn_luuGhiChu
            // 
            this.btn_luuGhiChu.Location = new System.Drawing.Point(182, 520);
            this.btn_luuGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luuGhiChu.Name = "btn_luuGhiChu";
            this.btn_luuGhiChu.Size = new System.Drawing.Size(85, 76);
            this.btn_luuGhiChu.TabIndex = 78;
            this.btn_luuGhiChu.Text = "Lưu     Ghi Chú";
            this.btn_luuGhiChu.UseVisualStyleBackColor = true;
            // 
            // lb_PhieuXuatDi
            // 
            this.lb_PhieuXuatDi.AutoSize = true;
            this.lb_PhieuXuatDi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lb_PhieuXuatDi.Location = new System.Drawing.Point(430, 10);
            this.lb_PhieuXuatDi.Name = "lb_PhieuXuatDi";
            this.lb_PhieuXuatDi.Size = new System.Drawing.Size(195, 29);
            this.lb_PhieuXuatDi.TabIndex = 76;
            this.lb_PhieuXuatDi.Text = "Phiếu Xuất Đi";
            // 
            // lb_tongTienHang
            // 
            this.lb_tongTienHang.AutoSize = true;
            this.lb_tongTienHang.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_tongTienHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.lb_tongTienHang.Location = new System.Drawing.Point(0, 482);
            this.lb_tongTienHang.Name = "lb_tongTienHang";
            this.lb_tongTienHang.Size = new System.Drawing.Size(201, 29);
            this.lb_tongTienHang.TabIndex = 90;
            this.lb_tongTienHang.Text = "Tổng Tiền Hàng";
            // 
            // form_XuatDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(199)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1063, 600);
            this.Controls.Add(this.lb_maPhieu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_xoaPhieu);
            this.Controls.Add(this.btn_themPhieu);
            this.Controls.Add(this.txt_ghiChu);
            this.Controls.Add(this.txt_tongSoLuong);
            this.Controls.Add(this.txt_tongTienHang);
            this.Controls.Add(this.lb_ghiChu);
            this.Controls.Add(this.lb_tongSoLuong);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_after);
            this.Controls.Add(this.btn_before);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_maPhieu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_xuatCho);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_luuGhiChu);
            this.Controls.Add(this.lb_PhieuXuatDi);
            this.Controls.Add(this.lb_tongTienHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_XuatDi";
            this.Text = "Xuất Đi";
            this.Load += new System.EventHandler(this.form_XuatDi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_maPhieu;
        private Button button1;
        private Button btn_xoaPhieu;
        private Button btn_themPhieu;
        private TextBox txt_ghiChu;
        private TextBox txt_tongSoLuong;
        private TextBox txt_tongTienHang;
        private Label lb_ghiChu;
        private Label lb_tongSoLuong;
        private Button btn_in;
        private DataGridViewButtonColumn column_xoa;
        private DataGridViewTextBoxColumn column_gia;
        private DataGridViewTextBoxColumn column_donVi;
        private DataGridViewTextBoxColumn column_soLuong;
        private DataGridViewTextBoxColumn column_tong;
        private DataGridViewTextBoxColumn column_tenBanh;
        private DataGridViewTextBoxColumn column_ma;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn column_thanhTien;
        private Button btn_after;
        private Button btn_before;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txt_maPhieu;
        private PictureBox pictureBox3;
        private Label lb_xuatCho;
        private PictureBox pictureBox2;
        private Label lb_ngay;
        private PictureBox pictureBox1;
        private Button btn_luuGhiChu;
        private Label lb_PhieuXuatDi;
        private Label lb_tongTienHang;
    }
}
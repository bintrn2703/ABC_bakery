using System.Drawing;
using System.Windows.Forms;

namespace NhapBanhMuaNgoai
{
    partial class FormThemPhieuMuaNgoai
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
            btnThem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTon = new TextBox();
            txtTenBanh = new TextBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(424, 381);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 40);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 113);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 16;
            label4.Text = "Tồn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(113, 187);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 15;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(113, 258);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 14;
            label2.Text = "Giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 39);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 13;
            label1.Text = "Tên bánh:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(291, 258);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(249, 27);
            txtGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(291, 187);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(249, 27);
            txtSoLuong.TabIndex = 11;
            // 
            // txtTon
            // 
            txtTon.Location = new Point(291, 113);
            txtTon.Name = "txtTon";
            txtTon.Size = new Size(249, 27);
            txtTon.TabIndex = 10;
            // 
            // txtTenBanh
            // 
            txtTenBanh.Location = new Point(291, 39);
            txtTenBanh.Name = "txtTenBanh";
            txtTenBanh.Size = new Size(249, 27);
            txtTenBanh.TabIndex = 9;
            // 
            // FormThemPhieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 199, 153);
            ClientSize = new Size(666, 502);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTon);
            Controls.Add(txtTenBanh);
            Name = "FormThemPhieu";
            Text = "FormThemPhieu";
            Load += FormThemPhieu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtTon;
        private TextBox txtTenBanh;
    }
}
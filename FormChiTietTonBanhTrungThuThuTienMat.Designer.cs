
namespace ChiTietTonBanh
{
    partial class FormChiTietTonBanhTrungThuThuTienMat
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
            this.total_lb = new System.Windows.Forms.Label();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(773, 676);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(82, 17);
            this.total_lb.TabIndex = 15;
            this.total_lb.Text = "Tổng tiền:";
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(861, 673);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(189, 22);
            this.total_tb.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 541);
            this.dataGridView1.TabIndex = 13;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(909, 71);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(82, 23);
            this.export_btn.TabIndex = 12;
            this.export_btn.Text = "Xuất Excel";
            this.export_btn.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(791, 71);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(112, 23);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "In Danh Sách";
            this.print_btn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(232, 70);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "CHI TIẾT BÁN HÀNG THU TIỀN MẶT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormChiTietTonBanhTrungThuThuTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 736);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietTonBanhTrungThuThuTienMat";
            this.Text = "FormChiTietTonBanhTrungThuThuTienMat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
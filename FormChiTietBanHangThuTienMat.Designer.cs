
namespace ChiTietTonBanh
{
    partial class FormChiTietBanHangThuTienMat
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietBanBanhThuTienMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_bakeryDataSet_chiTietBanHangThuTienMat = new ABC_bakeryDataSet_chiTietBanHangThuTienMat();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.total_lb = new System.Windows.Forms.Label();
            this.chiTietBanBanhThuTienMatTableAdapter = new ABC_bakeryDataSet_chiTietBanHangThuTienMatTableAdapters.chiTietBanBanhThuTienMatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhThuTienMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet_chiTietBanHangThuTienMat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT BÁN HÀNG THU TIỀN MẶT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(197, 40);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(756, 41);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(112, 23);
            this.print_btn.TabIndex = 3;
            this.print_btn.Text = "In Danh Sách";
            this.print_btn.UseVisualStyleBackColor = true;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(874, 41);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(82, 23);
            this.export_btn.TabIndex = 4;
            this.export_btn.Text = "Xuất Excel";
            this.export_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderedatDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiTietBanBanhThuTienMatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 541);
            this.dataGridView1.TabIndex = 5;
            // 
            // orderedatDataGridViewTextBoxColumn
            // 
            this.orderedatDataGridViewTextBoxColumn.DataPropertyName = "ordered_at";
            this.orderedatDataGridViewTextBoxColumn.HeaderText = "ordered_at";
            this.orderedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderedatDataGridViewTextBoxColumn.Name = "orderedatDataGridViewTextBoxColumn";
            this.orderedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // chiTietBanBanhThuTienMatBindingSource
            // 
            this.chiTietBanBanhThuTienMatBindingSource.DataMember = "chiTietBanBanhThuTienMat";
            this.chiTietBanBanhThuTienMatBindingSource.DataSource = this.aBC_bakeryDataSet_chiTietBanHangThuTienMat;
            // 
            // aBC_bakeryDataSet_chiTietBanHangThuTienMat
            // 
            this.aBC_bakeryDataSet_chiTietBanHangThuTienMat.DataSetName = "ABC_bakeryDataSet_chiTietBanHangThuTienMat";
            this.aBC_bakeryDataSet_chiTietBanHangThuTienMat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(767, 617);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(189, 22);
            this.total_tb.TabIndex = 6;
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(679, 620);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(82, 17);
            this.total_lb.TabIndex = 7;
            this.total_lb.Text = "Tổng tiền:";
            // 
            // chiTietBanBanhThuTienMatTableAdapter
            // 
            this.chiTietBanBanhThuTienMatTableAdapter.ClearBeforeFill = true;
            // 
            // FormChiTietBanHangThuTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(968, 650);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietBanHangThuTienMat";
            this.Text = "FormChiTietBanHangThuTienMat";
            this.Load += new System.EventHandler(this.FormChiTietBanHangThuTienMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietBanBanhThuTienMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet_chiTietBanHangThuTienMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.Label total_lb;
        private ABC_bakeryDataSet_chiTietBanHangThuTienMat aBC_bakeryDataSet_chiTietBanHangThuTienMat;
        private System.Windows.Forms.BindingSource chiTietBanBanhThuTienMatBindingSource;
        private ABC_bakeryDataSet_chiTietBanHangThuTienMatTableAdapters.chiTietBanBanhThuTienMatTableAdapter chiTietBanBanhThuTienMatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}
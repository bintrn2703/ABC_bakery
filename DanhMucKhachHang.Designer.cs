
namespace ChiTietTonBanh
{
    partial class DanhMucKhachHang
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
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.exportExcel_btn = new System.Windows.Forms.Button();
            this.DanhMucKhachHang_dataGridView = new System.Windows.Forms.DataGridView();
            this.mãDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sĐTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.địaChỉDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiệnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ghiChúDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDanhMucKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucKhachHang_DataSet = new DanhMucKhachHang_DataSet();
            this.selectDanhMucKhachHangTableAdapter = new DanhMucKhachHang_DataSetTableAdapters.SelectDanhMucKhachHangTableAdapter();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucKhachHang_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(12, 43);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(240, 22);
            this.search_box.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(258, 43);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(818, 43);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(113, 23);
            this.print_btn.TabIndex = 3;
            this.print_btn.Text = "In Danh Sách";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // exportExcel_btn
            // 
            this.exportExcel_btn.Location = new System.Drawing.Point(937, 43);
            this.exportExcel_btn.Name = "exportExcel_btn";
            this.exportExcel_btn.Size = new System.Drawing.Size(113, 23);
            this.exportExcel_btn.TabIndex = 4;
            this.exportExcel_btn.Text = "Xuất Excel";
            this.exportExcel_btn.UseVisualStyleBackColor = true;
            this.exportExcel_btn.Click += new System.EventHandler(this.exportExcel_btn_Click);
            // 
            // DanhMucKhachHang_dataGridView
            // 
            this.DanhMucKhachHang_dataGridView.AllowUserToOrderColumns = true;
            this.DanhMucKhachHang_dataGridView.AutoGenerateColumns = false;
            this.DanhMucKhachHang_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhMucKhachHang_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhMucKhachHang_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãDataGridViewTextBoxColumn,
            this.tênDataGridViewTextBoxColumn,
            this.sĐTDataGridViewTextBoxColumn,
            this.địaChỉDataGridViewTextBoxColumn,
            this.hiệnDataGridViewCheckBoxColumn,
            this.ghiChúDataGridViewTextBoxColumn});
            this.DanhMucKhachHang_dataGridView.DataSource = this.selectDanhMucKhachHangBindingSource;
            this.DanhMucKhachHang_dataGridView.Location = new System.Drawing.Point(12, 72);
            this.DanhMucKhachHang_dataGridView.Name = "DanhMucKhachHang_dataGridView";
            this.DanhMucKhachHang_dataGridView.RowHeadersWidth = 51;
            this.DanhMucKhachHang_dataGridView.RowTemplate.Height = 24;
            this.DanhMucKhachHang_dataGridView.Size = new System.Drawing.Size(1038, 589);
            this.DanhMucKhachHang_dataGridView.TabIndex = 5;
            // 
            // mãDataGridViewTextBoxColumn
            // 
            this.mãDataGridViewTextBoxColumn.DataPropertyName = "Mã";
            this.mãDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.mãDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãDataGridViewTextBoxColumn.Name = "mãDataGridViewTextBoxColumn";
            this.mãDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênDataGridViewTextBoxColumn
            // 
            this.tênDataGridViewTextBoxColumn.DataPropertyName = "Tên";
            this.tênDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tênDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênDataGridViewTextBoxColumn.Name = "tênDataGridViewTextBoxColumn";
            // 
            // sĐTDataGridViewTextBoxColumn
            // 
            this.sĐTDataGridViewTextBoxColumn.DataPropertyName = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sĐTDataGridViewTextBoxColumn.Name = "sĐTDataGridViewTextBoxColumn";
            // 
            // địaChỉDataGridViewTextBoxColumn
            // 
            this.địaChỉDataGridViewTextBoxColumn.DataPropertyName = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.địaChỉDataGridViewTextBoxColumn.Name = "địaChỉDataGridViewTextBoxColumn";
            // 
            // hiệnDataGridViewCheckBoxColumn
            // 
            this.hiệnDataGridViewCheckBoxColumn.DataPropertyName = "Hiện";
            this.hiệnDataGridViewCheckBoxColumn.HeaderText = "Hiện";
            this.hiệnDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hiệnDataGridViewCheckBoxColumn.Name = "hiệnDataGridViewCheckBoxColumn";
            // 
            // ghiChúDataGridViewTextBoxColumn
            // 
            this.ghiChúDataGridViewTextBoxColumn.DataPropertyName = "Ghi chú";
            this.ghiChúDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChúDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChúDataGridViewTextBoxColumn.Name = "ghiChúDataGridViewTextBoxColumn";
            // 
            // selectDanhMucKhachHangBindingSource
            // 
            this.selectDanhMucKhachHangBindingSource.DataMember = "SelectDanhMucKhachHang";
            this.selectDanhMucKhachHangBindingSource.DataSource = this.danhMucKhachHang_DataSet;
            // 
            // danhMucKhachHang_DataSet
            // 
            this.danhMucKhachHang_DataSet.DataSetName = "DanhMucKhachHang_DataSet";
            this.danhMucKhachHang_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDanhMucKhachHangTableAdapter
            // 
            this.selectDanhMucKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 12);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Lưu";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // DanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.DanhMucKhachHang_dataGridView);
            this.Controls.Add(this.exportExcel_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label1);
            this.Name = "DanhMucKhachHang";
            this.Text = "DanhMucKhachHang";
            this.Load += new System.EventHandler(this.DanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucKhachHang_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDanhMucKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucKhachHang_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button exportExcel_btn;
        private System.Windows.Forms.DataGridView DanhMucKhachHang_dataGridView;
        private System.Windows.Forms.BindingSource selectDanhMucKhachHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sĐTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn địaChỉDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hiệnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChúDataGridViewTextBoxColumn;
        private DanhMucKhachHang_DataSet danhMucKhachHang_DataSet;
        private DanhMucKhachHang_DataSetTableAdapters.SelectDanhMucKhachHangTableAdapter selectDanhMucKhachHangTableAdapter;
        private System.Windows.Forms.Button save_btn;
    }
}
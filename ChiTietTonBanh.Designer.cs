
namespace ChiTietTonBanh
{
    partial class ChiTietTonBanh
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.exportExcelBtn = new System.Windows.Forms.Button();
            this.importInToNhapBanhNoiBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietTonBanh_dataGridView = new System.Windows.Forms.DataGridView();
            this.tenBanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importInToNhapBanhNoiBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_bakeryDataSet1 = new ABC_bakeryDataSet1();
            this.getProductsCreatedBetweenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_bakeryDataSet2 = new ABC_bakeryDataSet2();
            this.importInToNhapBanhNoiBoTableAdapter = new ABC_bakeryDataSet1TableAdapters.ImportInToNhapBanhNoiBoTableAdapter();
            this.getProductsCreatedBetweenTableAdapter = new ABC_bakeryDataSet2TableAdapters.GetProductsCreatedBetweenTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietTonBanh_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductsCreatedBetweenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBox.Location = new System.Drawing.Point(12, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(226, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Nhập mã bánh";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(244, 60);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(1116, 60);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(34, 23);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "In";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // exportExcelBtn
            // 
            this.exportExcelBtn.Location = new System.Drawing.Point(1156, 60);
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.Size = new System.Drawing.Size(94, 23);
            this.exportExcelBtn.TabIndex = 4;
            this.exportExcelBtn.Text = "Xuất Excel";
            this.exportExcelBtn.UseVisualStyleBackColor = true;
            this.exportExcelBtn.Click += new System.EventHandler(this.exportExcelBtn_Click);
            // 
            // ChiTietTonBanh_dataGridView
            // 
            this.ChiTietTonBanh_dataGridView.AllowUserToAddRows = false;
            this.ChiTietTonBanh_dataGridView.AllowUserToDeleteRows = false;
            this.ChiTietTonBanh_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChiTietTonBanh_dataGridView.AutoGenerateColumns = false;
            this.ChiTietTonBanh_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChiTietTonBanh_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChiTietTonBanh_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenBanhDataGridViewTextBoxColumn,
            this.tonDataGridViewTextBoxColumn});
            this.ChiTietTonBanh_dataGridView.DataSource = this.importInToNhapBanhNoiBoBindingSource1;
            this.ChiTietTonBanh_dataGridView.Location = new System.Drawing.Point(12, 88);
            this.ChiTietTonBanh_dataGridView.Name = "ChiTietTonBanh_dataGridView";
            this.ChiTietTonBanh_dataGridView.ReadOnly = true;
            this.ChiTietTonBanh_dataGridView.RowHeadersWidth = 51;
            this.ChiTietTonBanh_dataGridView.RowTemplate.Height = 24;
            this.ChiTietTonBanh_dataGridView.Size = new System.Drawing.Size(1238, 573);
            this.ChiTietTonBanh_dataGridView.TabIndex = 8;
            this.ChiTietTonBanh_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tenBanhDataGridViewTextBoxColumn
            // 
            this.tenBanhDataGridViewTextBoxColumn.DataPropertyName = "TenBanh";
            this.tenBanhDataGridViewTextBoxColumn.HeaderText = "TenBanh";
            this.tenBanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenBanhDataGridViewTextBoxColumn.Name = "tenBanhDataGridViewTextBoxColumn";
            this.tenBanhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonDataGridViewTextBoxColumn
            // 
            this.tonDataGridViewTextBoxColumn.DataPropertyName = "Ton";
            this.tonDataGridViewTextBoxColumn.HeaderText = "Ton";
            this.tonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tonDataGridViewTextBoxColumn.Name = "tonDataGridViewTextBoxColumn";
            this.tonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importInToNhapBanhNoiBoBindingSource1
            // 
            this.importInToNhapBanhNoiBoBindingSource1.DataMember = "ImportInToNhapBanhNoiBo";
            this.importInToNhapBanhNoiBoBindingSource1.DataSource = this.aBC_bakeryDataSet1;
            // 
            // aBC_bakeryDataSet1
            // 
            this.aBC_bakeryDataSet1.DataSetName = "ABC_bakeryDataSet1";
            this.aBC_bakeryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getProductsCreatedBetweenBindingSource
            // 
            this.getProductsCreatedBetweenBindingSource.DataMember = "GetProductsCreatedBetween";
            this.getProductsCreatedBetweenBindingSource.DataSource = this.aBC_bakeryDataSet2;
            // 
            // aBC_bakeryDataSet2
            // 
            this.aBC_bakeryDataSet2.DataSetName = "ABC_bakeryDataSet2";
            this.aBC_bakeryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importInToNhapBanhNoiBoTableAdapter
            // 
            this.importInToNhapBanhNoiBoTableAdapter.ClearBeforeFill = true;
            // 
            // getProductsCreatedBetweenTableAdapter
            // 
            this.getProductsCreatedBetweenTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "CHI TIẾT TỒN BÁNH";
            // 
            // ChiTietTonBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChiTietTonBanh_dataGridView);
            this.Controls.Add(this.exportExcelBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "ChiTietTonBanh";
            this.Text = "Chi tiết tồn bánh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietTonBanh_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductsCreatedBetweenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button exportExcelBtn;
        private System.Windows.Forms.BindingSource importInToNhapBanhNoiBoBindingSource;
        private System.Windows.Forms.DataGridView ChiTietTonBanh_dataGridView;
        private ABC_bakeryDataSet1 aBC_bakeryDataSet1;
        private System.Windows.Forms.BindingSource importInToNhapBanhNoiBoBindingSource1;
        private ABC_bakeryDataSet1TableAdapters.ImportInToNhapBanhNoiBoTableAdapter importInToNhapBanhNoiBoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getProductsCreatedBetweenBindingSource;
        private ABC_bakeryDataSet2 aBC_bakeryDataSet2;
        private ABC_bakeryDataSet2TableAdapters.GetProductsCreatedBetweenTableAdapter getProductsCreatedBetweenTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}



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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenBanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProductsCreatedBetweenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_bakeryDataSet2 = new global::ChiTietTonBanh.ABC_bakeryDataSet2();
            this.aBC_bakeryDataSet1 = new global::ChiTietTonBanh.ABC_bakeryDataSet1();
            this.importInToNhapBanhNoiBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importInToNhapBanhNoiBoTableAdapter = new global::ChiTietTonBanh.ABC_bakeryDataSet1TableAdapters.ImportInToNhapBanhNoiBoTableAdapter();
            this.getProductsCreatedBetweenTableAdapter = new global::ChiTietTonBanh.ABC_bakeryDataSet2TableAdapters.GetProductsCreatedBetweenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductsCreatedBetweenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(226, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Nhập mã bánh";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(244, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(1050, 11);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(34, 23);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "In";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // exportExcelBtn
            // 
            this.exportExcelBtn.Location = new System.Drawing.Point(1090, 12);
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.Size = new System.Drawing.Size(94, 23);
            this.exportExcelBtn.TabIndex = 4;
            this.exportExcelBtn.Text = "Xuất Excel";
            this.exportExcelBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenBanhDataGridViewTextBoxColumn,
            this.tonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.importInToNhapBanhNoiBoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 561);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // aBC_bakeryDataSet1
            // 
            this.aBC_bakeryDataSet1.DataSetName = "ABC_bakeryDataSet1";
            this.aBC_bakeryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importInToNhapBanhNoiBoBindingSource1
            // 
            this.importInToNhapBanhNoiBoBindingSource1.DataMember = "ImportInToNhapBanhNoiBo";
            this.importInToNhapBanhNoiBoBindingSource1.DataSource = this.aBC_bakeryDataSet1;
            // 
            // importInToNhapBanhNoiBoTableAdapter
            // 
            this.importInToNhapBanhNoiBoTableAdapter.ClearBeforeFill = true;
            // 
            // getProductsCreatedBetweenTableAdapter
            // 
            this.getProductsCreatedBetweenTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exportExcelBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
            this.Text = "Chi tiết tồn bánh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductsCreatedBetweenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_bakeryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importInToNhapBanhNoiBoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button exportExcelBtn;
        private System.Windows.Forms.BindingSource importInToNhapBanhNoiBoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ABC_bakeryDataSet1 aBC_bakeryDataSet1;
        private System.Windows.Forms.BindingSource importInToNhapBanhNoiBoBindingSource1;
        private ABC_bakeryDataSet1TableAdapters.ImportInToNhapBanhNoiBoTableAdapter importInToNhapBanhNoiBoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getProductsCreatedBetweenBindingSource;
        private ABC_bakeryDataSet2 aBC_bakeryDataSet2;
        private ABC_bakeryDataSet2TableAdapters.GetProductsCreatedBetweenTableAdapter getProductsCreatedBetweenTableAdapter;
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace NhapBanhMuaNgoai
{
    partial class FormNhapBanhMuaNgoai
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cbSupplier = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            btnChangeDate = new Button();
            dateTimePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtTotal = new TextBox();
            txtPriceProduct = new TextBox();
            txtGhiChu = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbSupplier
            // 
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(923, 107);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(182, 28);
            cbSupplier.Sorted = true;
            cbSupplier.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(809, 108);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 13;
            label5.Text = "Nhập từ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(585, 27);
            label1.Name = "label1";
            label1.Size = new Size(364, 34);
            label1.TabIndex = 10;
            label1.Text = "Nhập bánh mua ngoài";
            // 
            // btnChangeDate
            // 
            btnChangeDate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeDate.Location = new Point(194, 31);
            btnChangeDate.Name = "btnChangeDate";
            btnChangeDate.Size = new Size(178, 44);
            btnChangeDate.TabIndex = 24;
            btnChangeDate.Text = "Đổi ngày";
            btnChangeDate.UseVisualStyleBackColor = true;
            btnChangeDate.Click += btnChangeDate_Click_1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(194, 118);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(190, 29);
            dateTimePicker.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(242, 236, 190);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(109, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1156, 453);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 118);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 21;
            label3.Text = "Ngày";
            // 
            // button4
            // 
            button4.Location = new Point(801, 818);
            button4.Name = "button4";
            button4.Size = new Size(108, 93);
            button4.TabIndex = 34;
            button4.Text = "Xóa phiếu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(915, 818);
            button3.Name = "button3";
            button3.Size = new Size(108, 93);
            button3.TabIndex = 33;
            button3.Text = "In";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(675, 818);
            button2.Name = "button2";
            button2.Size = new Size(108, 93);
            button2.TabIndex = 32;
            button2.Text = "Thêm phiếu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(563, 818);
            button1.Name = "button1";
            button1.Size = new Size(106, 93);
            button1.TabIndex = 31;
            button1.Text = "Lưu ghi chú";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(1175, 768);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(183, 28);
            txtTotal.TabIndex = 30;
            txtTotal.Text = "0 đ";
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceProduct.Location = new Point(740, 715);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.ReadOnly = true;
            txtPriceProduct.Size = new Size(183, 28);
            txtPriceProduct.TabIndex = 29;
            txtPriceProduct.Text = "0 đ";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhiChu.Location = new Point(109, 768);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(402, 224);
            txtGhiChu.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(544, 714);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 27;
            label7.Text = "Tổng tiền hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1034, 771);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 26;
            label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 714);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 25;
            label4.Text = "Ghi chú";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 199, 153);
            ClientSize = new Size(1461, 1055);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtPriceProduct);
            Controls.Add(txtGhiChu);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnChangeDate);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(cbSupplier);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSupplier;
        private Label label5;
        private Label label1;
        private Button btnChangeDate;
        private DateTimePicker dateTimePicker;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtTotal;
        private TextBox txtPriceProduct;
        private TextBox txtGhiChu;
        private Label label7;
        private Label label6;
        private Label label4;
    }
}
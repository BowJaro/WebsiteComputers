namespace LapHoaDonThanhToan
{
    partial class Form1
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
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(182, 17);
            textBox1.Margin = new Padding(15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.19211F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.80789F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 2);
            tableLayoutPanel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.ForeColor = Color.White;
            tableLayoutPanel1.Location = new Point(8, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7903233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.20968F));
            tableLayoutPanel1.Size = new Size(463, 248);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên sảnh";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 81);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 5;
            label4.Text = "Số lượng bàn tối đa";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(182, 78);
            textBox3.Margin = new Padding(15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(92, 27);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 124);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 6;
            label5.Text = "Ghi chú";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(182, 130);
            textBox5.Margin = new Padding(15, 3, 15, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(266, 109);
            textBox5.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá bàn tối thiểu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 14);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "Loại Sảnh";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(196, 372);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(395, 45);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(42, 5);
            button1.Name = "button1";
            button1.Size = new Size(113, 34);
            button1.TabIndex = 0;
            button1.Text = "Tiếp nhận";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(0, 66, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(239, 5);
            button2.Name = "button2";
            button2.Size = new Size(113, 34);
            button2.TabIndex = 1;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(201, 26);
            label6.Name = "label6";
            label6.Size = new Size(390, 37);
            label6.TabIndex = 6;
            label6.Text = "LẬP HÓA ĐƠN THANH TOÁN";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            comboBox1.Location = new Point(183, 13);
            comboBox1.Margin = new Padding(15, 3, 15, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.5656548F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4343452F));
            tableLayoutPanel3.Controls.Add(label7, 1, 1);
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Location = new Point(496, 94);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(297, 100);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(183, 61);
            label7.Margin = new Padding(15, 0, 15, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 27);
            label7.TabIndex = 11;
            label7.Text = "1.000.000";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel3);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox5;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
    }
}
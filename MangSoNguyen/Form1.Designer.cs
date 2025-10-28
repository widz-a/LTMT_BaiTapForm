namespace MangSoNguyen
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
        private void InitializeComponent() {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_execute = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            rdb_sort_down = new RadioButton();
            rdb_sort_up = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_thoat = new Button();
            output = new TextBox();
            label3 = new Label();
            input = new TextBox();
            label2 = new Label();
            btn_reset = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            rdb_replace_index = new RadioButton();
            input_replace = new TextBox();
            label10 = new Label();
            input_replace_index = new TextBox();
            input_replace_value = new TextBox();
            rdb_replace_value = new RadioButton();
            groupBox6 = new GroupBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            output_min = new TextBox();
            label11 = new Label();
            output_max = new TextBox();
            label12 = new Label();
            btn_min_max_find = new Button();
            groupBox5 = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            output_odd = new TextBox();
            label9 = new Label();
            output_even = new TextBox();
            label8 = new Label();
            output_sum = new TextBox();
            label7 = new Label();
            btn_sum = new Button();
            groupBox4 = new GroupBox();
            panel4 = new Panel();
            label5 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            input_add_index = new TextBox();
            input_add_value = new TextBox();
            rdb_add = new RadioButton();
            label13 = new Label();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            rdb_remove_index = new RadioButton();
            input_remove_index = new TextBox();
            input_remove_value = new TextBox();
            rdb_remove_value = new RadioButton();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            rdb_search_index = new RadioButton();
            rdb_search_value = new RadioButton();
            output_search = new TextBox();
            label6 = new Label();
            input_search_index = new TextBox();
            input_search_value = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox7.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            groupBox4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 62);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(109, 11);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 1;
            label1.Text = "Mảng số nguyên";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 148);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(btn_execute, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(471, 81);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_execute
            // 
            btn_execute.Dock = DockStyle.Fill;
            btn_execute.Location = new Point(3, 3);
            btn_execute.Name = "btn_execute";
            btn_execute.Size = new Size(94, 75);
            btn_execute.TabIndex = 0;
            btn_execute.Text = "Thực hiện";
            btn_execute.UseVisualStyleBackColor = true;
            btn_execute.Click += btn_execute_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(103, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 75);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sắp xếp";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(rdb_sort_down, 1, 0);
            tableLayoutPanel3.Controls.Add(rdb_sort_up, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(359, 49);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // rdb_sort_down
            // 
            rdb_sort_down.AutoSize = true;
            rdb_sort_down.Dock = DockStyle.Fill;
            rdb_sort_down.Location = new Point(182, 3);
            rdb_sort_down.Name = "rdb_sort_down";
            rdb_sort_down.Size = new Size(174, 43);
            rdb_sort_down.TabIndex = 6;
            rdb_sort_down.Text = "Sắp xếp giảm";
            rdb_sort_down.UseVisualStyleBackColor = true;
            // 
            // rdb_sort_up
            // 
            rdb_sort_up.AutoSize = true;
            rdb_sort_up.Dock = DockStyle.Fill;
            rdb_sort_up.Location = new Point(3, 3);
            rdb_sort_up.Name = "rdb_sort_up";
            rdb_sort_up.Size = new Size(173, 43);
            rdb_sort_up.TabIndex = 5;
            rdb_sort_up.Text = "Sắp xếp tăng";
            rdb_sort_up.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btn_thoat, 2, 1);
            tableLayoutPanel1.Controls.Add(output, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(input, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_reset, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(471, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            btn_thoat.Dock = DockStyle.Fill;
            btn_thoat.Location = new Point(335, 38);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(133, 29);
            btn_thoat.TabIndex = 10;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // output
            // 
            output.Dock = DockStyle.Fill;
            output.Enabled = false;
            output.Location = new Point(114, 38);
            output.Name = "output";
            output.Size = new Size(215, 27);
            output.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(105, 35);
            label3.TabIndex = 7;
            label3.Text = "Kết quả mảng:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // input
            // 
            input.Dock = DockStyle.Fill;
            input.Location = new Point(114, 3);
            input.Name = "input";
            input.Size = new Size(215, 27);
            input.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 35);
            label2.TabIndex = 5;
            label2.Text = "Nhập mảng:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_reset
            // 
            btn_reset.Dock = DockStyle.Fill;
            btn_reset.Location = new Point(335, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(133, 29);
            btn_reset.TabIndex = 9;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(groupBox7, 1, 2);
            tableLayoutPanel4.Controls.Add(groupBox6, 0, 2);
            tableLayoutPanel4.Controls.Add(groupBox5, 1, 1);
            tableLayoutPanel4.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 210);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(471, 385);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel12);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(238, 259);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(230, 123);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thay thế";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.Controls.Add(rdb_replace_index, 0, 1);
            tableLayoutPanel12.Controls.Add(input_replace, 1, 2);
            tableLayoutPanel12.Controls.Add(label10, 0, 2);
            tableLayoutPanel12.Controls.Add(input_replace_index, 1, 1);
            tableLayoutPanel12.Controls.Add(input_replace_value, 1, 0);
            tableLayoutPanel12.Controls.Add(rdb_replace_value, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 23);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.Size = new Size(224, 97);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // rdb_replace_index
            // 
            rdb_replace_index.AutoSize = true;
            rdb_replace_index.Dock = DockStyle.Fill;
            rdb_replace_index.Location = new Point(3, 36);
            rdb_replace_index.Name = "rdb_replace_index";
            rdb_replace_index.Size = new Size(182, 27);
            rdb_replace_index.TabIndex = 7;
            rdb_replace_index.TabStop = true;
            rdb_replace_index.Text = "Vị trí cần thay thế";
            rdb_replace_index.UseVisualStyleBackColor = true;
            // 
            // input_replace
            // 
            input_replace.Dock = DockStyle.Right;
            input_replace.Location = new Point(191, 69);
            input_replace.Name = "input_replace";
            input_replace.Size = new Size(30, 27);
            input_replace.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 66);
            label10.Name = "label10";
            label10.Size = new Size(182, 33);
            label10.TabIndex = 4;
            label10.Text = "Số thay thế là";
            // 
            // input_replace_index
            // 
            input_replace_index.Dock = DockStyle.Right;
            input_replace_index.Location = new Point(191, 36);
            input_replace_index.Name = "input_replace_index";
            input_replace_index.Size = new Size(30, 27);
            input_replace_index.TabIndex = 3;
            // 
            // input_replace_value
            // 
            input_replace_value.Dock = DockStyle.Right;
            input_replace_value.Location = new Point(191, 3);
            input_replace_value.Name = "input_replace_value";
            input_replace_value.Size = new Size(30, 27);
            input_replace_value.TabIndex = 1;
            // 
            // rdb_replace_value
            // 
            rdb_replace_value.AutoSize = true;
            rdb_replace_value.Dock = DockStyle.Fill;
            rdb_replace_value.Location = new Point(3, 3);
            rdb_replace_value.Name = "rdb_replace_value";
            rdb_replace_value.Size = new Size(182, 27);
            rdb_replace_value.TabIndex = 6;
            rdb_replace_value.TabStop = true;
            rdb_replace_value.Text = "Giá trị cần thay thế";
            rdb_replace_value.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tableLayoutPanel10);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 259);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(229, 123);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Max - Min";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Controls.Add(btn_min_max_find, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Top;
            tableLayoutPanel10.Location = new Point(3, 23);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(223, 69);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel11.Controls.Add(output_min, 1, 1);
            tableLayoutPanel11.Controls.Add(label11, 0, 1);
            tableLayoutPanel11.Controls.Add(output_max, 1, 0);
            tableLayoutPanel11.Controls.Add(label12, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel11.Size = new Size(169, 63);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // output_min
            // 
            output_min.Dock = DockStyle.Fill;
            output_min.Enabled = false;
            output_min.Location = new Point(136, 34);
            output_min.Name = "output_min";
            output_min.Size = new Size(30, 27);
            output_min.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 31);
            label11.Name = "label11";
            label11.Size = new Size(127, 32);
            label11.TabIndex = 8;
            label11.Text = "Giá trị nhỏ nhất:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // output_max
            // 
            output_max.Dock = DockStyle.Fill;
            output_max.Enabled = false;
            output_max.Location = new Point(136, 3);
            output_max.Name = "output_max";
            output_max.Size = new Size(30, 27);
            output_max.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(127, 31);
            label12.TabIndex = 6;
            label12.Text = "Giá trị lớn nhất:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_min_max_find
            // 
            btn_min_max_find.Dock = DockStyle.Fill;
            btn_min_max_find.Location = new Point(178, 3);
            btn_min_max_find.Name = "btn_min_max_find";
            btn_min_max_find.Size = new Size(42, 63);
            btn_min_max_find.TabIndex = 1;
            btn_min_max_find.Text = "Tìm";
            btn_min_max_find.UseVisualStyleBackColor = true;
            btn_min_max_find.Click += btn_min_max_find_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel8);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(238, 131);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(230, 122);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tổng";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel8.Controls.Add(btn_sum, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 23);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(224, 96);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.Controls.Add(output_odd, 1, 2);
            tableLayoutPanel9.Controls.Add(label9, 0, 2);
            tableLayoutPanel9.Controls.Add(output_even, 1, 1);
            tableLayoutPanel9.Controls.Add(label8, 0, 1);
            tableLayoutPanel9.Controls.Add(output_sum, 1, 0);
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(154, 90);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // output_odd
            // 
            output_odd.Dock = DockStyle.Right;
            output_odd.Enabled = false;
            output_odd.Location = new Point(121, 63);
            output_odd.Name = "output_odd";
            output_odd.Size = new Size(30, 27);
            output_odd.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 60);
            label9.Name = "label9";
            label9.Size = new Size(112, 30);
            label9.TabIndex = 10;
            label9.Text = "Tổng lẻ:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // output_even
            // 
            output_even.Dock = DockStyle.Right;
            output_even.Enabled = false;
            output_even.Location = new Point(121, 33);
            output_even.Name = "output_even";
            output_even.Size = new Size(30, 27);
            output_even.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 30);
            label8.Name = "label8";
            label8.Size = new Size(112, 30);
            label8.TabIndex = 8;
            label8.Text = "Tổng chẵn:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // output_sum
            // 
            output_sum.Dock = DockStyle.Right;
            output_sum.Enabled = false;
            output_sum.Location = new Point(121, 3);
            output_sum.Name = "output_sum";
            output_sum.Size = new Size(30, 27);
            output_sum.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 30);
            label7.TabIndex = 6;
            label7.Text = "Tổng mảng:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_sum
            // 
            btn_sum.Dock = DockStyle.Fill;
            btn_sum.Location = new Point(163, 3);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(58, 90);
            btn_sum.TabIndex = 1;
            btn_sum.Text = "Tổng";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel4);
            groupBox4.Controls.Add(tableLayoutPanel7);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 131);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(229, 122);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thêm";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 33);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(47, 3);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 0;
            label5.Text = "Cần sắp xếp tăng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(input_add_index, 1, 1);
            tableLayoutPanel7.Controls.Add(input_add_value, 1, 0);
            tableLayoutPanel7.Controls.Add(rdb_add, 0, 0);
            tableLayoutPanel7.Controls.Add(label13, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(3, 23);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(223, 63);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // input_add_index
            // 
            input_add_index.Dock = DockStyle.Right;
            input_add_index.Location = new Point(190, 36);
            input_add_index.Name = "input_add_index";
            input_add_index.Size = new Size(30, 27);
            input_add_index.TabIndex = 3;
            // 
            // input_add_value
            // 
            input_add_value.Dock = DockStyle.Right;
            input_add_value.Location = new Point(190, 3);
            input_add_value.Name = "input_add_value";
            input_add_value.Size = new Size(30, 27);
            input_add_value.TabIndex = 1;
            // 
            // rdb_add
            // 
            rdb_add.AutoSize = true;
            rdb_add.Dock = DockStyle.Fill;
            rdb_add.Location = new Point(3, 3);
            rdb_add.Name = "rdb_add";
            rdb_add.Size = new Size(181, 27);
            rdb_add.TabIndex = 6;
            rdb_add.TabStop = true;
            rdb_add.Text = "Tìm giá trị cần thêm:";
            rdb_add.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 33);
            label13.Name = "label13";
            label13.Size = new Size(130, 20);
            label13.TabIndex = 7;
            label13.Text = "Tại vị trí cần thêm:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(tableLayoutPanel6);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(238, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 122);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Xóa";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 33);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(47, 3);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 0;
            label4.Text = "Cần sắp xếp tăng";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(rdb_remove_index, 0, 1);
            tableLayoutPanel6.Controls.Add(input_remove_index, 1, 1);
            tableLayoutPanel6.Controls.Add(input_remove_value, 1, 0);
            tableLayoutPanel6.Controls.Add(rdb_remove_value, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(3, 23);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(224, 63);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // rdb_remove_index
            // 
            rdb_remove_index.AutoSize = true;
            rdb_remove_index.Dock = DockStyle.Fill;
            rdb_remove_index.Location = new Point(3, 36);
            rdb_remove_index.Name = "rdb_remove_index";
            rdb_remove_index.Size = new Size(182, 27);
            rdb_remove_index.TabIndex = 7;
            rdb_remove_index.TabStop = true;
            rdb_remove_index.Text = "Tìm vị trí cần xóa";
            rdb_remove_index.UseVisualStyleBackColor = true;
            // 
            // input_remove_index
            // 
            input_remove_index.Dock = DockStyle.Right;
            input_remove_index.Location = new Point(191, 36);
            input_remove_index.Name = "input_remove_index";
            input_remove_index.Size = new Size(30, 27);
            input_remove_index.TabIndex = 3;
            // 
            // input_remove_value
            // 
            input_remove_value.Dock = DockStyle.Right;
            input_remove_value.Location = new Point(191, 3);
            input_remove_value.Name = "input_remove_value";
            input_remove_value.Size = new Size(30, 27);
            input_remove_value.TabIndex = 1;
            // 
            // rdb_remove_value
            // 
            rdb_remove_value.AutoSize = true;
            rdb_remove_value.Dock = DockStyle.Fill;
            rdb_remove_value.Location = new Point(3, 3);
            rdb_remove_value.Name = "rdb_remove_value";
            rdb_remove_value.Size = new Size(182, 27);
            rdb_remove_value.TabIndex = 6;
            rdb_remove_value.TabStop = true;
            rdb_remove_value.Text = "Tìm giá trị cần xóa";
            rdb_remove_value.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 122);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(rdb_search_index, 0, 1);
            tableLayoutPanel5.Controls.Add(rdb_search_value, 0, 0);
            tableLayoutPanel5.Controls.Add(output_search, 1, 2);
            tableLayoutPanel5.Controls.Add(label6, 0, 2);
            tableLayoutPanel5.Controls.Add(input_search_index, 1, 1);
            tableLayoutPanel5.Controls.Add(input_search_value, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(223, 96);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // rdb_search_index
            // 
            rdb_search_index.AutoSize = true;
            rdb_search_index.Dock = DockStyle.Fill;
            rdb_search_index.Location = new Point(3, 36);
            rdb_search_index.Name = "rdb_search_index";
            rdb_search_index.Size = new Size(181, 27);
            rdb_search_index.TabIndex = 9;
            rdb_search_index.TabStop = true;
            rdb_search_index.Text = "Tìm vị trí cần tìm";
            rdb_search_index.UseVisualStyleBackColor = true;
            // 
            // rdb_search_value
            // 
            rdb_search_value.AutoSize = true;
            rdb_search_value.Dock = DockStyle.Fill;
            rdb_search_value.Location = new Point(3, 3);
            rdb_search_value.Name = "rdb_search_value";
            rdb_search_value.Size = new Size(181, 27);
            rdb_search_value.TabIndex = 8;
            rdb_search_value.TabStop = true;
            rdb_search_value.Text = "Tìm giá trị cần tìm";
            rdb_search_value.UseVisualStyleBackColor = true;
            // 
            // output_search
            // 
            output_search.Dock = DockStyle.Right;
            output_search.Enabled = false;
            output_search.Location = new Point(190, 69);
            output_search.Name = "output_search";
            output_search.Size = new Size(30, 27);
            output_search.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 66);
            label6.Name = "label6";
            label6.Size = new Size(181, 33);
            label6.TabIndex = 4;
            label6.Text = "Số tìm được là";
            // 
            // input_search_index
            // 
            input_search_index.Dock = DockStyle.Right;
            input_search_index.Location = new Point(190, 36);
            input_search_index.Name = "input_search_index";
            input_search_index.Size = new Size(30, 27);
            input_search_index.TabIndex = 3;
            // 
            // input_search_value
            // 
            input_search_value.Dock = DockStyle.Right;
            input_search_value.Location = new Point(190, 3);
            input_search_value.Name = "input_search_value";
            input_search_value.Size = new Size(30, 27);
            input_search_value.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 595);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            groupBox5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox input;
        private Label label2;
        private TextBox output;
        private Label label3;
        private Button btn_thoat;
        private Button btn_reset;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_execute;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton rdb_sort_down;
        private RadioButton rdb_sort_up;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox input_search_index;
        private TextBox input_search_value;
        private TextBox output_search;
        private Label label6;
        private GroupBox groupBox3;
        private Panel panel3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton rdb_remove_index;
        private TextBox input_remove_index;
        private TextBox input_remove_value;
        private RadioButton rdb_remove_value;
        private GroupBox groupBox4;
        private Panel panel4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox input_add_index;
        private TextBox input_add_value;
        private RadioButton rdb_add;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox output_odd;
        private Label label9;
        private TextBox output_even;
        private Label label8;
        private TextBox output_sum;
        private Label label7;
        private Button btn_sum;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox output_min;
        private Label label11;
        private TextBox output_max;
        private Label label12;
        private Button btn_min_max_find;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel12;
        private RadioButton rdb_replace_index;
        private TextBox input_replace;
        private Label label10;
        private TextBox input_replace_index;
        private TextBox input_replace_value;
        private RadioButton rdb_replace_value;
        private RadioButton rdb_search_index;
        private RadioButton rdb_search_value;
        private Label label13;
    }
}

namespace ChonMonTheThao
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dt_date = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            cb_name = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            chosen = new ListBox();
            label6 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            btn_out = new Button();
            btn_all_out = new Button();
            btn_in = new Button();
            btn_all_in = new Button();
            label4 = new Label();
            subjects = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_exc = new Button();
            btn_reset = new Button();
            btn_exit = new Button();
            tb_result = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 55);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(350, 55);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 55);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Thể Thao";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(dt_date, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(cb_name, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(350, 64);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dt_date.Dock = DockStyle.Fill;
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(103, 33);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(244, 27);
            dt_date.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(94, 34);
            label3.TabIndex = 2;
            label3.Text = "Thời gian:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 0;
            label2.Text = "Chọn họ tên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_name
            // 
            cb_name.Dock = DockStyle.Fill;
            cb_name.FormattingEnabled = true;
            cb_name.Items.AddRange(new object[] { "Nguyễn Thành Tâm", "Ngô Bá Khá", "Tao Mày Có Nhau" });
            cb_name.Location = new Point(103, 3);
            cb_name.Name = "cb_name";
            cb_name.Size = new Size(244, 28);
            cb_name.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(chosen, 2, 1);
            tableLayoutPanel3.Controls.Add(label6, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(subjects, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 119);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(350, 199);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // chosen
            // 
            chosen.Dock = DockStyle.Fill;
            chosen.FormattingEnabled = true;
            chosen.Location = new Point(203, 33);
            chosen.Name = "chosen";
            chosen.Size = new Size(144, 163);
            chosen.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(203, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 30);
            label6.TabIndex = 9;
            label6.Text = "Danh sách đã chọn";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(btn_out, 0, 3);
            tableLayoutPanel8.Controls.Add(btn_all_out, 0, 2);
            tableLayoutPanel8.Controls.Add(btn_in, 0, 1);
            tableLayoutPanel8.Controls.Add(btn_all_in, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(153, 33);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Size = new Size(44, 163);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // btn_out
            // 
            btn_out.Dock = DockStyle.Fill;
            btn_out.Location = new Point(3, 123);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(38, 37);
            btn_out.TabIndex = 3;
            btn_out.Text = "<";
            btn_out.UseVisualStyleBackColor = true;
            btn_out.Click += btn_out_Click;
            // 
            // btn_all_out
            // 
            btn_all_out.Dock = DockStyle.Fill;
            btn_all_out.Location = new Point(3, 83);
            btn_all_out.Name = "btn_all_out";
            btn_all_out.Size = new Size(38, 34);
            btn_all_out.TabIndex = 2;
            btn_all_out.Text = "<<";
            btn_all_out.UseVisualStyleBackColor = true;
            btn_all_out.Click += btn_all_out_Click;
            // 
            // btn_in
            // 
            btn_in.Dock = DockStyle.Fill;
            btn_in.Location = new Point(3, 43);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(38, 34);
            btn_in.TabIndex = 1;
            btn_in.Text = ">";
            btn_in.UseVisualStyleBackColor = true;
            btn_in.Click += btn_in_Click;
            // 
            // btn_all_in
            // 
            btn_all_in.Dock = DockStyle.Fill;
            btn_all_in.Location = new Point(3, 3);
            btn_all_in.Name = "btn_all_in";
            btn_all_in.Size = new Size(38, 34);
            btn_all_in.TabIndex = 0;
            btn_all_in.Text = ">>";
            btn_all_in.UseVisualStyleBackColor = true;
            btn_all_in.Click += btn_all_in_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 30);
            label4.TabIndex = 7;
            label4.Text = "Danh sách các môn";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subjects
            // 
            subjects.Dock = DockStyle.Fill;
            subjects.FormattingEnabled = true;
            subjects.Items.AddRange(new object[] { "Bóng đá", "Bóng bàn", "Nhảy dù", "Bập bênh" });
            subjects.Location = new Point(3, 33);
            subjects.Name = "subjects";
            subjects.Size = new Size(144, 163);
            subjects.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.71429F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.2857132F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel4.Controls.Add(tb_result, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 318);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(350, 140);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 30);
            label5.TabIndex = 3;
            label5.Text = "Kết quả:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_exc);
            flowLayoutPanel1.Controls.Add(btn_reset);
            flowLayoutPanel1.Controls.Add(btn_exit);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(233, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(114, 104);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_exc
            // 
            btn_exc.Location = new Point(3, 3);
            btn_exc.Name = "btn_exc";
            btn_exc.Size = new Size(94, 29);
            btn_exc.TabIndex = 5;
            btn_exc.Text = "Nhập";
            btn_exc.UseVisualStyleBackColor = true;
            btn_exc.Click += btn_exc_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(3, 38);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 6;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(3, 73);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // tb_result
            // 
            tb_result.Dock = DockStyle.Fill;
            tb_result.ForeColor = Color.Blue;
            tb_result.Location = new Point(3, 33);
            tb_result.Multiline = true;
            tb_result.Name = "tb_result";
            tb_result.Size = new Size(224, 104);
            tb_result.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 489);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox cb_name;
        private Label label3;
        private DateTimePicker dt_date;
        private TableLayoutPanel tableLayoutPanel3;
        private ListBox chosen;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label4;
        private ListBox subjects;
        private Button btn_out;
        private Button btn_all_out;
        private Button btn_in;
        private Button btn_all_in;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_exc;
        private Button btn_reset;
        private Button btn_exit;
        private TextBox tb_result;
    }
}

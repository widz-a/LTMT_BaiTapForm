namespace MayTinhBoTui
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
            the_box = new TextBox();
            title = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_chia = new Button();
            btn_equal = new Button();
            btn_0 = new Button();
            btn_c = new Button();
            btn_nhan = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_tru = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_cong = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(the_box);
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 94);
            panel1.TabIndex = 0;
            // 
            // the_box
            // 
            the_box.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            the_box.BackColor = SystemColors.Window;
            the_box.Location = new Point(36, 52);
            the_box.Name = "the_box";
            the_box.ReadOnly = true;
            the_box.Size = new Size(243, 27);
            the_box.TabIndex = 1;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.Red;
            title.Location = new Point(40, 8);
            title.Name = "title";
            title.Size = new Size(236, 41);
            title.TabIndex = 0;
            title.Text = "Máy tính bỏ túi";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 348);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_chia, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_equal, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_c, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_nhan, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_tru, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_cong, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(312, 348);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_chia
            // 
            btn_chia.Dock = DockStyle.Fill;
            btn_chia.Location = new Point(237, 264);
            btn_chia.Name = "btn_chia";
            btn_chia.Size = new Size(72, 81);
            btn_chia.TabIndex = 26;
            btn_chia.Text = "/";
            btn_chia.UseVisualStyleBackColor = true;
            btn_chia.Click += btn_action_Click;
            // 
            // btn_equal
            // 
            btn_equal.Dock = DockStyle.Fill;
            btn_equal.Location = new Point(159, 264);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(72, 81);
            btn_equal.TabIndex = 25;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_0
            // 
            btn_0.Dock = DockStyle.Fill;
            btn_0.Location = new Point(81, 264);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(72, 81);
            btn_0.TabIndex = 24;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_number_Click;
            // 
            // btn_c
            // 
            btn_c.Dock = DockStyle.Fill;
            btn_c.Location = new Point(3, 264);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(72, 81);
            btn_c.TabIndex = 23;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = true;
            btn_c.Click += btn_c_Click;
            // 
            // btn_nhan
            // 
            btn_nhan.Dock = DockStyle.Fill;
            btn_nhan.Location = new Point(237, 177);
            btn_nhan.Name = "btn_nhan";
            btn_nhan.Size = new Size(72, 81);
            btn_nhan.TabIndex = 22;
            btn_nhan.Text = "*";
            btn_nhan.UseVisualStyleBackColor = true;
            btn_nhan.Click += btn_action_Click;
            // 
            // btn_9
            // 
            btn_9.Dock = DockStyle.Fill;
            btn_9.Location = new Point(159, 177);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(72, 81);
            btn_9.TabIndex = 21;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_number_Click;
            // 
            // btn_8
            // 
            btn_8.Dock = DockStyle.Fill;
            btn_8.Location = new Point(81, 177);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(72, 81);
            btn_8.TabIndex = 20;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_number_Click;
            // 
            // btn_7
            // 
            btn_7.Dock = DockStyle.Fill;
            btn_7.Location = new Point(3, 177);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(72, 81);
            btn_7.TabIndex = 19;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_number_Click;
            // 
            // btn_tru
            // 
            btn_tru.Dock = DockStyle.Fill;
            btn_tru.Location = new Point(237, 90);
            btn_tru.Name = "btn_tru";
            btn_tru.Size = new Size(72, 81);
            btn_tru.TabIndex = 18;
            btn_tru.Text = "-";
            btn_tru.UseVisualStyleBackColor = true;
            btn_tru.Click += btn_action_Click;
            // 
            // btn_6
            // 
            btn_6.Dock = DockStyle.Fill;
            btn_6.Location = new Point(159, 90);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(72, 81);
            btn_6.TabIndex = 17;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_number_Click;
            // 
            // btn_5
            // 
            btn_5.Dock = DockStyle.Fill;
            btn_5.Location = new Point(81, 90);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(72, 81);
            btn_5.TabIndex = 16;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_number_Click;
            // 
            // btn_4
            // 
            btn_4.Dock = DockStyle.Fill;
            btn_4.Location = new Point(3, 90);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(72, 81);
            btn_4.TabIndex = 15;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_number_Click;
            // 
            // btn_cong
            // 
            btn_cong.Dock = DockStyle.Fill;
            btn_cong.Location = new Point(237, 3);
            btn_cong.Name = "btn_cong";
            btn_cong.Size = new Size(72, 81);
            btn_cong.TabIndex = 14;
            btn_cong.Text = "+";
            btn_cong.UseVisualStyleBackColor = true;
            btn_cong.Click += btn_action_Click;
            // 
            // btn_3
            // 
            btn_3.Dock = DockStyle.Fill;
            btn_3.Location = new Point(159, 3);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(72, 81);
            btn_3.TabIndex = 13;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_number_Click;
            // 
            // btn_2
            // 
            btn_2.Dock = DockStyle.Fill;
            btn_2.Location = new Point(81, 3);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(72, 81);
            btn_2.TabIndex = 12;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_number_Click;
            // 
            // btn_1
            // 
            btn_1.Dock = DockStyle.Fill;
            btn_1.Location = new Point(3, 3);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(72, 81);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_number_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 442);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title;
        private TextBox the_box;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_2;
        private Button btn_1;
        private Button btn_chia;
        private Button btn_equal;
        private Button btn_0;
        private Button btn_c;
        private Button btn_nhan;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_tru;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_cong;
        private Button btn_3;
    }
}

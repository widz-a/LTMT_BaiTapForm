namespace PhepTinhPhanSo
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
            groupBox1 = new GroupBox();
            m1 = new TextBox();
            t1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            m2 = new TextBox();
            t2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            mr = new TextBox();
            tr = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            action_divide = new Button();
            action_multiply = new Button();
            action_minus = new Button();
            action_plus = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(m1);
            groupBox1.Controls.Add(t1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phân số 1";
            // 
            // m1
            // 
            m1.Location = new Point(82, 62);
            m1.Name = "m1";
            m1.Size = new Size(58, 27);
            m1.TabIndex = 3;
            // 
            // t1
            // 
            t1.Location = new Point(82, 32);
            t1.Name = "t1";
            t1.Size = new Size(58, 27);
            t1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Mẫu số:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Tử số:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(78, 9);
            label3.Name = "label3";
            label3.Size = new Size(272, 41);
            label3.TabIndex = 1;
            label3.Text = "Phép tính phân số";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(m2);
            groupBox2.Controls.Add(t2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(240, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Phân số 2";
            // 
            // m2
            // 
            m2.Location = new Point(82, 62);
            m2.Name = "m2";
            m2.Size = new Size(58, 27);
            m2.TabIndex = 3;
            // 
            // t2
            // 
            t2.Location = new Point(82, 32);
            t2.Name = "t2";
            t2.Size = new Size(58, 27);
            t2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Mẫu số:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 39);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 0;
            label5.Text = "Tử số:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(mr);
            groupBox3.Controls.Add(tr);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(240, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 125);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // mr
            // 
            mr.Location = new Point(82, 62);
            mr.Name = "mr";
            mr.ReadOnly = true;
            mr.Size = new Size(58, 27);
            mr.TabIndex = 3;
            // 
            // tr
            // 
            tr.Location = new Point(82, 32);
            tr.Name = "tr";
            tr.ReadOnly = true;
            tr.Size = new Size(58, 27);
            tr.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 69);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 1;
            label6.Text = "Mẫu số:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 39);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 0;
            label7.Text = "Tử số:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox4.Controls.Add(tableLayoutPanel1);
            groupBox4.Location = new Point(12, 246);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(154, 125);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Phép tính";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(action_divide, 1, 1);
            tableLayoutPanel1.Controls.Add(action_multiply, 0, 1);
            tableLayoutPanel1.Controls.Add(action_minus, 1, 0);
            tableLayoutPanel1.Controls.Add(action_plus, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(148, 99);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // action_divide
            // 
            action_divide.Dock = DockStyle.Fill;
            action_divide.Location = new Point(77, 52);
            action_divide.Name = "action_divide";
            action_divide.Size = new Size(68, 44);
            action_divide.TabIndex = 3;
            action_divide.Text = "/";
            action_divide.UseVisualStyleBackColor = true;
            action_divide.Click += action_divide_Click;
            // 
            // action_multiply
            // 
            action_multiply.Dock = DockStyle.Fill;
            action_multiply.Location = new Point(3, 52);
            action_multiply.Name = "action_multiply";
            action_multiply.Size = new Size(68, 44);
            action_multiply.TabIndex = 2;
            action_multiply.Text = "*";
            action_multiply.UseVisualStyleBackColor = true;
            action_multiply.Click += action_multiply_Click;
            // 
            // action_minus
            // 
            action_minus.Dock = DockStyle.Fill;
            action_minus.Location = new Point(77, 3);
            action_minus.Name = "action_minus";
            action_minus.Size = new Size(68, 43);
            action_minus.TabIndex = 1;
            action_minus.Text = "-";
            action_minus.UseVisualStyleBackColor = true;
            action_minus.Click += action_minus_Click;
            // 
            // action_plus
            // 
            action_plus.Dock = DockStyle.Fill;
            action_plus.Location = new Point(3, 3);
            action_plus.Name = "action_plus";
            action_plus.Size = new Size(68, 43);
            action_plus.TabIndex = 0;
            action_plus.Text = "+";
            action_plus.UseVisualStyleBackColor = true;
            action_plus.Click += action_plus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 465);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm tính phân số top 1 thế giới";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox m1;
        private TextBox t1;
        private Label label2;
        private Label label1;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox m2;
        private TextBox t2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox mr;
        private TextBox tr;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button action_plus;
        private Button action_divide;
        private Button action_multiply;
        private Button action_minus;
    }
}

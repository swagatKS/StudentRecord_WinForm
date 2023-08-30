namespace Assignment1_intern
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nametextBox = new TextBox();
            label5 = new Label();
            clgnametextBox = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton4 = new RadioButton();
            phnotextBox = new TextBox();
            cgpatextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            emailtextBox = new TextBox();
            label9 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(409, 34);
            label1.Name = "label1";
            label1.Size = new Size(163, 40);
            label1.TabIndex = 0;
            label1.Text = "Namaste!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 106);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 279);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "PhNo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 192);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 3;
            label4.Text = "College Name";
            label4.Click += label4_Click;
            // 
            // nametextBox
            // 
            nametextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nametextBox.Location = new Point(173, 100);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(646, 31);
            nametextBox.TabIndex = 4;
            nametextBox.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 235);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // clgnametextBox
            // 
            clgnametextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clgnametextBox.Location = new Point(173, 186);
            clgnametextBox.Name = "clgnametextBox";
            clgnametextBox.Size = new Size(646, 31);
            clgnametextBox.TabIndex = 6;
            clgnametextBox.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(173, 233);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(288, 231);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(411, 231);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(133, 29);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Transgender";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 147);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 10;
            label6.Text = "DOB";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(577, 231);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(168, 29);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Prefer not to say";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // phnotextBox
            // 
            phnotextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phnotextBox.Location = new Point(173, 273);
            phnotextBox.Name = "phnotextBox";
            phnotextBox.Size = new Size(646, 31);
            phnotextBox.TabIndex = 13;
            // 
            // cgpatextBox
            // 
            cgpatextBox.Location = new Point(173, 320);
            cgpatextBox.Name = "cgpatextBox";
            cgpatextBox.Size = new Size(113, 31);
            cgpatextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 326);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 15;
            label7.Text = "CGPA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 368);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 16;
            label8.Text = "E-mail (Gmail)";
            // 
            // emailtextBox
            // 
            emailtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailtextBox.Location = new Point(173, 362);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(646, 31);
            emailtextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 416);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 18;
            label9.Text = "Skills";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(173, 412);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 29);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Programming";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(351, 412);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(184, 29);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Web development";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(561, 412);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(147, 29);
            checkBox3.TabIndex = 21;
            checkBox3.Text = "Data analytics";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(735, 412);
            checkBox4.Name = "checkBox4";
            checkBox4.RightToLeft = RightToLeft.No;
            checkBox4.Size = new Size(115, 29);
            checkBox4.TabIndex = 22;
            checkBox4.Text = "UI Design";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(173, 447);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(86, 29);
            checkBox5.TabIndex = 23;
            checkBox5.Text = "AI/ML";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Poor Richard", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(140, 517);
            button1.Name = "button1";
            button1.Size = new Size(138, 59);
            button1.TabIndex = 24;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Poor Richard", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(332, 517);
            button2.Name = "button2";
            button2.Size = new Size(147, 59);
            button2.TabIndex = 25;
            button2.Text = "VIEW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Font = new Font("Poor Richard", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(520, 517);
            button3.Name = "button3";
            button3.Size = new Size(143, 59);
            button3.TabIndex = 26;
            button3.Text = "MODIFY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(840, 97);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 27;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ScrollBar;
            button5.Font = new Font("Poor Richard", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(704, 517);
            button5.Name = "button5";
            button5.Size = new Size(136, 59);
            button5.TabIndex = 28;
            button5.Text = "SAVE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(981, 644);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(emailtextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cgpatextBox);
            Controls.Add(phnotextBox);
            Controls.Add(radioButton4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(clgnametextBox);
            Controls.Add(label5);
            Controls.Add(nametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nametextBox;
        private Label label5;
        private TextBox clgnametextBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton4;
        private TextBox phnotextBox;
        private TextBox cgpatextBox;
        private Label label7;
        private Label label8;
        private TextBox emailtextBox;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
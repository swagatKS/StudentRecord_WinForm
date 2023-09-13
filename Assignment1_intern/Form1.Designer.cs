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
            label10 = new Label();
            serverIP = new Label();
            historyBox = new TextBox();
            buttonConnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(618, 54);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 0;
            label1.Text = "NAMASTE!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 129);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 302);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "PhNo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 215);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 3;
            label4.Text = "College Name";
            label4.Click += label4_Click;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(214, 123);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(649, 31);
            nametextBox.TabIndex = 4;
            nametextBox.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 258);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 5;
            label5.Text = "Gender";
            label5.Click += label5_Click;
            // 
            // clgnametextBox
            // 
            clgnametextBox.Location = new Point(214, 209);
            clgnametextBox.Name = "clgnametextBox";
            clgnametextBox.Size = new Size(652, 31);
            clgnametextBox.TabIndex = 6;
            clgnametextBox.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(214, 256);
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
            radioButton2.Location = new Point(329, 254);
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
            radioButton3.Location = new Point(452, 254);
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
            label6.Location = new Point(72, 170);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 10;
            label6.Text = "DOB";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(618, 254);
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
            phnotextBox.Location = new Point(214, 296);
            phnotextBox.Name = "phnotextBox";
            phnotextBox.Size = new Size(652, 31);
            phnotextBox.TabIndex = 13;
            // 
            // cgpatextBox
            // 
            cgpatextBox.Location = new Point(214, 343);
            cgpatextBox.Name = "cgpatextBox";
            cgpatextBox.Size = new Size(113, 31);
            cgpatextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 349);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 15;
            label7.Text = "CGPA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 391);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 16;
            label8.Text = "E-mail (Gmail)";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(214, 385);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(652, 31);
            emailtextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 444);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 18;
            label9.Text = "Skills";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(208, 444);
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
            checkBox2.Location = new Point(384, 444);
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
            checkBox3.Location = new Point(590, 444);
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
            checkBox4.Location = new Point(773, 444);
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
            checkBox5.Location = new Point(208, 491);
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
            button1.Location = new Point(88, 554);
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
            button2.Location = new Point(314, 554);
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
            button3.Location = new Point(556, 554);
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
            button4.Location = new Point(881, 120);
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
            button5.Location = new Point(796, 554);
            button5.Name = "button5";
            button5.Size = new Size(136, 59);
            button5.TabIndex = 28;
            button5.Text = "SAVE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(74, 36);
            label10.Name = "label10";
            label10.Size = new Size(84, 28);
            label10.TabIndex = 29;
            label10.Text = "Server:";
            // 
            // serverIP
            // 
            serverIP.AutoSize = true;
            serverIP.BorderStyle = BorderStyle.FixedSingle;
            serverIP.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            serverIP.Location = new Point(186, 36);
            serverIP.Name = "serverIP";
            serverIP.Size = new Size(170, 28);
            serverIP.TabIndex = 30;
            serverIP.Text = "127.0.0.1:12345";
            serverIP.Click += label11_Click;
            // 
            // historyBox
            // 
            historyBox.Location = new Point(1017, 120);
            historyBox.Multiline = true;
            historyBox.Name = "historyBox";
            historyBox.ScrollBars = ScrollBars.Both;
            historyBox.Size = new Size(362, 427);
            historyBox.TabIndex = 31;
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConnect.Location = new Point(384, 32);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(112, 34);
            buttonConnect.TabIndex = 32;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1415, 693);
            Controls.Add(buttonConnect);
            Controls.Add(historyBox);
            Controls.Add(serverIP);
            Controls.Add(label10);
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
        private Label label10;
        private Label serverIP;
        private TextBox historyBox;
        private Button buttonConnect;
    }
}
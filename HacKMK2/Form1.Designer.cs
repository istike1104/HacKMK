namespace HacKMK2
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            tbHowMany = new TextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            bt_start = new Button();
            btShowEverything = new Button();
            btShowDriver = new Button();
            btdriver1 = new Button();
            btdriver4 = new Button();
            btdriver2 = new Button();
            btdriver3 = new Button();
            richTextBox4 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1014, 404);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(1471, 707);
            button1.Name = "button1";
            button1.Size = new Size(228, 61);
            button1.TabIndex = 2;
            button1.Text = "Simulate a Day";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbHowMany
            // 
            tbHowMany.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbHowMany.Location = new Point(374, 21);
            tbHowMany.Name = "tbHowMany";
            tbHowMany.ReadOnly = true;
            tbHowMany.Size = new Size(314, 39);
            tbHowMany.TabIndex = 3;
            tbHowMany.TextChanged += tbHowMany_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(1074, 81);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(800, 406);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.HighlightText;
            richTextBox3.Location = new Point(678, 523);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(569, 394);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // bt_start
            // 
            bt_start.BackColor = Color.Transparent;
            bt_start.Location = new Point(-110, -110);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(212, 94);
            bt_start.TabIndex = 0;
            bt_start.UseVisualStyleBackColor = false;
            bt_start.Click += bt_start_Click;
            // 
            // btShowEverything
            // 
            btShowEverything.Font = new Font("Times New Roman", 13.8F);
            btShowEverything.Location = new Point(336, 960);
            btShowEverything.Name = "btShowEverything";
            btShowEverything.Size = new Size(230, 40);
            btShowEverything.TabIndex = 6;
            btShowEverything.Text = "Show Details";
            btShowEverything.UseVisualStyleBackColor = true;
            btShowEverything.Click += btShowEverything_Click;
            // 
            // btShowDriver
            // 
            btShowDriver.Font = new Font("Times New Roman", 13.8F);
            btShowDriver.Location = new Point(336, 960);
            btShowDriver.Name = "btShowDriver";
            btShowDriver.Size = new Size(230, 40);
            btShowDriver.TabIndex = 7;
            btShowDriver.Text = "Show Drivers";
            btShowDriver.UseVisualStyleBackColor = true;
            btShowDriver.Click += btShowDriver_Click;
            // 
            // btdriver1
            // 
            btdriver1.Font = new Font("Times New Roman", 13.8F);
            btdriver1.Location = new Point(173, 92);
            btdriver1.Name = "btdriver1";
            btdriver1.Size = new Size(230, 40);
            btdriver1.TabIndex = 8;
            btdriver1.Text = "Joe";
            btdriver1.UseVisualStyleBackColor = true;
            // 
            // btdriver4
            // 
            btdriver4.Font = new Font("Times New Roman", 13.8F);
            btdriver4.Location = new Point(1527, 92);
            btdriver4.Name = "btdriver4";
            btdriver4.Size = new Size(230, 40);
            btdriver4.TabIndex = 9;
            btdriver4.Text = "Gyurika";
            btdriver4.UseVisualStyleBackColor = true;
            // 
            // btdriver2
            // 
            btdriver2.Font = new Font("Times New Roman", 13.8F);
            btdriver2.Location = new Point(613, 92);
            btdriver2.Name = "btdriver2";
            btdriver2.Size = new Size(230, 40);
            btdriver2.TabIndex = 10;
            btdriver2.Text = "Robert";
            btdriver2.UseVisualStyleBackColor = true;
            btdriver2.Click += btdriver2_Click;
            // 
            // btdriver3
            // 
            btdriver3.Font = new Font("Times New Roman", 13.8F);
            btdriver3.Location = new Point(1074, 92);
            btdriver3.Name = "btdriver3";
            btdriver3.Size = new Size(230, 40);
            btdriver3.TabIndex = 11;
            btdriver3.Text = "Jack";
            btdriver3.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(336, 165);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(1261, 668);
            richTextBox4.TabIndex = 12;
            richTextBox4.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1856, 1003);
            Controls.Add(richTextBox4);
            Controls.Add(btdriver3);
            Controls.Add(btdriver2);
            Controls.Add(btdriver4);
            Controls.Add(btdriver1);
            Controls.Add(btShowDriver);
            Controls.Add(btShowEverything);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(tbHowMany);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(bt_start);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox tbHowMany;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button bt_start;
        private Button btShowEverything;
        private Button btShowDriver;
        private Button btdriver1;
        private Button btdriver4;
        private Button btdriver2;
        private Button btdriver3;
        private RichTextBox richTextBox4;
    }
}

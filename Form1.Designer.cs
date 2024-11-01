
namespace Win2PLC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            textBox6 = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label11 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            timer3 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label5 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(130, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(127, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(130, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 19);
            label1.TabIndex = 1;
            label1.Text = "设备IP地址";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(265, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(51, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(325, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(51, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(325, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 19);
            label2.TabIndex = 4;
            label2.Text = "插槽";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(265, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 19);
            label3.TabIndex = 5;
            label3.Text = "机架";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HighlightText;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(392, 49);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "连接";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(82, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 17);
            label4.TabIndex = 7;
            label4.Text = "存储器类型";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.HighlightText;
            button2.Enabled = false;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(473, 49);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 33);
            button2.TabIndex = 9;
            button2.Text = "断开";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(50, 501);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(117, 23);
            button3.TabIndex = 10;
            button3.Text = "DB2.DBX0.0置位";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(50, 531);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(117, 23);
            button4.TabIndex = 11;
            button4.Text = "DB2.DBX0.0复位";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DB", "M", "Q", "I" });
            comboBox1.Location = new System.Drawing.Point(83, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 25);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(214, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(73, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(385, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(65, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "X", "B", "W", "D" });
            comboBox2.Location = new System.Drawing.Point(297, 210);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(75, 25);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(460, 211);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(64, 23);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(173, 501);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(117, 23);
            button5.TabIndex = 17;
            button5.Text = "Q0.1点动";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseDown += button5_MouseDown;
            button5.MouseUp += button5_MouseUp;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(173, 531);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(117, 23);
            button6.TabIndex = 18;
            button6.Text = "Q0.2取反";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(213, 190);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 17);
            label6.TabIndex = 19;
            label6.Text = "数据块编号";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(297, 190);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 17);
            label7.TabIndex = 20;
            label7.Text = "数据类型";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(385, 191);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(44, 17);
            label8.TabIndex = 21;
            label8.Text = "偏移值";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(460, 191);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(20, 17);
            label9.TabIndex = 22;
            label9.Text = "位";
            // 
            // groupBox1
            // 
            groupBox1.Location = new System.Drawing.Point(43, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(506, 116);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "自定义操作对象";
            // 
            // button7
            // 
            button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button7.Enabled = false;
            button7.Location = new System.Drawing.Point(50, 314);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(75, 23);
            button7.TabIndex = 24;
            button7.Text = "读取";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button8.Enabled = false;
            button8.Location = new System.Drawing.Point(50, 429);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(75, 23);
            button8.TabIndex = 25;
            button8.Text = "写入";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label10.AutoSize = true;
            label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label10.Location = new System.Drawing.Point(108, 280);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(32, 17);
            label10.TabIndex = 26;
            label10.Text = "符号";
            label10.Click += label10_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(50, 280);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(56, 17);
            label11.TabIndex = 27;
            label11.Text = "操作对象";
            // 
            // textBox7
            // 
            textBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox7.Location = new System.Drawing.Point(150, 314);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox7.Size = new System.Drawing.Size(399, 99);
            textBox7.TabIndex = 28;
            // 
            // textBox8
            // 
            textBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox8.Location = new System.Drawing.Point(150, 429);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(399, 23);
            textBox8.TabIndex = 29;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new System.Drawing.Point(50, 343);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(75, 21);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "自动采集";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timer3
            // 
            timer3.Interval = 300;
            timer3.Tick += timer3_Tick;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1185, 111);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.图片1;
            pictureBox2.Location = new System.Drawing.Point(-1, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(106, 84);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1115, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 41);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(672, 164);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 17);
            label5.TabIndex = 33;
            label5.Text = "label5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(672, 192);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(50, 17);
            label12.TabIndex = 34;
            label12.Text = "label12";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(1184, 681);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            Text = "西门子S7PLC调试工具 —— RayWoo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}


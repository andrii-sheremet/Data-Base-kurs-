namespace Data_Base__kurs_.Forms
{
    partial class CatsTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatsTypes));
            panel1 = new Panel();
            Back = new PictureBox();
            splitContainer1 = new SplitContainer();
            label11 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(Back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 36);
            panel1.TabIndex = 1;
            // 
            // Back
            // 
            Back.Dock = DockStyle.Left;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(0, 0);
            Back.Name = "Back";
            Back.Size = new Size(53, 36);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 0;
            Back.TabStop = false;
            Back.Click += Back_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 36);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightSlateGray;
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(comboBox6);
            splitContainer1.Panel1.Controls.Add(comboBox5);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(comboBox4);
            splitContainer1.Panel1.Controls.Add(comboBox3);
            splitContainer1.Panel1.Controls.Add(radioButton1);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(comboBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(773, 458);
            splitContainer1.SplitterDistance = 286;
            splitContainer1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(255, 277);
            label11.Name = "label11";
            label11.Size = new Size(30, 21);
            label11.TabIndex = 23;
            label11.Text = "см";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(255, 247);
            label10.Name = "label10";
            label10.Size = new Size(26, 21);
            label10.TabIndex = 22;
            label10.Text = "гр";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "-", "0-1", "1-2", "2-5", "5-10", "10+" });
            comboBox6.Location = new Point(149, 192);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(100, 23);
            comboBox6.TabIndex = 20;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "-", "0-1", "1-2", "2-5", "5-10", "10+" });
            comboBox5.Location = new Point(149, 134);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(100, 23);
            comboBox5.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(11, 301);
            label9.Name = "label9";
            label9.Size = new Size(143, 42);
            label9.TabIndex = 18;
            label9.Text = "Потрібен догляд\r\n за шерстю";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 273);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 17;
            label8.Text = "Розмір";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(60, 243);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 16;
            label7.Text = "Вага";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 190);
            label6.Name = "label6";
            label6.Size = new Size(95, 42);
            label6.TabIndex = 15;
            label6.Text = "Тривалість\r\n(max вік)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 82);
            label5.Name = "label5";
            label5.Size = new Size(123, 42);
            label5.TabIndex = 14;
            label5.Text = "Походження \r\n(місто/країна)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 161);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 13;
            label4.Text = "Колір";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 131);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 12;
            label3.Text = "Вік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 11;
            label2.Text = "Назва породи";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 10;
            label1.Text = "Ім'я кота";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(78, 374);
            button1.Name = "button1";
            button1.Size = new Size(117, 51);
            button1.TabIndex = 9;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "-", "0-10", "10-20", "20-30", "30-40", "40+" });
            comboBox4.Location = new Point(149, 275);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 23);
            comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "-", "0-500", "500-750", "750-1000", "1000-2000", "2000-5000", "5000+" });
            comboBox3.Location = new Point(149, 245);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 23);
            comboBox3.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(188, 319);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "-", "Чорний", "Коричневий", "Сірий", "Білий", "Рижий", "Русий", "Мішаний" });
            comboBox2.Location = new Point(149, 163);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(483, 458);
            dataGridView1.TabIndex = 0;
            // 
            // CatsTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(773, 494);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CatsTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Види котів";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Back;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Button button1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private TextBox textBox3;
        private Label label10;
        private Label label11;
    }
}
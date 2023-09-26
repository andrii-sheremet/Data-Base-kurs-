namespace Data_Base__kurs_.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            LoginButton = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(LoginButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 42);
            panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Dock = DockStyle.Right;
            LoginButton.Image = (Image)resources.GetObject("LoginButton.Image");
            LoginButton.Location = new Point(718, 0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(55, 42);
            LoginButton.SizeMode = PictureBoxSizeMode.Zoom;
            LoginButton.TabIndex = 0;
            LoginButton.TabStop = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 452);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(611, 437);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 5;
            label3.Text = "Шеремета Андрія ПЗПІ-22-6";
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(531, 257);
            button3.Name = "button3";
            button3.Size = new Size(230, 161);
            button3.TabIndex = 4;
            button3.Text = "Цікаві статті\r\nта інформація";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(274, 257);
            button2.Name = "button2";
            button2.Size = new Size(230, 161);
            button2.TabIndex = 3;
            button2.Text = "Виставки котів ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 257);
            button1.Name = "button1";
            button1.Size = new Size(230, 161);
            button1.TabIndex = 2;
            button1.Text = "Різновидності котів\r\nЇх породи та особливості\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(496, 28);
            label2.Name = "label2";
            label2.Size = new Size(265, 189);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 70);
            label1.Name = "label1";
            label1.Size = new Size(494, 86);
            label1.TabIndex = 0;
            label1.Text = "Виставка котів";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(773, 494);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головна";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoginButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox LoginButton;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label3;
    }
}
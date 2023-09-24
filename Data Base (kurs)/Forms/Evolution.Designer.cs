namespace Data_Base__kurs_.Forms
{
    partial class Evolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evolution));
            panel1 = new Panel();
            Back = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Back).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(Back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 62);
            panel1.TabIndex = 2;
            // 
            // Back
            // 
            Back.Dock = DockStyle.Left;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.Location = new Point(0, 0);
            Back.Name = "Back";
            Back.Size = new Size(80, 62);
            Back.SizeMode = PictureBoxSizeMode.Zoom;
            Back.TabIndex = 0;
            Back.TabStop = false;
            // 
            // Evolution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(773, 494);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Evolution";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Розвиток кота";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Back;
    }
}
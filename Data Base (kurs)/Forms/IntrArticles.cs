using Data_Base__kurs_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Data_Base__kurs_.Forms
{
    public partial class IntrArticles : Form
    {
        public IntrArticles()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            Care f = new();
            f.FormClosed += (sender, e) => this.Visible = true;
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evolution f = new();
            f.FormClosed += (sender, e) => this.Visible = true;
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://uk.wikipedia.org/wiki/%D0%A1%D0%BF%D0%B8%D1%81%D0%BE%D0%BA_%D0%BA%D0%BE%D1%82%D1%8F%D1%87%D0%B8%D1%85_%D0%BF%D0%BE%D1%80%D1%96%D0%B4",
                UseShellExecute = true
            });

        private void button4_Click(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://t1.ua/porady/17385-25-tsikavykh-faktiv-pro-kotiv.html",
                UseShellExecute = true
            });

        private void button5_Click(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=xEBMe0AVC8g",
                UseShellExecute = true
            });

        private void button6_Click(object sender, EventArgs e) =>
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/andrey_shr",
                UseShellExecute = true
            });
    }
}

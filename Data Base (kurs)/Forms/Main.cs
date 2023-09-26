using Data_Base__kurs_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base__kurs_.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login l = new();
            l.FormClosed += (sender, e) => this.Enabled = true;
            this.Enabled = false;
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatsTypes f = new CatsTypes();
            f.FormClosed += (sender, e) => this.Visible = true;
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exhibitions f = new();
            f.FormClosed += (sender, e) => this.Visible = true;
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntrArticles f = new();
            f.FormClosed += (sender, e) => this.Visible = true;
            f.Show();
            this.Hide();
        }
    }
}

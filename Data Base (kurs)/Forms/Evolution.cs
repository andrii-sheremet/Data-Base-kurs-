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
    public partial class Evolution : Form
    {
        public Evolution()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            (new IntrArticles()).Show();
        }
    }
}

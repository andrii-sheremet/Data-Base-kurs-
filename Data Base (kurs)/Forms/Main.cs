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
        /*Pages.forms.Push(this);*/
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login f = new();
            f.Show();
        }
    }
}

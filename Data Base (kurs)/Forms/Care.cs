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
    public partial class Care : Form
    {
        public Care()
        {
            InitializeComponent();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(151, 168);
            panel2.BackColor = System.Drawing.Color.White;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(141, 158);
            panel2.BackColor = System.Drawing.Color.AliceBlue;
        }
    }
}

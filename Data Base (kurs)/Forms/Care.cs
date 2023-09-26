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
        private void panel2_MouseEnter_1(object sender, EventArgs e) =>
            panel2.BackColor = System.Drawing.Color.Lavender;

        private void panel2_MouseLeave_1(object sender, EventArgs e) =>
            panel2.BackColor = System.Drawing.Color.AliceBlue;

        private void panel2_Click(object sender, EventArgs e) =>
            MessageBox.Show("Дотримуйтесь рекомендацій ветеринара щодо типу і кількості корму. Забезпечте свого кота збалансованою дієтою, яка відповідає його віку, розміру і активності.",
                "Годування", MessageBoxButtons.OK);

        private void panel4_MouseEnter(object sender, EventArgs e) =>
            panel4.BackColor = System.Drawing.Color.Lavender;

        private void panel4_MouseLeave(object sender, EventArgs e) =>
            panel4.BackColor = System.Drawing.Color.AliceBlue;

        private void panel4_Click(object sender, EventArgs e) =>
            MessageBox.Show("Забезпечте доступ до чистої прісної води завжди, щоб ваш кіт не висох.",
                "Питна вода", MessageBoxButtons.OK);


        private void panel7_Click(object sender, EventArgs e) =>
            MessageBox.Show("Регулярно чистіть лоток для горшків та забезпечуйте йому свіже наповнення. Також очищайте шерсть кота, робіть щеплення та обробку від паразитів.",
                "Гігієна", MessageBoxButtons.OK);

        private void panel7_MouseEnter(object sender, EventArgs e) =>
            panel6.BackColor = System.Drawing.Color.Lavender;

        private void panel7_MouseLeave(object sender, EventArgs e) =>
            panel6.BackColor = System.Drawing.Color.AliceBlue;


        private void label5_Click(object sender, EventArgs e) =>
            MessageBox.Show("Коти потребують фізичної активності. Грайте з ними, надайте можливість полазити і розтягнутися.",
                "Забезпечення руху", MessageBoxButtons.OK);

        private void label5_MouseEnter(object sender, EventArgs e) =>
            panel8.BackColor = System.Drawing.Color.Lavender;

        private void label5_MouseLeave(object sender, EventArgs e) =>
            panel8.BackColor = System.Drawing.Color.AliceBlue;



        private void panel10_Click(object sender, EventArgs e) =>
            MessageBox.Show(" Коти - це соціальні тварини, і вони потребують уваги та зустрічей з вами. Надавайте їм часу і ласки, граючися та гладячи.",
                "Увага та ласка", MessageBoxButtons.OK);

        private void panel10_MouseEnter(object sender, EventArgs e) =>
            panel10.BackColor = System.Drawing.Color.Lavender;

        private void panel10_MouseLeave(object sender, EventArgs e) =>
            panel10.BackColor = System.Drawing.Color.AliceBlue;



        private void panel12_Click(object sender, EventArgs e) =>
            MessageBox.Show("Регулярно відвідуйте ветеринара для медичного обстеження і вакцинацій. Дотримуйтесь графіку вакцинацій та лікування від паразитів.",
                "Візити до ветеринара", MessageBoxButtons.OK);

        private void panel12_MouseEnter(object sender, EventArgs e) =>
            panel12.BackColor = System.Drawing.Color.Lavender;

        private void panel12_MouseLeave(object sender, EventArgs e) =>
            panel12.BackColor = System.Drawing.Color.AliceBlue;



        private void panel14_MouseClick(object sender, MouseEventArgs e) =>
            MessageBox.Show("Забезпечте безпечну обстановку у вашому домі. Приховуйте небезпечні для кота речі, які він може відгризти або проковзнути.",
                "Безпека", MessageBoxButtons.OK);

        private void panel14_MouseEnter(object sender, EventArgs e) =>
            panel14.BackColor = System.Drawing.Color.Lavender;

        private void panel14_MouseLeave(object sender, EventArgs e) =>
            panel14.BackColor = System.Drawing.Color.AliceBlue;




        private void panel16_Click(object sender, EventArgs e) =>
            MessageBox.Show("Забезпечте коту місце для гостріння кігтів, таке як кращий для цього казанок. Також надайте йому тихе та спокійне місце для відпочинку.",
                "Помітки та відпочинок", MessageBoxButtons.OK);

        private void panel16_MouseEnter(object sender, EventArgs e) =>
            panel16.BackColor = System.Drawing.Color.Lavender;

        private void panel16_MouseLeave(object sender, EventArgs e) =>
            panel16.BackColor = System.Drawing.Color.AliceBlue;
    }
}

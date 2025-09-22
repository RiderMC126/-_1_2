using System;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a) ||
                !double.TryParse(textBoxB.Text, out double b) ||
                !double.TryParse(textBoxC.Text, out double c))
            {
                labelResult.Text = "Ошибка: введите корректные числа!";
                return;
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                labelResult.Text = "Ошибка: стороны должны быть больше 0!";
                return;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                labelResult.Text = "Ошибка: такие стороны не образуют треугольник!";
                return;
            }
            double[] sides = { a, b, c };
            Array.Sort(sides); 

            double a2 = sides[0] * sides[0];
            double b2 = sides[1] * sides[1];
            double c2 = sides[2] * sides[2];
            string type = "";
            if (Math.Abs(c2 - (a2 + b2)) < 1e-6)
                type = "Прямоугольный треугольник";
            else if (c2 < (a2 + b2))
                type = "Остроугольный треугольник";
            else
                type = "Тупоугольный треугольник";
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            labelResult.Text = $"Тип по углам: {type}\nПлощадь: {area:F2}";
        }
    }
}

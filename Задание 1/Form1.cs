using System;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

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
            string type = "";
            if (a == b && b == c)
                type = "Равносторонний треугольник";
            else if (a == b || a == c || b == c)
                type = "Равнобедренный треугольник";
            else
                type = "Разносторонний треугольник";
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            labelResult.Text = $"Тип: {type}\nПлощадь: {area:F2}";
        }
    }
}

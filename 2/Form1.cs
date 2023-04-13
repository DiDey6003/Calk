using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2
{
    public partial class Form1 : Form
    {

        float a, b;
        int count;//нужны для вычислений
        bool znak = true;//для того, чтобы менять знаки у введеных чисел, true-положит, false-отриц

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);// в переменную b записывается результат сложения а(введено ранее) и второго число, введенного пользователем,которое преображается в вещественный тип
                    textBox1.Text = b.ToString();//b переводится в вещественный тип и результат появляется в текстбоксе
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default://если count принял не допустимое значение
                    break;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//удаление последней цифры
        {
            int lenght = textBox1.Text.Length - 1;//записываем количество символов в текстбоксе минус 1(тк удаляем один символ)
            string text = textBox1.Text;//в эту переменную заносится текст из текстбокса
            textBox1.Clear();//текстбокс очищается
            for (int i = 0; i < lenght; i++)//в этом цикле в текстбокс записывается текст из текстбокса на символ короче
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button2_Click_1(object sender, EventArgs e)// удаляет все содержимое
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)//обработка +/-. изначально переменная знак равна true, если нажать на кнопку +/-, то у числа меняется знак на отрицательный, при нажатии второй раз - на положительный
        {
            if (znak == true)//если положит
            {
                textBox1.Text = "-" + textBox1.Text;//делаем отриц
                znak = false;
            }
            else if (znak == false)//если отриц
            {
                textBox1.Text = textBox1.Text.Replace("-", "");//делаем положит. Replace()-заменяет часть строки на другую, в нашем случае меняет минус на пробел
                znak = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)//разность
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button5_Click_1(object sender, EventArgs e)//сложение
        {
            a = float.Parse(textBox1.Text);//присваивание значения, которое пользователь введет перед тем, как нажать +
            textBox1.Clear();//очищение текстбокса, значение сохраняется в переменной а
            count = 1;//нужно для определения действия(1 +, 2 -, 3 *, 4 /)
            label1.Text = a.ToString() + "+";//записывается число, которое ввел пользователь и знак +
            znak = true;
        }

        private void button6_Click(object sender, EventArgs e)//умножение
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button7_Click_1(object sender, EventArgs e)//деление (ошибка вместо / выводит -)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button8_Click_1(object sender, EventArgs e)//для того, чтобы в текстбоксе отображалась цифра 1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click_1(object sender, EventArgs e)//2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click_1(object sender, EventArgs e)//3 (ошибка вместо 3 выводит 5)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click_1(object sender, EventArgs e)//4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button12_Click_1(object sender, EventArgs e)//5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click_1(object sender, EventArgs e)//6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button14_Click_1(object sender, EventArgs e)//7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button15_Click_1(object sender, EventArgs e)//8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button16_Click_1(object sender, EventArgs e)//9
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button17_Click_1(object sender, EventArgs e)//0
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e)//,
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button19_Click_1(object sender, EventArgs e)//вывод результата
        {
            calculate();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

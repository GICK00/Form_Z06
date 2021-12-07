using System;
using System.Linq;
using System.Windows.Forms;

namespace Form_Z06_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN.Text);
                if (n < 1)
                    throw new Exception("Размер массива не может быть меньше 1!");
                int[,] mas = new int[n, n];
                int[,] tmp = new int[n, n];

                read(mas, n);
                print(mas, n);
                revers(mas, tmp, n);
            }
            catch (FormatException)
            {
                textBoxArr.Text = "Некорректный ввод данных!";
            }
            catch (Exception ex)
            {
                textBoxArr.Text = $"{ex.Message}";
            }
        }
        private void read(int[,] dvymer, int n)
        {
            int[] mas = textBoxArr.Text.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            if (n * n != mas.Length)
                throw new Exception("Количество элементов не соответствует размеру массива!");
            int w = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dvymer[i, j] = mas[w];
                    w++;
                }
            }
            textBoxArr.Text = "";
        }
        private void print(int[,] dvymer, int n)
        {
            textBoxArr.Text += "Размер массива: " + n + ", " + n + "\r\nЭлементы:\r\n";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textBoxArr.Text += String.Format("{0,4}", dvymer[i, j]);
                }
                textBoxArr.Text += "\r\n";
            }
        }
        private void revers(int[,] mas, int[,] tmp, int n)
        {
            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j += 2)
                    {
                        tmp[i, j] = mas[i, j];
                        mas[i, j] = mas[i, j + 1];
                        mas[i, j + 1] = tmp[i, j];
                    }
                }
                textBoxArr.Text += "Измененый массив\r\n";
                print(mas, n);
            }
            else
            {
                textBoxArr.Text += "Число столбцов не четное.\r\n";
                print(mas, n);
            }
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace Form_Z06_4
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
                int[] mas2 = new int[n];

                read(mas, n);
                print(mas, n);
                plus(mas, mas2, n);
                print(mas2, n);
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
        public void print(int[] mas2, int n)
        {
            textBoxArr.Text += "Размер массива: " + n + "\r\nЭлементы:\r\n";
            for (int i = 0; i < n; i++)
            {
                textBoxArr.Text += "  " + mas2[i];
            }
            textBoxArr.Text += "\r\n";
        }
        static void plus(int[,] mas, int[] mas2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int plus = 0;
                for (int j = 0; j < n; j++)
                {
                    if (mas[j, i] >= plus)
                    {
                        plus = mas[j, i];
                        break;
                    }
                }
                mas2[i] = plus;
            }
        }
    }
}

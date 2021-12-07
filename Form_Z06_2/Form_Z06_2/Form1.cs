using System;
using System.Linq;
using System.Windows.Forms;

namespace Form_Z06_2
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
                int[] odnomer = new int[n];

                read(odnomer, n);
                print(odnomer, max(odnomer));

                textBoxArr.Text += "Номер максимального элемента: " + max(odnomer);
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
        private void read(int[] odnomer, int n)
        {
            int[] mas = textBoxArr.Text.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            if (n != mas.Length)
                throw new Exception("Количество элементов не соответствует размеру массива!");

            for (int i = 0; i < n; i++)
            {
                odnomer[i] = mas[i];
            }
        }
        private void print(int[] odnomer, int numberMax)
        {
            textBoxArr.Text = "Полученный массив:" + "\r\n";
            textBoxArr.Text += ("Номер ---->");
            for (int i = 1; i <= odnomer.Length; i++)
            {
                if (numberMax == i)
                {
                    textBoxArr.Text += String.Format("{0,4}", i);
                }
                else
                    textBoxArr.Text += String.Format("{0,4}", i);
            }
            textBoxArr.Text += "\r\n";

            textBoxArr.Text += "Элемент ->";
            for (int i = 0; i < odnomer.Length; i++)
            {
                textBoxArr.Text += String.Format("{0,4}", odnomer[i]);
            }
            textBoxArr.Text += "\r\n";
        }
        static int max(int[] odnomer)
        {
            int max = 0, numberMax = 0;
            for (int i = 0; i < odnomer.Length; i++)
            {
                if (odnomer[i] > max)
                {
                    max = odnomer[i];
                    numberMax = i + 1;
                }
            }
            return numberMax;
        }
    }
}

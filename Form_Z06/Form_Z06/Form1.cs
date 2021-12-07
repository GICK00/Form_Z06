using System;
using System.Linq;
using System.Windows.Forms;

namespace Form_Z06
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
                print(odnomer);
                textBoxArr.Text += "Cумма элементов, кратных 9: " + sum(odnomer);
            }
            catch (FormatException)
            {
                textBoxArr.Text = "Некорректный ввод данных!";
            }
            catch (Exception ex)
            {
                textBoxArr.Text = ex.Message;
            }            
        }
        private void buttonStart2_Click(object sender, EventArgs e)
        {
            try
            {
                int nD = Convert.ToInt32(textBoxNd.Text);
                int mD = Convert.ToInt32(textBoxMd.Text);

                if (nD < 1 || mD < 1)
                    throw new Exception("Размер массива не может быть меньше 1!");
                int[,] dvymer = new int[nD, mD];
                
                read(dvymer, nD, mD);
                print(dvymer, nD, mD);
                textBoxArrD.Text += "Cумма элементов, кратных 9: " + sum(dvymer, nD, mD);
            }
            catch (FormatException)
            {
                textBoxArrD.Text = "Некорректный ввод данных!";
            }
            catch (Exception ex)
            {
                textBoxArrD.Text = ex.Message;
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
        private void read(int[,] dvymer, int nD, int mD)
        {
            int[] mas = textBoxArrD.Text.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            if (nD * mD != mas.Length)
                throw new Exception("Количество элементов не соответствует размеру массива!");
            int w = 0;
            for (int i = 0; i < nD; i++)
            {
                for (int j = 0; j < mD; j++)
                {
                    dvymer[i, j] = mas[w];
                    w++;
                }
            }
        }
        private void print(int[] odnomer)
        {
            textBoxArr.Text = "Размер массива: " + odnomer.Length + "\r\nЭлементы:\r\n";
            for (int i = 0; i < odnomer.Length; i++)
            {
                textBoxArr.Text += " " + odnomer[i];
            }
            textBoxArr.Text += "\r\n";
        }
        private void print(int[,] dvymer, int nD, int mD)
        {
            textBoxArrD.Text = "Размер массива: " + nD + ", " + mD + "\r\nЭлементы:\r\n";
            for (int i = 0; i < nD; i++)
            {
                for (int j = 0; j < mD; j++)
                {
                    textBoxArrD.Text += String.Format("{0,4}", dvymer[i, j]);
                }
                textBoxArrD.Text += "\r\n";
            }
        }
        static int sum(int[] odnomer)
        {
            int sumOdnomer = 0;
            for (int i = 0; i < odnomer.Length; i++)
            {
                if (odnomer[i] % 9 == 0)
                {
                    sumOdnomer += odnomer[i];
                }
            }
            return sumOdnomer;
        }
        static int sum(int[,] dvymer, int nD, int mD)
        {
            int sumDvymer = 0;
            for (int i = 0; i < nD; i++)
            {
                for (int j = 0; j < mD; j++)
                {
                    if (dvymer[i, j] % 9 == 0)
                    {
                        sumDvymer += dvymer[i, j];
                    }
                }
            }
            return sumDvymer;
        }
    }
}

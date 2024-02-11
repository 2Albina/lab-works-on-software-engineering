using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_SDI
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        bool IsSimple(int number)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(number) && flag; i++)
            {
                if (number % i == 0)
                    flag = false;
            }
            return flag;
        }

        private void OkDialog_Click(object sender, EventArgs e)
        {
            if (rB1.Checked)
            {
                Result1 r1;
                r1 = new Result1();

                r1.richTextBox1.Text = rB1.Text;
                bool flag = false;
                for (int i = 0; (i < Task1.arr.GetLength(0)) && !flag; i++)
                    for (int j = 0; (j < Task1.arr.GetLength(1)) && !flag; j++)
                    {
                        if (IsSimple(Convert.ToInt32(Task1.arr[i, j])))
                            flag = true;
                    }

                if (flag)
                    r1.label1.Text = "В массиве есть простые числа";
                else
                    r1.label1.Text = "В массиве нет простых чисел";

                r1.Show();

                //Task t1;
                //t1 = new Task();
                //t1.Show();
            }
            else if (rB2.Checked)
            {
                Result1 r1;
                r1 = new Result1();
                double avr = 0;

                r1.richTextBox1.Text = rB2.Text;
                for (int i = 0; i < Task1.arr.GetLength(0); i++)
                    for (int j = i + 1; j < Task1.arr.GetLength(1); j++)
                        avr += Convert.ToInt32(Task1.arr[i, j]);

                int count = Task1.arr.GetLength(0) * Task1.arr.GetLength(1);
                if (count > 0)
                {
                    avr = avr / count;
                    r1.label1.Text = "Среднее арифметическое: " + avr;
                }
                else r1.label1.Text = "Нет элементов в массиве!";

                r1.ShowDialog();
            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

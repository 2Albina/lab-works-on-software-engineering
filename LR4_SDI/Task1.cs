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
    public partial class Task1 : Form
    {
        public static int[,] arr;
        public Task1()
        {
            InitializeComponent();
            dG1.RowCount = 9;
            KolRow.Text = Convert.ToString(dG1.RowCount);
            dG1.ColumnCount = 6;
            KolCol.Text = Convert.ToString(dG1.ColumnCount);
            for (int i = 0; i < dG1.ColumnCount; i++)
            {
                dG1.Columns[i].Width = 50;
                dG1.Columns[i].HeaderText = Convert.ToString(i+1);
            }
            for (int i = 0; i < dG1.RowCount; i++)
            {
                dG1.Rows[i].HeaderCell.Value = (i+1).ToString(); // doesn't work
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog d1;
            d1 = new Dialog();
            d1.Show();

            //bool flag = false;
            //for (int i = 0; (i < dG1.RowCount) && !flag; i++)
            //    for (int j = 0; (j < dG1.ColumnCount) && !flag; j++)
            //    {
            //        if (IsSimple(Convert.ToInt32(dG1.Rows[i].Cells[j].Value)))
            //            flag = true;
            //    }

            //Result1 r1;
            //r1 = new Result1();

            //if (flag)
            //    r1.label1.Text = "В массиве есть простые числа";
            //else
            //    r1.label1.Text = "В массиве нет простых чисел";

            //r1.ShowDialog();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (KolCol.Text != "")
            {
                dG1.ColumnCount = Convert.ToInt32(KolCol.Text);
                for (int i = 0; i < dG1.ColumnCount; i++)
                {
                    dG1.Columns[i].Width = 50;
                    dG1.Columns[i].HeaderText = Convert.ToString(i+1);}
            }
        }

        private void KolRow_TextChanged(object sender, EventArgs e)
        {
            if (KolRow.Text != "")
            {
                dG1.RowCount = Convert.ToInt32(KolRow.Text);
                for (int i = 0; i < dG1.RowCount; i++)
                {
                    dG1.Rows[i].HeaderCell.Value = (i + 1).ToString(); 
                }
            }
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            arr = new int[dG1.RowCount, dG1.ColumnCount];
            Random rnd = new Random();
            for (int i = 0; i < dG1.RowCount; i++)
                for (int j = 0; j < dG1.ColumnCount; j++)
                {
                    int number = rnd.Next(2, 100);
                    while (cB1.Checked && IsSimple(number))
                        number++;
                    dG1.Rows[i].Cells[j].Value = Convert.ToString(number);
                    arr[i, j] = number;
                }
        }
    }
}

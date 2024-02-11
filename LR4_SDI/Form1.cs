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
    public partial class SDI : Form
    {

        static public Task1 t1;
        public SDI()
        {
            InitializeComponent();
            t1 = new Task1();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab1;
            ab1 = new AboutBox();
            ab1.ShowDialog();
        }

        public void dialog_Click(object sender, EventArgs e)
        {

            TaskMenu.Enabled = false;
            t1.Show();
            //Dialog d1;
            //d1 = new Dialog();
            //TaskMenu.Enabled = false; // нельзя открывать 2-е диалоговое окно
            //d1.Show();
        }
    }
}

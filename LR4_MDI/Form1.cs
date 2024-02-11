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
    public partial class MDI : Form
    {
        static public Task1 t1;
        public MDI()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab1;
            ab1 = new AboutBox();
            ab1.MdiParent = this;
            ab1.Show();
        }

        public void dialog_Click(object sender, EventArgs e)
        {
            t1 = new Task1();
            t1.MdiParent = this;
            TaskMenu.Enabled = false;
            //t1.f1 = this;
            t1.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeCurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)  //проверяем, что есть хотя бы 1 дочернее окно
                ActiveMdiChild.Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i = MdiChildren.Length-1; i>=0; i--)
            //MdiChildren[i].Close();
            foreach (Form x in MdiChildren)
                x.Close();
        }
    }
}

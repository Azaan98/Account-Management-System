using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menuu : Form
    {
        public menuu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create f2 = new create();
            f2.ShowDialog();
        }

        private void searchUpdateAndDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crud f3 = new crud();
            f3.ShowDialog();
        }

        private void transferMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transfer f4 = new transfer();
            f4.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceshet f6 = new balanceshet();
            f6.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void depositMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void bankimage_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create f = new create();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud f = new crud();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transfer f = new transfer();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            balanceshet f6 = new balanceshet();
            f6.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Hide();
            new Prikaz().ShowDialog();
            Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new Uplata().ShowDialog();
            Show();
        }

        private void uplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Uplata().ShowDialog();
            Show();
        }

        private void pregledDugovanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Prikaz().ShowDialog();
            Show();
        }
    }
}

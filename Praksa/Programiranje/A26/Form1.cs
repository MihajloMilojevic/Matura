using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            new Placanje().ShowDialog();
            Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            new Rezervacija().ShowDialog();
            Show();
        }
    }
}

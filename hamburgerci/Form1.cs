using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage giris = new HomePage();
            giris.Show();
            this.Hide();
        }

        private void menueklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPage menuekle = new MenuPage();
            menuekle.Show();
            this.Hide();
        }
    }
}

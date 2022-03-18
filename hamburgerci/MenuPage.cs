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
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            HomePage giris = new HomePage();
           
            
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            Form1 baslangicformu = new Form1();
            this.Hide();
            baslangicformu.Show();
        }
    }
}

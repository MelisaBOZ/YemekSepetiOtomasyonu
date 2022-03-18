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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public static List<hamburger> menuekle = new List<hamburger>();
        private void HomePage_Load(object sender, EventArgs e)
        {
            hamburger tavukburger = new hamburger { adi = "tavukburger", fiyat = 15 };

            hamburger kofteburger = new hamburger { adi = "köfteburger ", fiyat = 20 };

            hamburger doublekofteburger = new hamburger { adi = "double kofte ", fiyat = 35 };

            menuekle.Add(tavukburger);
            menuekle.Add(kofteburger);
            menuekle.Add(doublekofteburger);
            foreach (var item in menuekle )
            {
                menucb.Items.Add(item);
            }
          /*  menucb.Items.Add(tavukburger);
            menucb.Items.Add(kofteburger);
            menucb.Items.Add(doublekofteburger);*/


            Promosyon hardal = new Promosyon { adi = "hardal", ekfiyat = 1 };
            Promosyon ketcap = new Promosyon { adi = "ketcap", ekfiyat = 1 };
            Promosyon ranch = new Promosyon { adi = "ranch", ekfiyat = 1 };
            Promosyon acısos = new Promosyon { adi = "acısos", ekfiyat = 1 };
            Promosyon mayonez = new Promosyon { adi = "mayonez", ekfiyat = 1 };
            Promosyon bbq = new Promosyon { adi = "bbq", ekfiyat = 1 };
        }
        decimal tutar;
        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            hamburger h = (hamburger)menucb.SelectedItem;
            h.Malzemeler = new List<string>();
            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    h.Malzemeler.Add(ctrl.Text);
                    tutar = h.Tutar + 1;
                }
            }
            tutar = numericUpDown1.Value * h.Tutar;
            tutarlbl.Text = tutar.ToString();
            s = new Siparis();
            s.hamburgerler = h;
            s.adet = (int)numericUpDown1.Value;
        }
        Siparis s;
        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                siparislerlb.Items.Add(s);
            }


        }

        private void sTamamlaBtn_Click(object sender, EventArgs e)
        {
            decimal toplamtutar = 0;
            int sayac = 0;
            foreach (Siparis spr in siparislerlb.Items)
            {
                toplamtutar += spr.adet * spr.hamburgerler.Tutar;
                sayac++;
               
               
            } DialogResult cikis = new DialogResult();
            label3.Text = toplamtutar.ToString();
           cikis= MessageBox.Show(string.Format("Toplam sipariş adediniz {0} {1} toplam sipariş tutarınız {2} , Devam etmek istiyor musunuz? ",sayac, Environment.NewLine ,toplamtutar), "UYARI",MessageBoxButtons.YesNo);
            Form1 f = new Form1();
            if (cikis == DialogResult.Yes)
            {
                this.Hide();
                f.Show();
            }
            if (cikis == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerci
{
   public class Siparis
    {
       
        public hamburger hamburgerler { get; set; }
        public int adet { get; set; }
        public decimal toplamtutar { get; set; }

        public override string ToString()
        {
            string spr = "";
            //spr += hamburgerler.ebati.adi + "";
            spr += hamburgerler.adi + "";
           //spr += hamburgerler.promosyon.adi + "";
            foreach (string  malzemeler in hamburgerler.Malzemeler)
            {
                spr += string.Format("{0}," ,malzemeler);
            }
            spr = spr.Remove(spr.Length-1,1);
            spr += string.Format("{0} * {1}={2}",adet,hamburgerler.Tutar,adet*hamburgerler.Tutar);
            return spr;
        }
    }
}

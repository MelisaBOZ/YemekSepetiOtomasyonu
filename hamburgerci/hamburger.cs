using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerci
{
   public class hamburger
    {
        public string adi { get; set; }
        public decimal fiyat { get; set; }

        public Size ebati { get; set; }
        public string Malzeme { get; set; }
       
        public Promosyon promosyon { get; set; }
        public decimal Tutar
        {
            get
            {
                decimal tutar =0;
                //tutar = fiyat * (decimal)Size.carpan;
                tutar += 1*fiyat;
                return tutar;
            }

        }
        public override string ToString()
        {
            return adi;
        }
        public  List<string> Malzemeler { get; set; }
       
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerci
{
    public class Size
    {
        public string adi { get; set; }
        public double carpan { get; set; }

        public override string ToString()
        {
            return string.Format("{0}--{1}", adi, carpan);
        }
    }
}

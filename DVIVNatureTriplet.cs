using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVCalc
{
    public class DVIVNatureTriplet
    {
        public int DV { get; set; }
        public int IV { get; set; }
        public string? Nature { get; set; }

        public DVIVNatureTriplet(int DV, int IV, string Nature) 
        {
            this.DV = DV;
            this.IV = IV;
            this.Nature = Nature;
        }

    }
}

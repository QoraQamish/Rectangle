using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    public class Romb:Paralellogram
    {
        public Romb()
        {
            
        }
        // Rombning Mavjudligi:
        public override bool Mavjud()
        {
            if(a==b && b==c && c==d && d==a)
            {
                return base.Mavjud();
            }
            return false;
        }
        //Rombning Yuzasi:
        public override double Sum()
        {
            return base.Sum();  
        }
        // Rombning peremetri
        public override double Permetr()
        {
            return 4*a;
        }
    }
}

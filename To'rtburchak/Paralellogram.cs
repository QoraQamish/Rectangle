using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    public class Paralellogram:Tortburchak
    {
        public Paralellogram()
        {
           
        }
        //Paralellogramni yuzasi:
        public override double Sum()
        {
            return base.Sum();  
        }
        //Paralellogramni permetri:
        public override double Permetr()
        {
            return 2*(a+b);  
        }
        // Paralellogramni bo'lish sharti:
        public override bool Mavjud()
        {
            if (A.x - B.x==0 || C.x - D.x==0 || B.x - C.x==0 || D.x - A.x==0) { return false; }
            if ((A.y - B.y) / (A.x - B.x) == (C.y - D.y) / (C.x - D.x) &&
                (B.y - C.y) / (B.x - C.x) == (D.y - A.y) / (D.x - A.x) && a==c && b==d) return true;
            else return false;
        }
    }
}

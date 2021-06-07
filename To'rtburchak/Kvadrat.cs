using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    public class Kvadrat:Romb
    {
        public Kvadrat()
        {
            
        }
        // Kvadratni mavjudligi
        public override bool Mavjud()
        {
            if (A.x == B.x && B.y == C.y && C.x == D.x && D.y == A.y 
                && a==b && b==c && c==d) return true;
            else return false; 
        }
        // Kvadratni yuzasi:
        public override double Sum()
        {
            return a*a;  
        }
        // Kvadratni peremetri:
        public override double Permetr()
        {
            return 4 * a;
        }
    }
}

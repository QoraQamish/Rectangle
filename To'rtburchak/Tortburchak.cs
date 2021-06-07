using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    public class Data
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class Tortburchak
    {
        //To'rtburchakni nuqtalari
        public Data A{get;set;}
        public Data B{get;set;}
        public Data C{get;set;}
        public Data D { get; set; }
        //To'rtburchakning tamonlari
        public double a;
        public double b;
        public double c;
        public double d;
        // To'rtburchakning parmetri
        private double p;
        // To'rtburchakning yuzasi
        private double sum;
        public Tortburchak()
        {
        }     

        //To'rtburchakni tekshir
        public virtual bool Mavjud()
        {
            if(TortburchakTekshir(A,B,C) && 
                TortburchakTekshir(B,C,D) &&
                TortburchakTekshir(D,A,B))
            {
                return true;
            }
            return false;
        }
        private  bool TortburchakTekshir(Data A,Data B,Data C)
        {
            if ((A.x == B.x && B.x == C.x) || (A.y == B.y && B.y == C.y)) return false;
            else return true;
        }
        // To'rtburchak tamonlarni chiqarish
        public void PrintLine()
        {
            Console.WriteLine("Ushbu to'shakilni tamoni");
            Console.WriteLine("a:"+this.a);
            Console.WriteLine("b:"+this.b);
            Console.WriteLine("c:"+this.c);
            Console.WriteLine("d:"+this.d);
        }

        // To'rtburchakni tamoni topish
        public void Tamonlar()
        {
            this.a = Tamon(A.x, A.y, B.x, B.y);
            this.b = Tamon(B.x, B.y, C.x, C.y);
            this.c = Tamon(C.x, C.y, D.x, D.y);
            this.d = Tamon(D.x, D.y, A.x, A.y);
        }
        private double Tamon(int x1,int y1,int x2,int y2)
        {
            double s= Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return s;
        }
        // To'rtburchakni permetri
        public virtual double Permetr()
        {
            this.p = a + b + c + d;
            return p;
                 
        }
        //Qavariq to'rtburchakni yuzasi
        public virtual double Sum()
        {
            double diag = Tamon(A.x, A.y, C.x, C.y);
            double p1 = (a + b + diag)/2;
            double p2 = (c + d + diag)/2;
            this.sum = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - diag))
                + Math.Sqrt(p2 * (p2 - c) * (p2 - d) * (p2 - diag));
            return sum;
        }


    }
}

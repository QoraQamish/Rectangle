using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    public class Tortburchak
    {
        //To'rtburchakni nuqtalari
        private int ax { get; set; }
        private  int ay { get; set; }
        private  int bx{ get; set; }
        private  int by{ get; set; }
        private  int cx{ get; set; }
        private  int cy{ get; set; }
        private  int dx{ get; set; }
        private  int dy { get; set; }
        //To'rtburchakning tamonlari
        private double a;
        private double b;
        private double c;
        private double d;
        // To'rtburchakning parmetri
        private double p;
        // To'rtburchakning yuzasi
        private double sum;

        public void Kordinata(int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
        {
            this.ax = ax;
            this.ay = ay;
            this.bx = bx;
            this.by = by;
            this.cx = cx;
            this.cy = cy;
            this.dx = dx;
            this.dy = dy;
        }
        

        //To'rtburchakni tekshir
        public bool TortburchakTek()
        {
            a = Tamon(ax, ay, bx, by);
            b = Tamon(bx, by, cx, cy);
            c = Tamon(cx, cy, dx, dy);
            d = Tamon(dx, dy, ax, ay);
            double diag = Tamon(ax, ay, cx, cy);
            if(a+b>diag && diag+a>b && b+diag>a &&
                c + d > diag && diag + c > d && d + diag > c)
            {
                Console.WriteLine("To'rtburchak mavjud");
                PrintLine();
                Console.WriteLine("To'rtburchakni permetri "+ Permetr());
                Console.WriteLine( "To'rtburchakni yuzasi "+ Sum());
                return true;
            }
            return false;
        }
        // To'rtburchak tamonlarni chiqarish
        private void PrintLine()
        {
            Console.WriteLine("Ushbu to'rtburchakni tamoni");
            Console.WriteLine("a:"+this.a);
            Console.WriteLine("b:"+this.b);
            Console.WriteLine("c:"+this.c);
            Console.WriteLine("d:"+this.d);
        }

        // To'rtburchakni tamoni topish
        private double Tamon(int x1,int y1,int x2,int y2)
        {
            double s= Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return s;
        }
        // To'rtburchakni permetri
        public double Permetr()
        {
            this.p = a + b + c + d;
            return p;
                 
        }
        //Qavariq to'rtburchakni yuzasi
        public double Sum()
        {
            double diag = Tamon(ax, ay, cx, cy);
            double p1 = (a + b + diag)/2;
            double p2 = (c + d + diag)/2;
            this.sum = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - diag))
                + Math.Sqrt(p2 * (p2 - c) * (p2 - d) * (p2 - diag));
            return sum;
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_rtburchak
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To'rtburchakning kordinatalarni kirting");

            Console.WriteLine("ax:");
            int ax = int.Parse(Console.ReadLine());

            Console.WriteLine("ay:");
            int ay = int.Parse(Console.ReadLine());

            Console.WriteLine("bx:");
            int bx = int.Parse(Console.ReadLine());

            Console.WriteLine("by:");
            int by = int.Parse(Console.ReadLine());

            Console.WriteLine("cx:");
            int cx = int.Parse(Console.ReadLine());

            Console.WriteLine("cy:");
            int cy = int.Parse(Console.ReadLine());

            Console.WriteLine("dx:");
            int dx = int.Parse(Console.ReadLine());
            Console.WriteLine("dy:");
            int dy = int.Parse(Console.ReadLine());

            Tortburchak tortburchak = new Tortburchak();
            
            tortburchak.Kordinata(ax, ay, bx, by, cx, cy, dx, dy);

            if (!tortburchak.TortburchakTek())
            {
                Console.WriteLine("Bunday to'rtburchak yo'q");
            }
            Console.ReadKey();

        }
    }
}

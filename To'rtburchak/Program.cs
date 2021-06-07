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
            while (true)
            {

                Console.WriteLine("Qanday shakil kerak?");
                Console.WriteLine("n=1 To'rtburchak");
                Console.WriteLine("n=2 Paralellogram");
                Console.WriteLine("n=3 Romb");
                Console.WriteLine("n=4 Kvadrat");
                Console.Write("n=");
                int tur = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Shakilni kordinatalarni kirting");
                
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
                switch (tur)
                {
                    case 1:
                        {
                            // To'rtburchak
                            Tortburchak tortburchak = new Tortburchak();
                            tortburchak.A = new Data() { x = ax, y = ay };
                            tortburchak.B = new Data() { x = bx, y = by };
                            tortburchak.C = new Data() { x = cx, y = cy };
                            tortburchak.D = new Data() { x = dx, y = dy };
                            if (tortburchak.Mavjud())
                            {
                                Console.WriteLine("Tortburchak mavjud");
                                tortburchak.Tamonlar();
                                tortburchak.PrintLine();
                                Console.WriteLine("Peremeter p={0}", tortburchak.Permetr());
                                Console.WriteLine("Yuzasi s={0}", tortburchak.Sum());
                            }
                            else Console.WriteLine("Tortburchak mavjuda emas!");
                            break;
                        }
                        case 2:
                        {
                            //Paralellogram
                            Paralellogram paralellogram = new Paralellogram();
                            paralellogram.A = new Data() { x = ax, y = ay };
                            paralellogram.B = new Data() { x = bx, y = by };
                            paralellogram.C = new Data() { x = cx, y = cy };
                            paralellogram.D = new Data() { x = dx, y = dy };
                            paralellogram.Tamonlar();
                            if (paralellogram.Mavjud())
                            {
                                Console.WriteLine("Tamoni a={0}",paralellogram.a);
                                Console.WriteLine("Tamoni b={0}",paralellogram.b);
                                Console.WriteLine("Paralellogram mavjud");
                                Console.WriteLine("Perametri P={0}", paralellogram.Permetr());
                                Console.WriteLine("Yuzasi S={0}", paralellogram.Sum());
                            }
                            else Console.WriteLine("Paralellogram mavjuda emas!");
                            break;
                        }
                    case 3:
                        {
                            //Romb
                            Romb romb = new Romb();
                            romb.A = new Data() { x = ax, y = ay };
                            romb.B = new Data() { x = bx, y = by };
                            romb.C = new Data() { x = cx, y = cy };
                            romb.D = new Data() { x = dx, y = dy };
                            romb.Tamonlar();
                            if (romb.Mavjud())
                            {
                                Console.WriteLine("Tamoni a={0}",romb.a);
                                Console.WriteLine("Romb mavjud");
                                Console.WriteLine("Perametri P={0}", romb.Permetr());
                                Console.WriteLine("Yuzasi s={0}", romb.Sum());
                            }
                            else Console.WriteLine("Romb mavjuda emas!");
                            break;
                        }
                    case 4:
                        {
                            //Kvadrat
                            Kvadrat kvadrat = new Kvadrat();
                            kvadrat.A = new Data() { x = ax, y = ay };
                            kvadrat.B = new Data() { x = bx, y = by };
                            kvadrat.C = new Data() { x = cx, y = cy };
                            kvadrat.D = new Data() { x = dx, y = dy };
                            kvadrat.Tamonlar();
                            if (kvadrat.Mavjud())
                            {
                                Console.WriteLine("Tamoni a{0}",kvadrat.a);
                                Console.WriteLine("Kvadrat mavjud");
                                Console.WriteLine("Perametri P={0}", kvadrat.Permetr());
                                Console.WriteLine("Yuzasi S={0}", kvadrat.Sum());
                            }
                            else Console.WriteLine("Kvadrat mavjuda emas!");
                            break;
                        }
                    default:
                        Console.WriteLine("Belgilangan sonni kiritmadingiz");
                        break;
                }

               
            }

        }
    }
}

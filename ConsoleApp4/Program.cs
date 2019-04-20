using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPrice = 4;

            Meyve banan = new Meyve();
            banan.name = "banan";
            banan.price = 2;

            Meyve kivi = new Meyve();
            kivi.name = "kivi";
            kivi.price = 1;

            Meyve portagal = new Meyve();
            portagal.name = "portagal";
            portagal.price = 5;
            while(1==1)
            {
                string input = Console.ReadLine();
                if (input == "banan" && banan.price < currentPrice)
                {
                    Console.WriteLine("alina biler");
                }
                else if (input == "portagal")
                {
                    if (portagal.price > currentPrice)
                    {
                        Console.WriteLine("ala bilmezsen");

                    }
                    else
                    {
                        Console.WriteLine("ala bilersen");

                    }
                }
                else if (input == "kivi")
                {
                    if (kivi.price > currentPrice)
                    {
                        Console.WriteLine("ala bilmezsen");

                    }
                    else
                    {
                        Console.WriteLine("ala bilersen");

                    }
                }
                else
                {
                    Console.WriteLine("bele bir meyve yoxdur");
                }
            }
           
        }
    }
}

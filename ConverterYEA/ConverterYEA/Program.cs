using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterYEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the number of liters");
                int liters = 0;
                int.TryParse(Console.ReadLine(), out liters);

                Console.WriteLine("1) for fluid ounce\n2) for gills \n3) for pints\n4) for quarts\n5) for gallons\n6) for tablespoons\n7) for teaspoons\n8) for cups");
                int num = 0;
                int.TryParse(Console.ReadLine(), out num);
                /*if (num == 1)
                    Console.WriteLine(meters * 3.28084 + " feet");
                if (num == 2)
                    Console.WriteLine(meters * 1.09361 + " inches");
                Console.ReadLine();*/
                switch (num)
                {
                    case 1:
                        Console.WriteLine(liters * 33.814 + " fluid ounces");
                        break;
                    case 2:
                        Console.WriteLine(liters * 8.454 + " gills");
                        break;
                    case 3:
                        Console.WriteLine(liters * 2.113 + " pints");
                        break;
                    case 4:
                        Console.WriteLine(liters * 1.057 + " quarts");
                        break;
                    case 5:
                        Console.WriteLine(liters / 3.785 + " gallons");
                        break;
                    case 6:
                        Console.WriteLine(liters * 67.628 + " tablespoons");
                        break;
                    case 7:
                        Console.WriteLine(liters * 202.9 + " teaspoons");
                        break;
                    case 8:
                        Console.WriteLine(liters * 4.227 + " cups");
                        break;
                    default:
                        Console.WriteLine("Invalid Units");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

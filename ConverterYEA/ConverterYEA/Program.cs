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
            //for( int i = 0; i < 100; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine("Enter your number");
                int num = 0;
                int.TryParse(Console.ReadLine(), out num);
                Console.WriteLine(num * 2);
                Console.ReadLine();
            }
            //Console.ReadKey();
        }
    }
}

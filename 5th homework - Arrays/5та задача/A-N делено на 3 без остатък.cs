using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number, bigger than the first one: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Abort! The second number is smaller than the first one.");
            }

            else
            {
                Console.WriteLine("The numbers below are divided by 3 without a remainder");
                for (int i = a; a <= b; a++)
                {
                    if (a % 3 == 0)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
}
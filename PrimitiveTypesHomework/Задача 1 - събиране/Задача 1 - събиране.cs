using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1___събиране
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a number:");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter a second number:");

            int b = int.Parse(Console.ReadLine());

            Console.Write("The sum is:");
            Console.WriteLine(a + b);
        }
    }
}

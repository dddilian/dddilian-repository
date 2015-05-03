using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4___извеждане_на_остатък
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a number to be divided:");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number that will divide:");

            int b = int.Parse(Console.ReadLine());

            Console.Write("The remainder of the division is:");
            Console.WriteLine(a % b);
        }
    }
}

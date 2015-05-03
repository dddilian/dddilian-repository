using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___съединяване_на_два_стринга
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write a word:");
            string a = Console.ReadLine();

            Console.WriteLine("Please write a second word:");
            string b = Console.ReadLine();

            Console.WriteLine("Combined:");
            Console.WriteLine(a + " " + b);
        }
    }
}

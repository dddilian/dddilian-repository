using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___реално_число_да_се_дели_на_цяло_число
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter one real number to be divided by 5:");

            double a = double.Parse(Console.ReadLine());

            int b = 5;

            Console.WriteLine(a / b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___стринг_дали_се_съдържа_в_друг_стринг
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write a word:");
            string a = Console.ReadLine();

            Console.WriteLine("Please write a second word:");
            string b = Console.ReadLine();

            // проверено с grass за първи стринг и ass за втори


            if (a.Contains(b))
            {
                Console.WriteLine("The second word is contained in the first word");
            }

            else
            {
                Console.WriteLine("The second word is NOT contained in the first word");
            }
        }
    }
}

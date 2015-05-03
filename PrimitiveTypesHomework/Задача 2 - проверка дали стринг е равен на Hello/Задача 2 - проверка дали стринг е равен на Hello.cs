using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___проверка_дали_стринг_е_равен_на_Hello
{
    class Program
    {
        static void Main()
        {
            string a = "Hello";
            Console.WriteLine("The main word is \"Hello\"");

            Console.WriteLine("Now enter your word and note that the system recognizes capital letters:");
            string b = Console.ReadLine();

            bool sameAB = (a == b);

            if (a == b)
            {
                Console.WriteLine("Your word is the same as the main word");
            }

            else
            {
                Console.WriteLine("Your word is NOT the same as the main word");
            }
        }
    }
}

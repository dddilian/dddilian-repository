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
            
            int a = 30;
            int b = 1;

            Console.WriteLine("The numbers below are divided by 3 without a remainder");
            for (int i = a; a >= b; a--)
            {
                Console.WriteLine(a);
                
            }
        }
    }
}
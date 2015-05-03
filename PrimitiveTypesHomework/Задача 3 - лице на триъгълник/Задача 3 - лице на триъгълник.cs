using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3___лице_на_триъгълник
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for side \"A\":");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number for \"height\":");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the triangle is:");
            float area = (a * h) / 2f;
            Console.WriteLine(area);
        }
    }
}

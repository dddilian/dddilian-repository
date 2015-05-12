using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ра_задача
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            int length = 5;

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());


                min = Math.Min(min, number);


                max = Math.Max(max, number);


            }

            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);

        }
    }
}
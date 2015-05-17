using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4та_задача
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10] { 2, 1, 68, 5, 666, 6, 7, 8, 78, 166 };
            Console.WriteLine("The numbers, that the array contains, are: 2, 1, 68, 5, 666, 6, 7, 8, 78, 166");

            Console.WriteLine("Enter one of the numbers to see its index in the array:");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 2:
                case 1:
                case 68:
                case 5:
                case 666:
                case 6:
                case 7:
                case 8:
                case 78:
                case 166:
                    break;

                default:
                    Console.WriteLine("There is no such number in the array!");
                    break;
            }

            int index = Array.IndexOf(array, n);
            Console.WriteLine("The index is on position: {0}", index);
        }
    }
}

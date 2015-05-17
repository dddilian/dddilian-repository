using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ва_задача
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number for array's length");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int even = 0;


            Console.WriteLine("Enter numbers to fill the elements in the array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine("You chose these numbers to be the elements of your array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("This element is even: {0}", item);
                    even += item;
                }       
            }
            Console.WriteLine("The sum of all even elements is: {0}", even);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ра_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for array length:");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];

            
            Array[0] = 0; // определят се първите два елемента да са 0 и 1, 
            Array[1] = 1; // за да бъдат основа при пълненето на масива в определената последователност

            Console.WriteLine(Array[0]);
            Console.WriteLine(Array[1]);
            for (int i = 2; i < n; i++) //запълването на масива започва от 2рия индекс, т.е. 3ти елемент.
            {
                Array[i] = Array[i - 1] + Array[i - 2];
                
                Console.WriteLine(Array[i]);
            }
        }
    }
}


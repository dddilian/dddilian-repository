﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3та_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Еvery element multiplied by 10:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 10 * array[i];
             
                Console.Write(array[i] + " ");
            }
        }
    }
}

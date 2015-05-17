using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6та_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6]{
                { 1,  2,  3,  4,  5, 6},
                { 7,  8,  9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18},
                {19, 20, 21, 22, 23, 24},
                {25, 26, 27, 28, 29, 30},
            };


            Console.WriteLine(matrix.GetLength(0)); //връща дължината на първото измерение - в случая 5 реда
            Console.WriteLine(matrix.GetLength(1)); //връща дължината на второто измерение - в случая 6 колони
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)   // вместо matrix.GetLength(0) може да се сложи 5, за броя редовете
            {
                for (int col = 0; col < matrix.GetLength(1); col++)  // вместо matrix.GetLength(1) може да се сложи 6, за броя колоните
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
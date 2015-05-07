using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3та_задача
{
    class Cards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol, that represents a valid card:");
            string symbol = (Console.ReadLine());

            switch (symbol)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "j":
                case "q":
                case "k":
                case "a":
                    Console.WriteLine("You have entered a valid card.");
                    break;

                default:
                    Console.WriteLine("There is no such card!");
                    break;
            }
        }
    }
}
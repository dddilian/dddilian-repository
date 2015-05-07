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
            Console.WriteLine("Please enter the points you have won to see what is your bonus score:");

            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered points: {0}", points);

            if (points >= 1 && points <= 3)
            {
                int bonusScore = points * 5;
                Console.WriteLine("Your bonus score is:{0}", bonusScore);
            }

            else if (points >= 4 && points <= 6)
            {
                int bonusScore = points * 10;
                Console.WriteLine("Your bonus score is:{0}", bonusScore);
            }
            else if (points >= 7 && points <= 9)
            {
                int bonusScore = points * 50;
                Console.WriteLine("Your bonus score is:{0}", bonusScore);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
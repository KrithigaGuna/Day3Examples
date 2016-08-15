using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program8
    {
        public static void Main()
        {
            Console.WriteLine("Number Guessing Game.");
            int secretNumber = 7;

            bool continuePlaying = true;

            while (continuePlaying)
            {
                int number = Program7.ReadInteger();

                if (number == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine("Too bad. Better luck next time!");
                }

                if (number == secretNumber) //exit condition
                {
                    continuePlaying = false;
                }

            }

        }
    }
}

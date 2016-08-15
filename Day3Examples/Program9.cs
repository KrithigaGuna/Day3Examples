using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program9
    {
        public static void Main()
        {
            Console.WriteLine("Number Guessing Game.");

            Random r = new Random(); //don't worry this is in object oriented.
            double secretNumber = r.Next(1,11); //for double use r.NextDouble()

            bool canLoop = true;

            do {
                int number = Program7.ReadInteger();

                if (number == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine("Too bad. Better luck next time!");
                }

                if (number == secretNumber){
                    canLoop = false;
                }
            } while(canLoop);
        }
    }
}

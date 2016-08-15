using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program5
    {
        public static void Main()
        {
            Console.Write("Please enter a number (1-7): ");
            string input = Console.ReadLine();

            int dayInNumber = Convert.ToInt32(input);

            string dayName;

            switch (dayInNumber)
            {
                case 1:
                    dayName = "Monday";
                    Console.Write("");
                    Console.Write("");
                    Console.Write("");
                    break;
                case 2:
                    dayName = "Tueday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "**ERROR**";
                    break;
            }

            Console.WriteLine(dayName);

        }
    }
}

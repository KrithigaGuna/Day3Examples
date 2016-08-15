using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program4
    {
        public static void Main()
        {
            Console.Write("Please enter a number (1-7): ");
            string input = Console.ReadLine();

            int dayInNumber = Convert.ToInt32(input);

            string dayName = "";

            /*
            if (dayInNumber == 1) dayName = "Monday";
            if (dayInNumber == 2) dayName = "Tuesday";
            if (dayInNumber == 3) dayName = "Wednesday";
            if (dayInNumber == 4) dayName = "Thursday";
            if (dayInNumber == 5) dayName = "Friday";
            if (dayInNumber == 6) dayName = "Saturday";
            if (dayInNumber == 7) dayName = "Sunday";
            */

            /*
            if (dayInNumber == 1) dayName = "Monday";
            else if (dayInNumber == 2) dayName = "Tuesday";
            else if (dayInNumber == 3) dayName = "Wednesday";
            else if (dayInNumber == 4) dayName = "Thursday";
            else if (dayInNumber == 5) dayName = "Friday";
            else if (dayInNumber == 6) dayName = "Saturday";
            else if (dayInNumber == 7) dayName = "Sunday";
            */

            if (dayInNumber == 1)
            {
                dayName = "Monday";
            }
            else 
            {
                if (dayInNumber == 2)
                {
                    dayName = "Tuesday";
                }
                else
                {
                    if (dayInNumber == 3)
                    {
                        dayName = "Wednesday";
                    }
                    else
                    {
                        if (dayInNumber == 4)
                        {
                            dayName = "Thursday";
                        }
                        else
                        {
                            if (dayInNumber == 5)
                            {
                                dayName = "Friday";
                            }
                            else
                            {
                                if (dayInNumber == 6)
                                {
                                    dayName = "Saturday";
                                }
                                else
                                {
                                    if (dayInNumber == 7)
                                    {
                                        dayName = "Sunday";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(dayName);

        }
    }
}

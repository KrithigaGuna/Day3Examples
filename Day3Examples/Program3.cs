using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program3
    {
        public static void Main()
        {
            Console.Write("Enter the hour in 24-hour format: ");
            String input = Console.ReadLine();

            int hrIn24 = Convert.ToInt32(input);

            int hrIn12 = hrIn24 % 12;

            if (hrIn12 == 0){
                hrIn12 = 12;
            }

            string amPmIndicator = "";

            if (hrIn24 >= 12)
            {
                amPmIndicator = "PM";
                int x = 1;
                Console.WriteLine("I'm in the PM block {0} ",x );
            }
            else
            {
                amPmIndicator = "AM";
            }

            /*
            if (hrIn24 >= 12)
                amPmIndicator = "PM";
            else
                amPmIndicator = "AM";
                Console.WriteLine("I'm in the PM block {0} " );
            */

            Console.WriteLine("Hour in 12-hour format is: {0} {1}", hrIn12, amPmIndicator);


        }
    }
}

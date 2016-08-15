using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Day3Quiz
    {
        public static void Main()
        {
            Console.Write("Please enter the length in cm:");
            string input = Console.ReadLine();

            double cmLength = Convert.ToDouble(input);
            double inchLength = cmLength / 2.54;

            Console.WriteLine("{0:0.000}",inchLength);
        }
    }
}

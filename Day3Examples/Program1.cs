using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);

            double fare = CalculateFare(distance);
            Console.WriteLine(fare);
            Console.WriteLine(CalculateFare(3.3));

            //double temp = CalculateFare(3.3);
            //Console.WriteLine(temp);

            Console.WriteLine(Math.Pow(2.4 + 10.23 * 0.4,2));
        }

        public static double CalculateFare(double inputDistance)
        {
            double fare = 2.4 + inputDistance * 0.4;

            fare = fare * 10;
            fare = Math.Ceiling(fare);
            fare = fare / 10;

            return fare;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program6
    {
        public static void Main()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            //int number = Convert.ToInt32(input);

            int number;
            bool canParse = int.TryParse(input, out number);

            Console.WriteLine("Parsing status: {0}", canParse);
            Console.WriteLine("Parsed Number: {0}",number);
        }

    }
}

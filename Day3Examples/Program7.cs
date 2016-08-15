using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program7
    {
        public static void Main()
        {
            Console.WriteLine(ReadInteger());
        }

        public static int ReadInteger()
        {
            bool needToLoop = true;
            int number = 0;

            while (needToLoop)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                bool canParse = int.TryParse(input, out number);

                //Console.WriteLine("Parsing status: {0}", canParse);
                //Console.WriteLine("Parsed Number: {0}", number);

                if (canParse) //exit condition
                {
                    needToLoop = false;
                }
            }

            return number;
        }

        public static int ReadInteger2()
        {
            bool canParse = false;
            int number = 0;

            while (!canParse)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                canParse = int.TryParse(input, out number);
            }

            return number;
        }

    }
}

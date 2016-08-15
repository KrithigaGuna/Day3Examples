using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Examples
{
    class Program2
    {
        public static void Main()
        {
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 == 2);
            Console.WriteLine(1 > 2);

            bool b1 = 1 < 2;

            Console.WriteLine(b1);

            Console.WriteLine(IsEligibleForDiscount(6000, false, false));
        }

        public static bool IsEligibleForDiscount(double totalPurchase, bool isWeekend, bool isVIP)
        {
            bool eligibility = 
                (totalPurchase > 1000) || (isWeekend && (totalPurchase > 500)) || (isVIP);

            return eligibility;
        }
    }
}

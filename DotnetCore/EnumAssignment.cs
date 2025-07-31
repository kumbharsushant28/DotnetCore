using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore
{
    internal class EnumAssignment
    {
        public enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main()
        {
            Console.WriteLine("Enter a month number (1-12):");
            int monthNumber = int.Parse(Console.ReadLine());
            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                return;
            }
            Month month = (Month)(monthNumber - 1);
            Console.WriteLine($"The month is: {month}");
        }

    }
}

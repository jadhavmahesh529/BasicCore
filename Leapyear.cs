using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Leapyear
    {
       public void LeapyearNumber()
        {
            Console.Write("Enter a year: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (IsLeapYear(year))
                    Console.WriteLine($"{year} is a leap year.");
                else
                    Console.WriteLine($"{year} is not a leap year.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid 4-digit year.");
            }
        }

        static bool IsLeapYear(int year)
        {
           
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

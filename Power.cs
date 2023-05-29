using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Power
    {
        public Power()


        {
            Console.Write("Enter the power value (0 <= N < 31): ");
            if (int.TryParse(Console.ReadLine(), out int power) && power >= 0 && power < 31)
            {
                Console.WriteLine("Powers of 2:");
                for (int i = 0; i <= power; i++)
                {
                    int result = (int)Math.Pow(2, i);
                    Console.WriteLine($"2^{i} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid power value.");
            }
        }

        internal void PowerNumber()
        {
            throw new NotImplementedException();
        }
    }
}

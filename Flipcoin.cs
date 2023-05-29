using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Flipcoin
    {
        public void FlipcoinNumber()
        {
            Console.Write("Enter the number of times to flip the coin: ");
            if (int.TryParse(Console.ReadLine(), out int numFlips))
            {
                if (numFlips <= 0)
                {
                    Console.WriteLine("Number of flips should be a positive integer.");
                    return;
                }

                int heads = 0;
                int tails = 0;
                Random random = new Random();

                for (int i = 0; i < numFlips; i++)
                {
                    if (random.NextDouble() < 0.5)
                        heads++;
                    else
                        tails++;
                }

                double headsPercentage = (heads / (double)numFlips) * 100;
                double tailsPercentage = (tails / (double)numFlips) * 100;

                Console.WriteLine($"Percentage of Heads: {headsPercentage}%");
                Console.WriteLine($"Percentage of Tails: {tailsPercentage}%");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }
        }
    }


}
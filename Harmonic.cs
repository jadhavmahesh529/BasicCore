using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Harmonic
    {  
        public void HarmonicNumber() 
        {
           Console.Write("Enter the harmonic value (N): ");
             if (int.TryParse(Console.ReadLine(), out int N) && N != 0)
          {
            double harmonicNumber = 0;
            for (int i = 1; i <= N; i++)
            {
                harmonicNumber += 1.0 / i;
            }
             Console.WriteLine($"The {N}th harmonic number is: {harmonicNumber}");
              }
             else
           { 
               Console.WriteLine("Invalid input. Please enter a non-zero integer.");
           }
        }
    }
}

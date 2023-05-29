using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Factors
    {
        public void FactorsNumber()
        {
        Console.Write("Enter a number to find its prime factors: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
        {
            Console.WriteLine($"Prime factors of {number}:");
            ComputePrimeFactors(number);
    }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number greater than 1.");
        }
    }

    public void ComputePrimeFactors(int number)
{
    while (number % 2 == 0)
    {
        Console.WriteLine(2);
        number /= 2;
    }

    for (int i = 3; i * i <= number; i += 2)
    {
        while (number % i == 0)
        {
            Console.WriteLine(i);
            number /= i;
        }
    }

    if (number > 2)
    {
        Console.WriteLine(number);
    }
}
    }
}

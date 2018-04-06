/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_003
{
    class Program
    {
        static bool IsPrime(double Number)
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(Number)); ++i)
            {
                if (Number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            double Number, Largest_Factor;
            Number = 600851475143;
            Largest_Factor = 0;
            for (double i = 3; i < Math.Sqrt(Number); i += 2)
            {
                if (IsPrime(i) && Number % i == 0 && i > Largest_Factor) // if 'i' is prime and factor of 'Number' and bigger than the largest factor found last time.
                    Largest_Factor = i;
            }
            Console.WriteLine(Largest_Factor);
            Console.ReadKey();
            // Output: 6857
        }
    }
}

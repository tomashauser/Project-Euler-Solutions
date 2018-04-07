/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_010
{
    class Program
    {
        static bool IsPrime(double Number)
        {
            for (int i = 3; i <= Math.Ceiling(Math.Sqrt(Number)); i += 2)
            {
                if (Number % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            double Sum;
            Sum = 2; // Since 2 is the only even prime we add it to the 'Sum' and operate only with odd numbers.
            for (double i = 3; i <= 2000000; i += 2)
            {
                if (IsPrime(i))
                    Sum += i;
            }
            Console.Write(Sum);
            Console.ReadKey();
            // Output: 142913828922
        }
    }
}

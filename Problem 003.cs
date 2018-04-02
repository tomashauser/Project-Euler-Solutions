/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem003
{
    class Program
    {
        //==========================================================================
        // Since we need to find prime factors, we need a list of prime numbers,
        // which can be obtained either by generating them or by using libraries.
        //==========================================================================
        //                     METHOD GENERATING PRIME NUMBERS
        //==========================================================================
        static List<long> Primes_Array(long Upper_Bound)
        {
            List<long> Primes_Arr = new List<long>();
            Primes_Arr.Add(1);
            Primes_Arr.Add(2);
            int n = 3;
            while (n <= Upper_Bound)
            {
                for (int j = 3; j < n; j += 2)
                {
                    if (n % j == 0)
                    {
                        n += 2;
                        j = 3;
                    }
                }
                if (!(n > Upper_Bound))
                    Primes_Arr.Add(n);
                n += 2;
            }
            return Primes_Arr;
        }
        static void Main(string[] args)
        {
            List<long> Primes_Arr = new List<long>(); // Assign a list of prime numbers (it can be done in a different way, but the order must be correct - {1, 2, 3, 5...}).
            long Number = 600851475143, Prime_Factor = 0, Upper_Bound;
            int n = 1;
            //=====================================================================================================================================
            // We need to know, how many primes should we generate in order to not run out of them,
            // but on the other hand we don't want to generate unnecessary amount.
            // Solution to this is formula which gives us the smallest amount of primes needed to be generated to factor 'Number': sqrt('Number').
            //=====================================================================================================================================
            Upper_Bound = (long)Math.Sqrt(Number);
            Primes_Arr = Primes_Array(Upper_Bound);
            //========================================================================================================================================
            // How this method works?
            // Example:
            // 'Number' = 100
            // 100 % 2  = 0 ==> 100 / 2 = 50 ==> Prime_Factor = 2
            //  50 % 2  = 0 ==>  50 / 2 = 25 ==> Prime_Factor = 2
            //  25 % 2 != 0 ==> Try next prime.
            //  25 % 3 != 0 ==> Try next prime.
            //  25 % 4 != 0 ==> Try next prime.
            //  25 % 5  = 0 ==>  25 / 5 =  5 ==> Prime_Factor = 5
            //   5 % 5  = 0 ==>   5 / 5 =  1 ==> We can no longer divide 1. The highest Prime_Factor is obviously Prime_Factor, so thats our answer.
            //=========================================================================================================================================

            while (Number > 1) // Repeat until the 'Number' (which will be divided below) reaches '1'.
            {
                if (Number % Primes_Arr[n] == 0) // If the 'Number' is divisible by 'n-th' prime, divide it by 'n-th' prime and assign a 'Prime_Factor'.
                {
                    Prime_Factor = Primes_Arr[n];
                    Number /= Primes_Arr[n];
                }
                else // If the 'Number' isn't divisible by 'n-th' prime try next prime by incrementing 'n'.
                    n++;
            }
            Console.WriteLine(Prime_Factor);
            Console.ReadKey();
            // Output: 6857
        }
    }
}

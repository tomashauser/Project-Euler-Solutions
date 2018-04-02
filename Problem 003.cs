using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_003_b_
{
    class Program
    {
        //===================================================================================================================================================
        // Alternative approach to this is by calculating only current 'n-th' prime needed while incrementing 'n' to try another prime number.
        // We've used a formula for maximal prime needed (for the 'Upper_Bound') in order for program to work for every number.
        // so now we will approach this problem by calculating only next prime and not entire list of them, which contained unnecesary large primes.
        //===================================================================================================================================================
        static int Nth_Prime(int n, int Upper_Bound)
        {
            List<int> Primes_Arr = new List<int>();
            Primes_Arr.Add(1);
            Primes_Arr.Add(2);
            int i = 3;
            while (Primes_Arr.Count <= n)
            {
                for (int j = 3; j < Convert.ToInt32(Math.Sqrt(Convert.ToDouble(i))); j += 2)
                {
                    if (i % j == 0)
                    {
                        i += 2;
                        j = 3;
                    }
                }
                Primes_Arr.Add(i);
                i += 2;
            }
            return Primes_Arr[n];
        }
        static void Main(string[] args)
        {
            long Number = 600851475143, Prime_Factor = 0;
            int n = 1, Upper_Bound, Prime; // Set 'n' to '1' because it's a first prime.
            Upper_Bound = (int)Math.Sqrt(Number);
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
            //   5 % 5  = 0 ==>   5 / 5 =  1 ==> We can no longer divide 1. The highest prime factor is obviously 'Prime_Factor', so thats our answer.
            //=========================================================================================================================================
            while (Number > 1) // Repeat until the 'Number' (which will be divided below) reaches '1'.
            {
                Prime = Nth_Prime(n, Upper_Bound);  // Set computing of 'n-th' prime to variable 'Prime', so the program doesn't have to compute it twice,
                                                    // because it is used also in assigning 'Nth_Prime(n, Upper_Bound)' to 'Prime_Factor'.
                if (Number % Prime == 0)            // If the 'Number' is divisible by 'n-th' prime, divide it by 'n-th' prime and assign a 'Prime_Factor'.
                {
                    Prime_Factor = Prime;
                    Number /= Prime;
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

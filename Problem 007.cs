/*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static int Nth_Prime (int n)
        {
            int Number = 1, Prime = 0, Counter = -1;
            while (n != Counter)
            {
                for (int i = 2; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        Number++; i = 2;
                    }
                }
                Prime = Number;
                Number++;
                Counter++;
            }
            return Prime;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Nth_Prime(10001));
            Console.ReadKey();
            // Output: 104743
        }
    }
}

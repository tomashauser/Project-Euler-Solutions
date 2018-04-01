/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++) // Chceck first 1000 numbers starting with 1.
            {
                if (i % 3 == 0 || i % 5 == 0) Sum += i; // If the current number is divisible either by '3' or '5' add it to 'Sum'.
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
            // Output: 233168
        }
    }
}

/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Number = 2;
                for (int j = 2; j <= 20; j++)
                {
                    if (Number % j != 0)
                    {
                        Number++;
                        j = 2;
                    }                 
                }
            Console.WriteLine(Number);
            // Output: 232792560
        }
    }
}

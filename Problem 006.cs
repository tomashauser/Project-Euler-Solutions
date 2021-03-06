﻿/*
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_006
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum_Of_Squares = 0, Square_Of_Sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Sum_Of_Squares += i * i;
                Square_Of_Sum += i;
            }
            Console.WriteLine(Square_Of_Sum * Square_Of_Sum - Sum_Of_Squares);
            Console.ReadKey();
            // Output: 25164150
        }
    }
}

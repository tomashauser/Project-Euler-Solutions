/*
Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci sequence begins with adding "Final number" to the "Previous number" and by definition starts with '0' and '1'.
            // Variable 'a' is the "Previous number" and 'b' is the "Final number" in Fibonacci sequence.
            // Variable 'c' will represent final values (0, 1, 1, 2, 3, 5, 8, 13...).
            double a = -1, b = 1, c = 0, Sum = 0;
            while (c <= 4000000)
            {
                // 1. Add "final" number to the "previous" number to generate a next "final" number and assign it to 'c'.
                c = a + b;
                // 2. If 'c' is even, add it to the result variable 'Sum'.
                if (c % 2 == 0) Sum += c;
                // 3. Since the first step generates next "final" number and by definition we need to add a "final" number to the "previous" number,
                // expression (a = b) means that the current "previous" number becomes the "previous" number of the next number to be generated
                // and expression (b = c) means that the current "final" number becomes the "final" number of the next number to be generated.
                a = b;
                b = c; 
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
            // Output: 4613732
        }
    }
}

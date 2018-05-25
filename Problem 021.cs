/*
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_021 {
    class Program {
        static int d(int n) { // Sum of proper divisors.
            int Sum = 1; // No need to try 1 because it is always proper divisor.
            for (int i = 2; i < n; i++) {
                if (n % i == 0)
                    Sum += i;
            }
            return Sum;
        }
        static void Main(string[] args) {
            int Sum = 0, b;
            for (int a = 2; a <= 10000; a++) {
                b = d(a);
                if (d(b) == a && a != b)
                    Sum += a + b;
            }
            Console.WriteLine(Sum / 2); // Divide by 2 because program added also reversed pairs (220 & 284; 284 & 220).
            // Output: 31626
        }
    }
}

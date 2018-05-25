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
            // Output: 
        }
    }
}

/*
n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100!
*/
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_020 {
    class Program {
        static BigInteger Factorial(BigInteger Input) {
            if (Input <= 1)
                return 1;
            return Input * Factorial(Input - 1);
        }
        static void Main(string[] args) {
            string Number = Convert.ToString(Factorial(100));
            int Sum = 0;
            for (int i = 0; i < Number.Length; i++) {
                Sum += Convert.ToInt32(Number[i] - 48);
            }
            Console.WriteLine(Sum);
            // Output: 648
        }
    }
}

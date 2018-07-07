using System;
using System.Numerics;

namespace ConsoleApp74 {
    class Program {
        static void Main(string[] args) {
            BigInteger x = 0;
            BigInteger y = 1;
            BigInteger sum;
            int i = 0;
            for (i = 1; y.ToString().Length < 1000; i++) {
                sum = y + x;
                x = y;
                y = sum;
            }
            Console.WriteLine(i);
        }
    }
}

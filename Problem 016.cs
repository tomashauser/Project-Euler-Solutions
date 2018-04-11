/*
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // Add Numerics reference.

namespace Problem_016
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringNumber;
            int Sum_Of_Digits;
            BigInteger Number;
            Number = BigInteger.Pow(2, 1000);
            Sum_Of_Digits = 0;
            StringNumber = Convert.ToString(Number);
            for (int i = 0; i < StringNumber.Length; i++)
            {
                Sum_Of_Digits += Convert.ToInt32(StringNumber[i] - 48);
            }
            Console.WriteLine(Sum_Of_Digits);
        }
    }
}

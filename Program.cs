/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_004
{
    class Program
    {
        static bool Is_Palindrome(int Product) // Chceck if the 'Product' (i * j) is Palindromic.
        {
             IEnumerable<char> forwards = Product.ToString().ToCharArray(); // Convert 'Product' to the string of characters.
             return forwards.SequenceEqual(forwards.Reverse()); // Compare it to reverse string of characters.
        }
        static void Main(string[] args)
        {
            int Largest_Palindrome, N_Digit_Number;
            double Digits;
            Digits = 3; // For the code to be easily editable, let's implement 'Digits' variable, which for our problem is set to 3.
            Largest_Palindrome = 0;
            N_Digit_Number = (Int32)(Math.Pow(10, Digits)); // If digits = 3 => 10 ^ (3) = 1000.
            for (int i = 2; i < N_Digit_Number; i++) // These two for loops will try every possible combination of products of two 3 digit numbers up to 999.
            {                                        // (First try 'Is_Palindrome' for the product of constant 'i' while changing 'j', then try another 'i' incremented by 1.)
                for (int j = 2; j < N_Digit_Number; j++)
                {
                    if (Is_Palindrome(i * j))
                        Largest_Palindrome = i * j; // Largest Palindrome will also be the last and biggest palindrome after these loops will end.
                }
            }
            Console.WriteLine(Largest_Palindrome);
            Console.ReadKey();
        }
    }
}

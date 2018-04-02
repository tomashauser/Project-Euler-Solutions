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
        static bool Is_Palindrome(int Product)                              // Chceck if the 'Product' (i * j) is Palindromic.
        {
             IEnumerable<char> forwards = Product.ToString().ToCharArray(); // Convert 'Product' to the string of characters.
             return forwards.SequenceEqual(forwards.Reverse());             // Compare it to reverse string of characters.
        }
        static void Main(string[] args)
        {
            int Largest_Palindrome, Number_Of_Digits, Product;
            Number_Of_Digits = 3;                                                     // For the code to be easily editable, let's implement 'Digits' variable, which for our problem is set to 3.
            Number_Of_Digits = (int)Math.Pow(10, Convert.ToDouble(Number_Of_Digits)); // If digits = 3 => 10 ^ (3) = 1000.
            Largest_Palindrome = 0;
            for (int i = 100; i < Number_Of_Digits; i++)     // These two for loops will try every possible combination of products of two 3 digit numbers up to 999.
            {                                                // (First try 'Is_Palindrome' for the product of constant 'i' while changing 'j', then try another 'i' incremented by 1.)
                for (int j = 100; j < Number_Of_Digits; j++) // 'i' and 'j' don't start as '1', because we know that the 'Largest_Palindrome' will be bigger than 100 * 100.
                {
                    Product = i * j;
                    if (Is_Palindrome(Product) && Product > Largest_Palindrome) // Checking if the number is bigger than the last 'Largest_Palindrome'.
                        Largest_Palindrome = Product;
                }
            }
            Console.WriteLine(Largest_Palindrome);
            Console.ReadKey();
            // Output: 906609
        }
    }
}

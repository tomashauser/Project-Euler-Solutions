/* A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

 a2 + b2 = c2
 For example, 32 + 42 = 9 + 16 = 25 = 52.


 There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
(06.04.2018)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_009
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, Parameter;
            Parameter = 1000;
            void Compute() // It's put in void because we need to jump from two loops at the same time when our triplet is found.
            {
                for (double a = 2; a < 1000; a++) // Try all combinations up to 1000 to find the requiered triplet.
                {
                    for (double b = 3; b < 1000; b++) // a < b < c
                    {
                        c = Math.Sqrt(a * a + b * b);
                        if (c == (int)c && a + b + c == Parameter) // If 'c' is an integer and a + b + c equals to 1000.
                        {
                            Console.WriteLine(a + "*" + b + "*" + c + "=" + a * b * c);
                            return;
                        }
                    }
                }
            }
            Compute();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static int Nth_Prime (int n)
        {
            int Number = 1, Prime = 0, Counter = -1;
            while (n != Counter)
            {
                for (int i = 2; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        Number++; i = 2;
                    }
                }
                Prime = Number;
                Number++;
                Counter++;
            }
            return Prime;
        }
        static void Main(string[] args)
        {
                Console.WriteLine(Nth_Prime(10001));
            // Output: 104743
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++) // Chceck first 1000 numbers.
            {
                if (i % 3 == 0 || i % 5 == 0) Sum += i; // If the current numbers is divisible either by '3' or by '5' add it to 'Sum'.
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}

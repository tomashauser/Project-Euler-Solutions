using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_012
{
    class Program
    {
        static double Nth_Triangular(double n)
        {
            double Number = 0, Counter = 0, Index = 1;
            while (n != Counter)
            {
                Number = Number + Index;
                Index++; Counter++;
            }
            return Number;
        }
        static double Nth_Prime(double n)
        {
            n--;
            double Number = 1, Prime = 0, Counter = -1;
            while (n != Counter)
            {
                for (double i = 2; i < Number; i++)
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
            Stopwatch stopwatch = Stopwatch.StartNew();
            double Number, Prime, Index;
            int Divisors;
            Divisors = 0;
            Number = 0;
            for (double i = 1; i < 10000000; i++)
            {
                Number = Nth_Triangular(i);
                for (double j = 1; j <= Number; j++)
                {
                    if (Number % j == 0) Divisors++;
                }
                if (Divisors > 500) break;
                Divisors = 0;
            }
            System.Threading.Thread.Sleep(1);
            stopwatch.Stop();
            Console.WriteLine(Number);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}

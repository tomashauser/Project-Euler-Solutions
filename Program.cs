using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Collatz_Steps(double Number)
        {
            int Counter;
            Counter = 0;
            while (Number > 1)
            {
                if (Number % 2 == 0)
                {
                    Number /= 2;
                    Counter++;
                }
                else
                {
                    Number = 1.5 * Number + 0.5;
                    Counter += 2;
                }
            }
            return Counter;
        }
        static void Main(string[] args)
        {
            double Upper_Bound, Biggest_Amount, Steps, Answer;
            Upper_Bound = 1000000;
            Biggest_Amount = 0;
            Answer = 0;
            for (int Index = 2; Index <= Upper_Bound; Index++)
            {
                Steps = Collatz_Steps(Index);
                if (Steps > Biggest_Amount)
                {
                    Biggest_Amount = Steps;
                    Answer = Index;
                }
            }
            Console.WriteLine(Answer);
        }
    }
}
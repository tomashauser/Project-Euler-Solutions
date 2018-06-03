using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_023 {
    class Program {
        static List<int> Get_List_Of_Proper_Divisors(int x) {
            List<int> List_Of_Proper_Divisors = new List<int>();
            for (int i = 2; i < x; i++) {
                if (x % i == 0)
                    List_Of_Proper_Divisors.Add(i);
            }
            return List_Of_Proper_Divisors;
        }
        static List<int> Get_List_Of_Abundant_Numbers(int Upper_Limit) {
            List<int> List_Of_Abundant_Numbers = new List<int>();
            for (int i = 12; i <= Upper_Limit; i++) {
                if (Is_Abundant(i))
                    List_Of_Abundant_Numbers.Add(i);
            }
            return List_Of_Abundant_Numbers;
        }
        static bool Is_Abundant(int x) {
            List<int> List_Of_Proper_Divisors = new List<int>();
            List_Of_Proper_Divisors = Get_List_Of_Proper_Divisors(x);
            int Sum = 0;
            for (int i = 0; i < List_Of_Proper_Divisors.Count(); i++) {
                Sum += List_Of_Proper_Divisors[i];
            }
            if (Sum > x)
                return true;
            return false;
        }
        static bool Can_Be_Written_As_A_Sum_Of_Two_Abundant_Numbers(int x, List<int> List_Of_Abundant_Numbers) {
            int Lower_Limit = 0;
            for (int i = 0; i < List_Of_Abundant_Numbers.Count(); i++) { // Finding which index corresponds to number, which is lower than x.
                if (x > List_Of_Abundant_Numbers[i]) {
                    Lower_Limit = i - 1;
                }
            }
            // Find out which sums can be done up to this index.
            for (int i = 0; i <= Lower_Limit; i++) {
                for (int j = 0; j <= Lower_Limit; j++) {
                    if (List_Of_Abundant_Numbers[i] + List_Of_Abundant_Numbers[j] == x)
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args) {
            int Upper_Limit = 28123, Sum = 0;
            List<int> List_Of_Abundant_Numbers = new List<int>();
            List_Of_Abundant_Numbers = Get_List_Of_Abundant_Numbers(Upper_Limit);
            for (int i = 1; i < Upper_Limit; i++) {
                if (!Can_Be_Written_As_A_Sum_Of_Two_Abundant_Numbers(i, List_Of_Abundant_Numbers))
                    Sum += i;
            }
            Console.WriteLine(Sum);
        }
    }
}

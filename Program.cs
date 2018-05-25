/*
 You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_019 {
    class Program {
        static bool Is_First(int Current_Day, int Current_Year) {
            int[] First_Days_In_Year =      { 1, 32, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 }; // If sunday falls on one of this numbers, it is "sunday 1st".
            int[] First_Days_In_Leap_Year = { 1, 32, 61, 92, 122, 153, 183, 214, 245, 275, 306, 336 };
            if (Current_Year % 4 == 0 || Current_Year == 2000) {
                if (First_Days_In_Leap_Year.Contains(Current_Day)) return true;
                }
            else {
                if (First_Days_In_Year.Contains(Current_Day)) return true;
            }
            return false;
        }
        static void Main(string[] args) {
            int Current_Day = 6; // First Sunday of year 1901 is 6th.
            int Current_Year = 1901;
            int Number_Of_Sundays_First = 0;
            while(Current_Year <= 2000) {
                Current_Day += 7;
                if (Current_Day >= 365) {
                    Current_Day = Current_Day - 365 - 7;
                    Current_Year++;
                }
                if (Is_First(Current_Day, Current_Year)) Number_Of_Sundays_First++;
            }
            Console.WriteLine(Number_Of_Sundays_First);
            // Output: 171
        }
    }
}

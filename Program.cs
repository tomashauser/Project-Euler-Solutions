using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_000018 {
    class Program {
        static void Main(string[] args) {
            int[][] Pyramid = new int[15][];
            Pyramid[00] = new int[]                            { 75 };
            Pyramid[01] = new int[]                          { 95, 64 };
            Pyramid[02] = new int[]                        { 17, 47, 82 };
            Pyramid[03] = new int[]                      { 18, 35, 87, 10 };
            Pyramid[04] = new int[]                    { 20, 04, 82, 47, 65 };
            Pyramid[05] = new int[]                  { 19, 01, 23, 75, 03, 34 };
            Pyramid[06] = new int[]                { 88, 02, 77, 73, 07, 63, 67 };
            Pyramid[07] = new int[]               { 99, 65, 04, 28, 06, 16, 70, 92 };
            Pyramid[08] = new int[]             { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            Pyramid[09] = new int[]           { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            Pyramid[10] = new int[]         { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            Pyramid[11] = new int[]       { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            Pyramid[12] = new int[]     { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            Pyramid[13] = new int[]   { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            Pyramid[14] = new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };

            for (int i = Pyramid.Length - 2; i >= 0; i--) {
                for (int j = 0; j < Pyramid[i].Length; j++)
                    Pyramid[i][j] += Math.Max(Pyramid[i + 1][j], Pyramid[i + 1][j + 1]);
            }
            Console.WriteLine(Pyramid[0][0]);
        }
    }
}

/* This code needs serious update...*/
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56 {
    class Program {
        static int Count(int x, int[] Arr) {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++) {
                if (Arr[i] == x) Sum++;
            }
            return Sum;
        }
        static void Main(string[] args) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int Counter = 0;
            int[] Arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < Arr.Length; i++) {
                for (int j = 0; j < Arr.Length; j++) {
                    for (int k = 0; k < Arr.Length; k++) {
                        for (int l = 0; l < Arr.Length; l++) {
                            for (int m = 0; m < Arr.Length; m++) {
                                for (int n = 0; n < Arr.Length; n++) {
                                    for (int o = 0; o < Arr.Length; o++) {
                                        for (int p = 0; p < Arr.Length; p++) {
                                            for (int q = 0; q < Arr.Length; q++) {
                                                for (int r = 0; r < Arr.Length; r++) {
                                                    int[] Arr0 = { i, j, k, l, m, n, o, p, q, r };
                                                    if (Count(i, Arr0) > 1 || Count(j, Arr0) > 1 || Count(k, Arr0) > 1 || Count(l, Arr0) > 1 || Count(m, Arr0) > 1 || Count(n, Arr0) > 1 || Count(o, Arr0) > 1 || Count(p, Arr0) > 1 || Count(q, Arr0) > 1 || Count(r, Arr0) > 1)
                                                        continue;
                                                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Arr[i], Arr[j], Arr[k], Arr[l], Arr[m], Arr[n], Arr[o], Arr[p], Arr[q], Arr[r]);
                                                    Counter++;
                                                    if (Counter == 1000000) {
                                                        Console.WriteLine("<===============>");
                                                        watch.Stop();
                                                        Console.WriteLine(watch.ElapsedMilliseconds + "ms");
                                                        goto end;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            end:;
        }
    }
}

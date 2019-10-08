// Перевірити істинність вислову: "Квадратне рівняння
// A·x2 + B·x + C = 0
// із даними коефіцієнтами A, B, C має дійсні корені".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N;
            N = Convert.toInt32(Console.ReadLine());
            int[] a = new int[N];
            for(int i = 0; i < N;i++)
                a[i] = Convert.toInt32(Console.ReadLine());

            for(int i = N-1;i>=0;i--)
                Console.WriteLine(a[i]);
        }
    }
}
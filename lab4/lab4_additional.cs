// Перевірити істинність вислову: "Квадратне рівняння
//25
// Даний масив цілих чисел розміру N. 
// Перетворити масив, збільшивши (зменшивши) кожну його серію на один елемент. 
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
            int N = 7;
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            for(int i = 0;i < N;i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i < N;i++)
                a[i] += 1;
            for(int i = 0;i < N;i++)
                Console.Write(a[i] + ",");
        }
    }
}
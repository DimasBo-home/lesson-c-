/******************************************************************************
1. Дано число k (0 < k < max(m, n)) і матриця розміру m * n. Знайти
суму і добуток елементів к-го стовпчика даної матриці.
*******************************************************************************/
using System;
class Program {
  static void Main() {
    int k, m, n, max, sum;
    
    Console.Write("n = ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("m = ");
    m = Convert.ToInt32(Console.ReadLine());
    
    if(n>m)
        max = n;
    else
        max = m;
    
    Random random = new Random();
    int[,] a = new int[n,m];
    
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            a[i,j] = random.Next(0, 100);
            Console.Write(a[i,j]+",");
        }
        Console.WriteLine();
    } 
    Console.WriteLine("Суму якого стовпчика рядку Знайти");
    do{
        Console.Write("k = ");
        k = Convert.ToInt32(Console.ReadLine());
        if(k < 0 || k > max)
            Console.WriteLine("invalide value. ( k = (0 < k < max(m, n) )");
    }while(k < 0 || k > max);
    
    sum = 0;
    for(int i=0;i<m;i++)
        sum += a[k,i];
    Console.WriteLine("Sum k рядка " + sum);

  }
}
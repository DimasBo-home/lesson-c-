//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
  public class Program
  {
      //завдання 1
    public static void FirstExtend (int t)
    {
      string test = t.ToString ();
        SecondExtend (test);
    }

      //завдання 2
    //reverse string method
    public static void SecondExtend (string test)
    {
      for (int i = test.Length - 1; i >= 0; i--)
	Console.Write (test[i]);
    }

      //завдання 3
    public static void ThirdExtend (double number)
    {
        SecondExtend(Convert.ToString(Convert.ToInt32(number)));
        Console.Write(".");
        SecondExtend((number % 1).ToString().Substring(2));
    }

      //завдання 4
    public static void FourthExtend (string number, char sumvol) {
      string[] a = number.ToString ().Split (sumvol);
      for (int i = 0; i < a.Length - 1; i++)
    	{
    	  SecondExtend (a[i]);
    	  Console.Write (sumvol);
    	}
      SecondExtend (a[a.Length - 1]);
    }


      //завдання 5
    public static void FivethExtend (int t)
    {
        string test = t.ToString ();
        SecondExtend (test);
    }
    
    public static void FivethExtend (string test)
    {
        for (int i = test.Length - 1; i >= 0; i--)
	    Console.Write (test[i]);
    }

    public static void FivethExtend (double number)
    {
        SecondExtend(Convert.ToString(Convert.ToInt32(number)));
        Console.Write(".");
        SecondExtend((number % 1).ToString().Substring(2));
    }

    public static void FivethExtend(string number, char sumvol) {
      string[] a = number.ToString ().Split (sumvol);
      for (int i = 0; i < a.Length - 1; i++)
    	{
    	  SecondExtend (a[i]);
    	  Console.Write (sumvol);
    	}
      SecondExtend (a[a.Length - 1]);
    }
      //завдання 7
    public static int[] SeventhExtend (int[]a)
    {
      int[] new_a = new int[a.Length];
      int j = 0;
      for (int i = a.Length - 1; i >= 0; i--)
	{
	  new_a[j] = a[i];
	  j++;
	}
      return new_a;
    }

      //завдання 7
    public static void eighthExtend (ref int[] a, out int[] new_a )
    {
      new_a = new int[a.Length];
      int j = 0;
      for (int i = a.Length - 1; i >= 0; i--)
    	{
    	  new_a[j] = a[i];
    	  j++;
    	}
    }

    public static void Main (string[]args)
    {
      //1
      Console.Write ("1)");
      int first = 1234;
      Console.Write (first + "->");
      FirstExtend (first);
      Console.WriteLine ();
      //2
      Console.Write ("2)");
      string second = "aDVS";
      Console.Write (second + "->");
      SecondExtend (second);
      Console.WriteLine ();
      //3
      Console.Write ("3)");
      double third = 15.35;
      Console.Write (third + "->");
      ThirdExtend (third);
      Console.WriteLine();
      //4
      Console.Write ("4)");
      string fourth = "qwerty,uiop,[]";
      char sumvol = ',';
      Console.Write (fourth + "->");
      FourthExtend(fourth,sumvol);
      Console.WriteLine();
      //5
      Console.Write ("5.1)");
      Console.Write (first + "->");
      FivethExtend(first);
      Console.WriteLine();
      
      Console.Write ("5.2)");
      Console.Write (second + "->");
      FivethExtend(second);
      Console.WriteLine();
      
      Console.Write ("5.3)");
      Console.Write (third + "->");
      FivethExtend(third);
      Console.WriteLine();
            
      Console.Write ("5.4)");
      Console.Write (fourth + "->");
      FivethExtend(fourth, sumvol);
        Console.WriteLine();
      // 6 Ще не опанував рекурсию
        //7
      Console.Write ("7)");
        int[] a = {0, 2, 3, 4, 5}; 
        int[] new_a = SeventhExtend(a);

        foreach(int el in a)
            Console.Write("{0},",el);
        Console.Write ("->");
        foreach(int el in new_a)
            Console.Write("{0},",el);
        Console.WriteLine();
      //8 не докінця зрозумів навіщо там
      Console.Write("8)");
        foreach(int el in a)
            Console.Write("{0},",el);
        Console.Write ("->");
      int[] eighth;
      eighthExtend(ref a, out eighth);
        foreach(int el in eighth)
            Console.Write("{0},",el);
    }
  }
}

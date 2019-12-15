// Загальна частина:
// Створити методи розширення на основі методів із Лабораторної роботи 6.
// Для типу int (пункт 1 лаб.6), string (пункт 2, 4 лаб.6), double (пункт 3 лаб.6), int[] (пункт 7 лаб.6).

// Згідно з номером в списку:
// 1.Створити розширяючий метод для масиву цілих чисел, який сортує елементи масиву по зростанню.

using System;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Extension methods ~~~");

            Console.WriteLine("\nReversing int");
            int num = 123456789;
            Console.WriteLine(num);
            num.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nReversing string");
            string str = "Hello, World!";
            Console.WriteLine(str);
            str.Reverse();
            Console.WriteLine();

            Console.WriteLine("\nReversing double");
            double dNum = 123.567;
            Console.WriteLine(dNum);
            dNum.Reverse();
            Console.WriteLine();

            //reverse array
            Console.WriteLine("\nReversing int array");
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            arr.Reverse();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //sort
            Console.WriteLine("\nReplacing");
            int[] negArr = { 1, 2, -5, 10, -77, 0, 99 };

            negArr.Sort();
            
            for (int i = 0; i < negArr.Length; i++)
            {
                Console.Write(negArr[i] + " ");
            }
            Console.WriteLine();


        }
    }

    public static class IntExtensionMethods
    {
            //reverse string method
        //for int
        public static void Reverse(this int num)
        {
            string str = num.ToString ();
            str.Reverse();
        }
        //for string
        public static void Reverse (this string str)
        {
            char[] strArr = str.ToCharArray();
            for (int i = strArr.Length - 1; i >= 0; i--)
        	   Console.Write(strArr[i]);
        }
        //for double
        public static void Reverse(this double dNum)
        {
            string[] a = dNum.ToString().Split ('.');
            a[0].ToString().Reverse();
            Console.Write(".");
            a[1].ToString().Reverse();
        }
        //for int array
        public static void Reverse(this int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;

                left++;
                right--;
            }
        }
        
        public static void Sort(this int[] array){
            for(int i=0;i<array.Length;i++){
                for(int j=0;j<array.Length;j++){
                    if(array[j]>array[i]){
                        int m = array[i];
                        array[i] = array[j];
                        array[j] = m;
                    }
                }
            }
        }
        public static void Sort(this double[] array){
            for(int i=0;i<array.Length;i++){
                for(int j=0;j<array.Length;j++){
                    if(array[j]>array[i]){
                        double m = array[i];
                        array[i] = array[j];
                        array[j] = m;
                    }
                }
            }
        }
        public static void Sort(this float[] array){
            for(int i=0;i<array.Length;i++){
                for(int j=0;j<array.Length;j++){
                    if(array[j]>array[i]){
                        float m = array[i];
                        array[i] = array[j];
                        array[j] = m;
                    }
                }
            }
        }
    }

}

/******************************************************************************
1.Створити ліст об’єктів, дозволити можливість заповнення з клавіатури і
вивести кількість об’єктів кожного типу(Char, String, Int, Doble, Bool).
*******************************************************************************/
using System;
using System.Collections.Generic;

class HelloWorld {
    static void Show(List<object> list){
        for(int i=0;i<list.Count;i++)
            Console.Write(list[i]+" ");
        Console.WriteLine();
    }
    
    static void Main() {
        List<object> list = new List<object>();
        
        int k;
        do{
            Console.WriteLine("add press 1)int, 2)String,3)char,4)Doble,5)Bool or press 0 exit");
            k = Convert.ToInt32(Console.ReadLine());
            switch(k){
                case 1:
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                    Show(list);
                    break;
                case 2:
                    list.Add(Convert.ToString(Console.ReadLine()));
                    Show(list);
                    break;
                case 3:
                    list.Add(Convert.ToChar(Console.ReadLine()));
                    Show(list);
                    break;
                case 4:
                    list.Add(Convert.ToDouble(Console.ReadLine()));
                    Show(list);
                    break;
                case 5:
                    list.Add(Convert.ToBoolean(Console.ReadLine()));
                    Show(list);
                    break;
                case(0):
                    break;
                default:
                    Console.WriteLine("invalide value.");
                    break;
            }
        }while(k!=0);
        
        int[] shotchik = new int[5];
        for(int i=0;i<list.Count;i++){
            if(list[i] is int)
                shotchik[0] += 1;
            else if(list[i] is string)
                shotchik[1] += 1;
            else if(list[i] is char)
                shotchik[2] += 1;
            else if(list[i] is double)
                shotchik[3] += 1;
            else if(list[i] is bool)
                shotchik[4] += 1;
        }
        
        Show(list);
        Console.WriteLine("int " + shotchik[0]);
        Console.WriteLine("string " + shotchik[1]);
        Console.WriteLine("char " + shotchik[2]);
        Console.WriteLine("double " + shotchik[3]);
        Console.WriteLine("bool " + shotchik[4]);
    }
}
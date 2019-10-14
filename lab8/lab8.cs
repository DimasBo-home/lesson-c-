/******************************************************************************
1. Створити клас, який буде уособлювати Гараж Шейха. 

Створити клас, який буде уособлювати Автомобіль. 

В Гаражі зберігається необмежена кількість Автомобілів. 
Шейх може купити новий Автомобіль в Гараж, чи викинути існуючий. 
Також Шейх може взяти машину покататися за певними критеріями: за ім’ям машини, 
кольором, швидкістю, року випуску (за всіма параметрами, або частково). 
Після введення параметру на екран виводяться всі Автомобілі з Гаражу Шейха, 
які підходять за цими параметрами

*******************************************************************************/
using System;
using System.Collections.Generic; 

class Program {
  static void Main() {
        Garash Sheiha = new Garash();
        Car bmw = new Car(){name="bmw",color= "red",speed=170,year = 2019};
        Car jimny = new Car(){name="Tesla",color="red",speed=150,year=2017};
        
        Sheiha.cars.Add(bmw);
        Sheiha.cars.Add(jimny);
        Sheiha.Using();
  }
}

public class Garash{
    public List<Car> cars = new List<Car>();
    
    public void ShowCars(List<Car> cars = null){
        if(cars==null){
            cars = this.cars;
            for (int i = 0;i < cars.Count;i++){
                Console.WriteLine("------------ Парковачне місце :" + (i+1) + "-----------------");
                cars[i].Infa();
            }
        }else{
            for (int i = 0;i < cars.Count;i++)
                cars[i].Infa();
        }
    }

    public void DeleteCar(){
        Console.WriteLine("Яку автівку Видалити.");
        int k;
        do{
            Console.WriteLine("Парковачне місце: ");
            k = Convert.ToInt32(Console.ReadLine());
            if(0 >=  k || k > this.cars.Count)
                Console.WriteLine("Invalide value.");
        }while(0 >=  k || k > this.cars.Count);
        this.cars.RemoveAt(k-1);
    }
    
    public void BuyCar(){
        Console.WriteLine("Яку автівку купуєм");
        
        Console.Write("Назва = ");
        string name = Console.ReadLine();
        Console.Write("Колір = ");
        string color = Console.ReadLine();
        Console.Write("Швидкість = ");
        int speed = Convert.ToInt32(Console.ReadLine());
        Console.Write("Рік випуску = ");
        int year = Convert.ToInt32(Console.ReadLine());
        Car new_car = new Car()
        {
            name=name,
            color=color,
            speed=speed,
            year=year,
        };
        this.cars.Add(new_car);
    }
 
    // public List<Car> Drive()
    // {
    //     Console.WriteLine("На якій машині будете кататись. Оберіть Машину!");
    //     Console("Оберайте за критеріями назва");
    // }
    public void Using(){
        Console.WriteLine("--------------- Гараж Шейха -------------");
        this.ShowCars();
        int k = 0;
        Console.WriteLine("---------- Інтерфейс ----------");
        Console.WriteLine("Купити автівку, натисніть 1)");
        Console.WriteLine("Продати автівку, натисніть 2)");
        Console.WriteLine("Покататись на автівці, натисніть 3)");
        Console.WriteLine("Вихід 0)");
        do{
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 3)
                Console.WriteLine("Дій ще в розробці;");
            else if(k<0 || k > 2)
                Console.WriteLine("Invalide value;");
            else{
                switch(k){
                    case 1:
                        this.BuyCar();
                        Console.WriteLine("--------------- Update ---------------");
                        this.ShowCars();
                        break;
                    case 2:
                        this.DeleteCar();
                        Console.WriteLine("--------------- Update ---------------");
                        this.ShowCars();
                        break;
                }
            }
        }while(k != 0);
        
    }
}

public class Car{
    public string name { get; set; }
    public string color { get; set; }
    public int speed { get; set; }
    public int year { get; set; }
    public void Infa(){
        
          Console.WriteLine("назва: " + this.name);
          Console.WriteLine("колір: " + this.color);
          Console.WriteLine("рік випуску: " + this.year);
          Console.WriteLine("швидкісь: " + this.speed);
    }
}
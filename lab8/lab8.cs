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
        Car bmw2 = new Car(){name="bmw",color= "red",speed=170,year = 2018};
        Car jimny = new Car(){name="Tesla",color="red",speed=150,year=2017};
        
        Sheiha.cars.Add(bmw);
        Sheiha.cars.Add(bmw2);
        Sheiha.cars.Add(jimny);
        Sheiha.Using();
  }
}

public class Garash{
    public List<Car> cars = new List<Car>();
    // public string[] colorList = ["blue","red","black","yellow","white","green"];
    public void DriveCar(List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<int> old_parametr = new List<int>();
        Console.WriteLine(cars.Count);
        
        while(cars.Count>1  || cars.Count == 0){
            if(cars.Count == 0){
                Console.WriteLine("Нема такої автівки");
                return;
            }
            this.ShowCars(cars);
            Console.WriteLine("обераєм за яким критеріям");
            string [] parametrs = {"Назва", "Колір", "Швидкість","Рік випуску"};
            
            for(int i = 0;i<parametrs.Length;i++){
                bool flag = false; 
                for(int j = 0;j<old_parametr.Count;j++){
                    if((i+1)==old_parametr[j])
                        flag = true;
                }
                if(flag == false)
                    Console.Write((i+1)+")"+parametrs[i]+" ");
            }
            Console.WriteLine();
            int k = 0;
            do{
                Console.Write("filter=");
                k = Convert.ToInt32(Console.ReadLine());
                if(k<1 || k>4)
                    Console.WriteLine("Invalide value");
            }while(k<1 || k>4);
            old_parametr.Add(k);
            switch(k){
                case 1:
                    Console.WriteLine("Назва автівки:");
                    string name = Console.ReadLine();
                    cars = this.filterName(name);
                    break;
                case 2:
                    Console.WriteLine("Колір автівки:");
                    string color = Console.ReadLine();
                    cars = this.filterColor(color);
                    break;
                case 3:
                    Console.WriteLine("Швидкість автівки:");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    cars = this.filterSpeed(speed);
                    break;
                case 4:
                    Console.WriteLine("Рік випуску автівки:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    cars = this.filterYear(year);
                    break;
                }
            }
            if (cars.Count == 0 )
                Console.WriteLine("автівки нема з таким критеріям");
            else{
                Console.WriteLine("ви вибрали авто");
                cars[0].Infa();
            }
            Console.WriteLine("----------------------------------");
        }
    
    public void ShowCars(List<Car> cars = null){
        if(cars==null){
            cars = this.cars;
            for (int i = 0;i < cars.Count;i++){
                Console.WriteLine("------------ Парковачне місце :" + (i+1) + "-----------------");
                cars[i].Infa();
            }
        }else{
            for (int i = 0;i < cars.Count;i++){
                Console.WriteLine("-----------------------------");
                cars[i].Infa();
            }
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
 
    
    public List<Car> filterName(string name, List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.name == name)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> filterColor(string color, List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.color == color)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> filterYear(int year, List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.year == year)
                out_cars.Add(el);
        return out_cars;
    }
    public List<Car> filterSpeed(int speed, List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(el.speed == speed)
                out_cars.Add(el);
        return out_cars;
    }
    
    public List<Car> filterSpeed(int speedmin, int speedmax, List<Car> cars = null){
        if(cars == null)
            cars = this.cars;
        List<Car> out_cars = new List<Car>();
        foreach(Car el in cars)
            if(speedmin <= el.speed && el.speed <= speedmax)
                out_cars.Add(el);
        return out_cars;
    }
    
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
            if(k<0 || k > 3)
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
                    case 3:
                        this.DriveCar();
                        Console.WriteLine("--------------- Update ---------------");
                        break;
                }
            }
        Console.WriteLine("---------- Інтерфейс ----------");
        Console.WriteLine("Купити автівку, натисніть 1)");
        Console.WriteLine("Продати автівку, натисніть 2)");
        Console.WriteLine("Покататись на автівці, натисніть 3)");
        Console.WriteLine("Вихід 0)");
    
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
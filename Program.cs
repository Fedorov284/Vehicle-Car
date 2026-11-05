using System;

class Vehicle
{
    protected double speed = 10;

    public void Start() => Console.WriteLine($"Vehicle: рушання, швидкість {speed}");
}

class Car : Vehicle
{
    public new void Start()
    {
        speed = 60;
        Console.WriteLine($"Car: рушання, швидкість {speed}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Car car = new Car();
        car.Start();                 // метод Car

        // Домашнє: виклик через посилання на базовий клас
        Vehicle v = new Car();
        v.Start();                   // метод Vehicle (приховування, не перевизначення!)

        Console.WriteLine("Висновок: з new викликається метод за типом ПОСИЛАННЯ, а не об'єкта.");
    }
}

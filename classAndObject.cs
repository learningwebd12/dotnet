using System;

//class
class Car
{

    public string color = "red";
    public int price = 250;
}

class Program
{
    public static void Main()
    {
        //object
        Car c1 = new Car();
        Console.WriteLine(c1.color);
        Console.WriteLine(c1.price);
    }
}
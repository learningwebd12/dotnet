using System;

interface IAnimal
{
    void Sound();
    void Eat();
}

class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Animal sound.....");
    }

    public void Eat()
    {
        Console.WriteLine("Eating Food");
    }
}

class Program
{
    public static void Main()
    {
        IAnimal d1 = new Dog();
        d1.Eat();
        d1.Sound();
    }
}
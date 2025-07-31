using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("animal make a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("barking sound");
    }
}

class Program
{
    public static void Main()
    {
        Animal a1 = new Animal();
        a1.MakeSound();

        Dog d1 = new Dog();
        d1.MakeSound();
    }
}
// using System;

// abstract class Animal
// {
//     public abstract void MakeSound();

//     public void Sleep()
//     {
//         Console.WriteLine("Sleeping.....");
//     }
// }

// class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Barking Sound");
//     }
// }

// class Program
// {
//     public static void Main()
//     {

//         // we cannot make Animal object of abstract class
//         Dog d1 = new Dog();
//         d1.MakeSound();
//         d1.Sleep();
//     }
// }
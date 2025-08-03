// using System;

// class Students
// {
//     public delegate void AddDelegate(int a, int b);
//     public delegate void GreetDelegate(string name);

//     public void Add(int x, int y)
//     {
//         Console.WriteLine("addition" + (x + y));
//     }
//     public void Greeting(string name)
//     {
//         Console.WriteLine("Your name is:" + name);
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         Students s1 = new Students();
//         Students.AddDelegate a1 = s1.Add;

//         Students.GreetDelegate b1 = s1.Greeting;

//         a1(10, 20);
//         b1("Ganesh");
//     }
// }
// using System;

// public class FileHandler
// {
//     public FileHandler()
//     {
//         Console.WriteLine("Construct: File opened");
//     }
//     ~FileHandler()
//     {
//         Console.WriteLine("Destruct: file closed");
//     }
// -
//     public void DoWork()
//     {
//         Console.WriteLine("Working with file...");
//     }
//     class Program
//     {
//         public static void Main()
//         {
//             FileHandler h1 = new FileHandler();
//             h1.DoWork();
//         }
//     }
// }
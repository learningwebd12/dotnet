// using System;

// class controlStatement
// {
//     public static void Main()
//     {
//         //conditional statements

//         //if statements
//         int num = 12;
//         if (num > 5)
//         {
//             Console.WriteLine("Greater Than 5");
//         }

//         //if-else
//         if (num % 2 == 0)
//         {
//             Console.WriteLine("Even");
//         }
//         else
//         {
//             Console.WriteLine("odd");
//         }

//         //else-if
//         if (num < 0)
//         {
//             Console.WriteLine("negative");
//         }
//         else if (num == 0)
//         {
//             Console.WriteLine("Zero");
//         }
//         else
//         {
//             Console.WriteLine("Positive");
//         }

//         //switch
//         Console.WriteLine("Enter any Number");
//         int day = int.Parse(Console.ReadLine());
//         switch (day)
//         {
//             case 1:
//                 Console.WriteLine("sunday");
//                 break;

//             case 2:
//                 Console.WriteLine("Monday");
//                 break;
//             case 3:
//                 Console.WriteLine("tuesday");
//                 break;
//             default:
//                 Console.WriteLine("Invalid Day");
//                 break;
//         }


//         //2. looping statements

//         //for loop
//         for (int i = 0; i <= 5; i++)
//         {
//             Console.WriteLine(i);
//         }
//         //while loop
//         int j = 0;
//         while (j < 10)
//         {
//             Console.WriteLine(j);
//             j++;
//         }

//         //do-while-loop
//         Console.WriteLine("do-while");
//         int k = 1;
//         do
//         {
//             Console.WriteLine(k);
//             k++;
//         }
//         while (k <= 5);

//         //foreach loop (used for array or collection)

//         string[] names = { "A", "b", "c", "d", "e" };
//         foreach (string name in names)
//         {
//             Console.WriteLine(name);
//         }

//         //jump statements
//         for (int i = 0; i <= 10; i++)
//         {
//             if (i == 2)
//                 break;
//             Console.WriteLine(i);
//             Console.WriteLine("Break");
//         }


//         for (int i = 0; i <= 10; i++)
//         {
//             if (i == 5 || i == 8 || i == 10)
//                 continue;
//             Console.WriteLine(i);
//         }
//     }
// }
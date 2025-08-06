using System;
class Program
{
    public delegate int Addition(int a, int b);

    public static void Main()
    {
        Addition add = (x, y) => x + y;
        int final = add(10, 20);
        Console.WriteLine(final);
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
}
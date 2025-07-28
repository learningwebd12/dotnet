using System;

public class Myclass
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public static void Main()
    {
        Myclass c1 = new Myclass();
        int result = c1.Add(10, 20);
        Console.WriteLine(result);
    }
}
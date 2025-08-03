using System;

class Program
{
    public delegate void ShowMethod(string message);

    public static void Main()
    {
        ShowMethod show = delegate (string msg)
        {
            Console.WriteLine("Hello" + msg);
        };
        show("This is anonymous method");
    }

}
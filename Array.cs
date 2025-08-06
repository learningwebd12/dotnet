using System;

class MyArray
{
    public static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6 };
        string[] name = { "Ram", "Hari", "Sita" };
        Console.WriteLine(name[1]);
        // Console.WriteLine(myArray[0]);
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }


        int[,] myAr = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int k = 0; k < 2; k++)
        {
            for (int l = 0; l < 3; l++)
            {
                Console.Write(myAr[k, l]);
            }
            Console.WriteLine();
        }

    }
}

for each syntax


foreach (DataType variablename in arrayname) ;

using System;
class Program
{
    public static void Main()
    {
        int[,] number = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(number[i, j]);
            }
        }
    }
}

using System;

class IntegerArray
{
    static void Main()
    {
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
        Console.Read();
    }
}


using System;

class CountNumber
{
    static void Main()
    {
        int[] array = { 4, 2, 6, 8, 4, 3, 5, 7, 5, 3, 32, 56, 5, 3 };
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int counter = Count(number, array);
        if (counter == 0)
        {
            Console.WriteLine("The number {0} is not found", number);
        }
        else
        {
            Console.WriteLine("The number {0} appears {1} times.", number,counter);
        }
        Console.Read();
    }

    public static int Count(int number, int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}


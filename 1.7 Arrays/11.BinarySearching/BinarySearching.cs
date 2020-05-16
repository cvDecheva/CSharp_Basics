using System;

class BinarySearching
{
    static void Main()
    {
        int[] array = { 4, 2, 6, 23, 8, 34, 7, 1,0 };
        Array.Sort(array);
        Console.WriteLine("Sorted array " + String.Join(",",array));
        int number = int.Parse(Console.ReadLine());
        int middle = array.Length % 2 == 0 ? array.Length / 2 - 1 : array.Length / 2; ;
        for (int i = 0; i < Math.Sqrt(array.Length); i++)
        {
            if (array[middle] != number)
            {
                if (array[middle] > number)
                {
                    middle++;
                    middle = middle % 2 == 0 ? middle / 2 - 1 : middle / 2; ;
                }
                else
                {
                    middle++;
                    middle += middle % 2 == 0 ? middle / 2 - 1 : middle / 2; ;
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The index of searching number is " + middle);
        Console.Read();
    }
}


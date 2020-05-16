using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        int temp;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.WriteLine(String.Join(",",array));
        Console.Read();
    }
}


using System;
using System.Collections.Generic;

class EqualElements
{
    static void Main()
    {
        int[] array = new int[10];
        List<int[]> sequences = new List<int[]>();
        int[] sequence = null;
        int count = 1;
        int maxLength = 0;
        bool isValid = false;
        do
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("firstArray[{0}] = ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
                isValid = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) == 0)
                    {
                        count++;
                    }
                    else
                    {
                        Array.Resize<int>(ref sequence, count);
                        for (int j = 0; j < count; j++)
                        {
                            sequence[j] = array[i];
                        }
                        sequences.Add(sequence);
                        sequence = null;
                        count = 1;
                    }
                    if (i == array.Length - 2)
                    {
                        Array.Resize<int>(ref sequence, count);
                        for (int j = 0; j < count; j++)
                        {
                            sequence[j] = array[i + 1];
                        }
                        sequences.Add(sequence);
                    }
                }

                foreach (int[] arr in sequences)
                {
                    if (arr.Length > maxLength)
                    {
                        maxLength = arr.Length;
                    }
                }

                Console.WriteLine("Max sequnces with equal elements:");
                foreach (int[] arr in sequences)
                {
                    if (arr.Length == maxLength)
                    {
                        Console.WriteLine(String.Join(",", arr));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        }
        while (!isValid);
        Console.Read();
    }
}


using System;
using System.Collections.Generic;

class Permutations
{
    static void Main()
    {
        List<int[]> combinations = new List<int[]>();
        int[] array;
        bool areNumebrsValid = false;
        do
        {
            try
            {
                Console.Write("Enter the number of elements in the array:");
                int elements = Convert.ToInt32(Console.ReadLine());
                array = new int[elements];
                if (elements >= 0)
                {
                    areNumebrsValid = true;
                    for (int i = 0; i < elements; i++)
                    {
                        Console.Write("array[{0}] = ", i);
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("Permutations:");
                    Permutation.Permutate(array, 0, elements - 1, combinations);
                    foreach (int[] combination in combinations)
                    {
                        Console.Write(String.Join("",combination) + " ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect numbers!");
            }
        } while (!areNumebrsValid);
        Console.Read();
    }
}

using System;
using System.Collections.Generic;

class FindSum
{
    static void Main()
    {
        int n, S;
        List<int[]> subsets = new List<int[]>();
        List<int[]> subsetsWithSums = new List<int[]>();
        bool isValid = false;
        do
        {
            try
            {
                Console.Write("Enter the number of elements in the array(N): ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Enter the Sum you are searching: ");
                S = int.Parse(Console.ReadLine());
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Array[{0}] = ", i);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                isValid = true;

                //find all subsets
                Combination.MakeCombinations(numbers, subsets);

                //find all subsets with their sums
                Combination.GetCombinationsWithSum(subsets, subsetsWithSums);

                Console.WriteLine();
                foreach (int[] arr in subsetsWithSums)
                {
                    if (S == arr[arr.Length - 1])
                    {
                        Console.WriteLine(Combination.PrintSubsets(arr));
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


using System;
using System.Collections.Generic;

class MaxSum
{
    static void Main()
    {
        int k, n;
        List<int[]> subsets = new List<int[]>();
        List<int[]> subsetsWithLengthK = new List<int[]>();
        int maxSum = int.MinValue;
        bool isValid = false;
        do
        {
            try
            {
                Console.Write("Enter the number of elements in the array(N): ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of elements in the sequence(K): ");
                k = int.Parse(Console.ReadLine());

                int[] numbers = new int[n];
                int[] temp = new int[k + 1];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Array[{0}] = ", i);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                isValid = true;

                //find all subsets
                Combination.MakeCombinations(numbers,subsets);
                //find all subsets with length K and their sums
                Combination.GetCombinationsWithLengthk(subsets,k,subsetsWithLengthK);
                
                //find max sum
                foreach (int[] arr in subsetsWithLengthK)
                {
                    if (maxSum < arr[arr.Length - 1])
                    {
                        maxSum = arr[arr.Length - 1];                       
                    }
                }

                Console.WriteLine();
                foreach (int[] arr in subsetsWithLengthK)
                {
                    if (maxSum == arr[arr.Length - 1])
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


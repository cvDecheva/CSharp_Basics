using System;
using System.Collections.Generic;

class FindSum
{
    static void Main()
    {
        int n, S, K;
        List<int[]> subsets = new List<int[]>();
        List<int[]> subsetsWithLengthK = new List<int[]>();
        bool isValid = false;
        do
        {
            try
            {
                Console.Write("Enter the number of elements in the array(N): ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Enter the Sum you are searching for(S): ");
                S = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of elements in the subsets(K): ");
                K = int.Parse(Console.ReadLine());
                int[] numbers = new int[n];
                int[] temp = null;
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Array[{0}] = ", i);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                isValid = true;
                //find all subsets
                Combination.MakeCombinations(numbers, subsets);

                //find all subsets with length K and their sums
                Combination.GetCombinationsWithLengthk(subsets, K, subsetsWithLengthK);

                Console.WriteLine();
                bool isSubsetsWithSumsEmpty = true;
                foreach (int[] arr in subsetsWithLengthK)
                {
                    if (S == arr[arr.Length - 1])
                    {
                        isSubsetsWithSumsEmpty = false;
                        Console.WriteLine(Combination.PrintSubsets(arr));
                    }
                }
                if (isSubsetsWithSumsEmpty)
                {
                    Console.WriteLine("There is no subset with length {0} and sum {1}!", K, S);
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


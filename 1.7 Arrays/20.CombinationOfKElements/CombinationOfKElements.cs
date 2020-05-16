
using System;
using System.Collections.Generic;

class CombinationOfKElements
{
    static void Main()
    {
        List<int[]> subsets = new List<int[]>();
        List<string> orderedSubsets = new List<string>();
        string number = null;
        bool areNumebrsValid = false;
        do
        {
            try
            {
                Console.Write("Enter the number of elements in the array(N):");
                int elements = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of elements in combination(K):");
                int elementsInCombination = Convert.ToInt32(Console.ReadLine());
                if (elements >= 0 && elementsInCombination >= 0 && elements >= elementsInCombination)
                {
                    areNumebrsValid = true;
                    int[] numbers = new int[elements];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = i + 1;
                    }
                    Combination.MakeCombinations(numbers, subsets);
                    foreach (int[] subset in subsets)
                    {
                        if (subset.Length == elementsInCombination)
                        {
                            number = null;
                            foreach (int num in subset)
                            {
                                number += num;
                            }
                            orderedSubsets.Add(number);
                        }
                    }
                    orderedSubsets.Sort();
                    foreach (var item in orderedSubsets)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect numbers!");
            }
            if (!areNumebrsValid)
            {
                Console.WriteLine("N AND K MUST BE EQUAL OR GREATER THAN 0 AND N MUST BE GREATER OR EQUAL THAN K!");
            }
        } while (!areNumebrsValid);
        Console.Read();
    }
}


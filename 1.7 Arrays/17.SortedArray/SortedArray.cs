using System;
using System.Collections.Generic;

class SortedArray
{
    static void Main()
    {
        bool areValidNumbers = false;
        List<int[]> sortedSubsets = new List<int[]>();
        List<int[]> subsets = new List<int[]>();
        do
        {
            try
            {
                Console.WriteLine("Enter the number of elements of the array:");
                int number = int.Parse(Console.ReadLine());
                int[] array = new int[number];
                for (int i = 0; i < number; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                areValidNumbers = true;

                Combination.MakeCombinations(array, subsets);

                //find all sorted subsets
                bool isSorted = true;
                foreach (int[] sub in subsets)
                {
                    isSorted = true;
                    for (int i = 0; i < sub.Length-1; i++)
                    {
                        if (sub[i] > sub[i + 1])
                        {
                            isSorted = false;
                        }
                    }
                    if (isSorted)
                    {
                        sortedSubsets.Add(sub);
                    }
                }

                //find max length of sorted subsets
                int maxLength = 0;
                foreach (int[] sub in sortedSubsets)
                {
                    if (sub.Length > maxLength)
                    {
                        maxLength = sub.Length;
                    }
                }

                //print sorted subsets with max length
                foreach (int[] sub in sortedSubsets)
                {
                    if (sub.Length == maxLength)
                    {
                        Console.WriteLine(String.Join(", ", sub));
                    }
                }

            }
            catch (Exception e)
            {
                areValidNumbers = false;
                Console.WriteLine("Incorrect numbers!");
            }
        } while (!areValidNumbers);
        Console.Read();
    }
}


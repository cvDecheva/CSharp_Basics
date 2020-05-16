using System;
using System.Collections.Generic;

public static class Combination
{
    public static void MakeCombinations(int[] numbers, List<int[]> subsets)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int subsetCount = subsets.Count;
            subsets.Add(new int[] { numbers[i] });

            for (int j = 0; j < subsetCount; j++)
            {
                int[] newSubset = new int[subsets[j].Length + 1];
                subsets[j].CopyTo(newSubset, 0);
                newSubset[newSubset.Length - 1] = numbers[i];
                subsets.Add(newSubset);
            }
        }
    }

    public static void GetCombinationsWithLengthk(List<int[]> subsets, int k, List<int[]> subsetsWithLengthK)
    {       
        int[] temp;
        foreach (int[] arr in subsets)
        {
            if (arr.Length == k)
            {
                temp = new int[k + 1];
                for (int i = 0; i < temp.Length - 1; i++)
                {
                    temp[i] = arr[i];
                    temp[k] += arr[i];
                }
                subsetsWithLengthK.Add(temp);
                Console.WriteLine(PrintSubsets(temp));
            }
        }
    }

    public static void GetCombinationsWithSum(List<int[]> subsets,List<int[]> subsetsWithLengthK)
    {
        foreach (int[] arr in subsets)
        {
            int[] temp = null;
            Array.Resize<int>(ref temp, arr.Length + 1);
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = arr[i];
                temp[temp.Length - 1] += arr[i];
            }
            subsetsWithLengthK.Add(temp);
            Console.WriteLine(PrintSubsets(temp));

        }
    }

    public static string PrintSubsets(int[] temp)
    {
        string maximumSum = null;
        for (int j = 0; j < temp.Length; j++)
        {
            if (j == 0)
            {
                maximumSum = temp[j].ToString();
            }
            else if (j == temp.Length - 1)
            {
                maximumSum += " = " + temp[j];
            }
            else
            {
                if (temp[j] < 0)
                {
                    maximumSum += temp[j];
                }
                else
                {
                    maximumSum += " + " + temp[j];
                }
            }
        }
        return maximumSum;
    }
}


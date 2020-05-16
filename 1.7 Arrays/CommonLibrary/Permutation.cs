using System;
using System.Collections.Generic;

public static class Permutation
{
    public static void Permutate(int[] array, int firstIndex, int lastIndex, List<int[]> combinations)
    {
        if (firstIndex == lastIndex)
        {
            int[] combination = new int[lastIndex+1];
            for (int i = 0; i <= lastIndex; i++)
            {
                combination[i] = array[i];
            }
            combinations.Add(combination);
        }
        else
        {
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Swap.SwapTwoElements(ref array[firstIndex], ref array[i]);
                Permutate(array, firstIndex + 1, lastIndex, combinations);
                Swap.SwapTwoElements(ref array[firstIndex], ref array[i]);
            }
        }
    }
}


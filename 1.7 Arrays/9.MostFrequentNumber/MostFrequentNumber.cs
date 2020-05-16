using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main()
    {

        int[] array = { 4, 1, 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        List<int[]> numbers = new List<int[]>();
        int[] temp = new int[2];
        bool isThereSuchNumber = false;
        int maxCount = 0;

        temp[0] = array[0];
        temp[1] = 1;
        numbers.Add(temp);
        for (int i = 1; i < array.Length; i++)
        {
            isThereSuchNumber = false;
            for (int j = 0; j < numbers.Count; j++)           
            {
                temp = new int[2];                               
                if (numbers[j][0] == array[i])
                {
                    numbers[j][1]++;
                    isThereSuchNumber = true;
                    break;
                }
            }
            if (!isThereSuchNumber)
            {
                temp[0] = array[i];
                temp[1] = 1;
                numbers.Add(temp);
            }
        }

        foreach (int[] number in numbers)
        {
            if (number[1] > maxCount)
            {
                maxCount = number[1];
            }
        }

        foreach (int[] number in numbers)
        {
            if (number[1] == maxCount)
            {
                Console.WriteLine("{0} ( {1} times )",number[0],number[1]);
            }
        }

        Console.Read();
    }
}


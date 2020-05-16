using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        int[] numbers = new int[99999];
        List<int> temp = new List<int>();
        List<int> primes = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 2;
        }

        for (int j = 0; j < numbers.Length; j++)
        {
            temp = new List<int>();
            primes.Add(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % numbers[0] != 0)
                {
                    temp.Add(numbers[i]);
                }
            }
            numbers = temp.ToArray();
        }

        for (int i = 0; i < primes.Count; i++)
        {
            Console.WriteLine(primes[i]);
        }

        Console.Read();
    }
}


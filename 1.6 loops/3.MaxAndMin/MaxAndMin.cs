using System;
using System.Collections.Generic;

class MaxAndMin
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                int min = 0, max = 0;
                Console.WriteLine("How many numbers do you want to enter:");
                int number = int.Parse(Console.ReadLine());
                List<int> numbers = new List<int>();
                for (int i = 0; i < number; i++)
                {
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
                isValid = true;

       
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (min > numbers[i])
                    {
                        min = numbers[i];
                    }
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                }

                Console.WriteLine("Min = {0}\nMax = {1}", min, max);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}


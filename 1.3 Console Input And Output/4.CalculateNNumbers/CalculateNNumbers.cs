using System;
using System.Collections.Generic;

class CalculateNNumbers
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter the number of numbers to be calculate:");
                int numberOfnumbers = int.Parse(Console.ReadLine());
                List<double> numbers = new List<double>();
                double sum = 0;

                for (int i = 1; i <= numberOfnumbers; i++)
                {
                    Console.WriteLine("Enter number {0}:",i);
                    numbers.Add(double.Parse(Console.ReadLine()));
                }

                foreach (double item in numbers)
                {
                    sum += item;
                }

                Console.WriteLine("The sum of all numbers is {0}.", sum);
                areValidNumbers = true;
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


using System;
using System.Collections.Generic;

class VariationOfKElements
{
    static void Main()
    {
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
                    List<int> number = new List<int>();
                    for (int i = 0; i < elementsInCombination; i++)
                    {
                        number.Add(1);
                    }

                    int j = elementsInCombination - 1;
                    do
                    {
                        number[elementsInCombination - 1] = 0;
                        if (j != elementsInCombination - 1)
                        {
                            number[j]++;
                        }
                        for (int i = 0; i < elements; i++)
                        {
                            number[elementsInCombination - 1]++;
                            Console.WriteLine(String.Join("", number));
                        }
                        if (number[j] == elements)
                        {
                            j--;
                        }
                    } while (j >= 0);
                }
                if (!areNumebrsValid)
                {
                    Console.WriteLine("N AND K MUST BE EQUAL OR GREATER THAN 0 AND N MUST BE GREATER OR EQUAL THAN K!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect numbers!");
            }
        } while (!areNumebrsValid);
        Console.Read();
    }
}


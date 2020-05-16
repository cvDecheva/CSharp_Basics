using System;
using System.Collections.Generic;

class FindSubset
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                int temp = 0;
                int br = 0;
                string expression = null;
                Console.WriteLine("Enter five numbers:");
                List<int> numbers = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
                isValid = true;

                //Works for consecutive combination of numbers
                for (int i = 1; i < numbers.Count + 1; i++)
                {
                    for (int j = 0; j <= numbers.Count - i; j++)
                    {
                        temp = 0;
                        expression = null;
                        for (int k = j; k < j + i; k++)
                        {
                            temp += numbers[k];
                        }
                        if (temp == 0)
                        {
                            br++;
                            for (int n = j; n < j + i; n++)
                            {
                                if (n == j)
                                {
                                    expression += numbers[n];
                                }
                                else if (numbers[n] >= 0)
                                {
                                    expression += "+" + numbers[n];
                                }
                                else
                                {
                                    expression += numbers[n];
                                }
                            }
                            Console.WriteLine("{0}) {1} = 0", br, expression);
                        }
                    }
                }

                Console.WriteLine("\n\n\n");

                //Works for all combination of numbers
                List<int[]> subsets = new List<int[]>();

                for (int i = 0; i < numbers.Count; i++)
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

                br = 0;
                foreach (var item in subsets)
                {
                    temp = 0;
                    expression = null;
                    for (int k = 0; k < item.Length; k++)
                    {
                        temp += item[k];
                    }
                    if (temp == 0)
                    {
                        br++;
                        for (int l = 0; l < item.Length; l++)
                        {
                            if (l == 0)
                            {
                                expression += item[l];
                            }
                            else if (item[l] >= 0)
                            {
                                expression += "+" + item[l];
                            }
                            else
                            {
                                expression += item[l];
                            }
                        }
                        Console.WriteLine("{0}) {1} = 0", br, expression);
                    }                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}


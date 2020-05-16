using System;

class CompareTwoArrays
{
    static void Main()
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        bool isValid = false;
        do {
            try
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write("firstArray[{0}] = ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("secondArray[{0}] = ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }
                isValid = true;

                Console.WriteLine();
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i].CompareTo(secondArray[i]) == 0)
                    {
                        Console.WriteLine("(firstArray[{0}] = {1}) = (secondArray[{0}] = {2})",
                            i, firstArray[i], secondArray[i]);
                    }
                    else if (firstArray[i].CompareTo(secondArray[i]) > 0)
                    {
                        Console.WriteLine("(firstArray[{0}] = {1}) > (secondArray[{0}] = {2})",
                            i, firstArray[i], secondArray[i]);
                    }
                    else 
                    {
                        Console.WriteLine("(firstArray[{0}] = {1}) < (secondArray[{0}] = {2})",
                            i, firstArray[i], secondArray[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        }
        while (!isValid);
        Console.Read();
    }
}


using System;

class LargestIntegerK
{
    static void Main()
    {
        int max = int.MinValue;
        bool areTheNumbersCorrect = false;
        do
        {
            try
            {
                Console.Write("Enter the length of the array: ");
                int sizeOfArray = int.Parse(Console.ReadLine());
                int[] array = new int[sizeOfArray];
                Console.Write("Enter the max number: ");
                int maxNumber = int.Parse(Console.ReadLine());
                for (int i = 0; i < sizeOfArray; i++)
                {
                    Console.Write("array[{0}]= ", i);
                    array[i] = int.Parse(Console.ReadLine());
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                areTheNumbersCorrect = true;
                Array.Sort(array);
                int finding = Array.BinarySearch(array, maxNumber);
                
                Console.WriteLine(finding == -1 ? "There is no such number" : "The number is founded.");
                Console.Write(finding != -1 && max == maxNumber ? "And it is the maximal number in the array." : 
                    "But the number is not the maximal in the array.");
            }
            catch
            {
                Console.WriteLine("There are incorrect values.");
            }
        } while (!areTheNumbersCorrect);
        Console.Read();
    }
}


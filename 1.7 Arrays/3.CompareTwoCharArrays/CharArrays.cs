using System;

class CharArrays
{
    static void Main()
    {
        char[] firstArray = {'f', 'a', '1', 'd'};
        char[] secondArray = { 'k', 'a', '1', 'a', 'w'};

        Console.WriteLine();
        for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
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
        Console.Read();
    }
}


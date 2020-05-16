using System;

class PrintNumbers
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter the number of numbers to be printed:");
                int numberOfnumbers = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberOfnumbers; i++)
                {
                    Console.WriteLine(i);
                }

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


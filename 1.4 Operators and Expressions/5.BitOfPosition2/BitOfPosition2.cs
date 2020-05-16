using System;

class BitOfPosition2
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Is the bit of position 2, 1 - {0}", (number & (1 << 2)) == 4);
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


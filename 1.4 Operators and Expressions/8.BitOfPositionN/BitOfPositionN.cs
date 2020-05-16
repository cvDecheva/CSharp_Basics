using System;

    class BitOfPositionN
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
                Console.WriteLine("Enter bit:");
                int bit = int.Parse(Console.ReadLine());
                int mask = 1 << bit;
                Console.WriteLine("Is the bit of position {0}, 1 - {1}",bit, (number & mask) == mask);
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


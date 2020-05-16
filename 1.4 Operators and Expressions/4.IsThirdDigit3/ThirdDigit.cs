using System;

    class ThirdDigit
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
                int secondNumber = number / 100;
                Console.WriteLine(secondNumber % 10 == 3 ? true.ToString() : false.ToString());
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


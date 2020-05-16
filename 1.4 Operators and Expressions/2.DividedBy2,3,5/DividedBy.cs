using System;

class DividedBy
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
                Console.WriteLine(number % 2 == 0 && number % 3 == 0 && number % 5 == 0 ? 
                    "The number {0} can be divided by 2,3 and 5 without remainder." :
                    "The number {0} can't be divided by 2,3 and 5 without remainder.", number);
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


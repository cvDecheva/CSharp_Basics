using System;

class PrintIntegers
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("First number:");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number:");
                int secondNumber = int.Parse(Console.ReadLine());
                if (firstNumber < secondNumber && firstNumber >= 0 && secondNumber >= 0)
                {
                    int numbersBetween = 0;
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        if (i % 5 == 0)
                        {
                            numbersBetween++;
                        }
                    }
                    Console.WriteLine("p ( {0} , {1} ) = {2}", firstNumber, secondNumber, numbersBetween);
                    areValidNumbers = true;
                }
                else
                {
                    Console.WriteLine("The first and the second number must be greater or equal than 0\n" +
                        "and the second number must be greater than first!\n" +
                        "Try again.");
                }
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


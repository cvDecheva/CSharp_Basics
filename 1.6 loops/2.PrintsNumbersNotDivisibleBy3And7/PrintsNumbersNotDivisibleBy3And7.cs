using System;

class PrintsNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                isValid = true;

                for (int i = 1; i <= number; i++)
                {
                    if (!(i % 3 == 0 && i % 7 == 0))
                    {
                        Console.WriteLine(i);
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


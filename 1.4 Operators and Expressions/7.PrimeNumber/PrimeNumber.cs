using System;

class PrimeNumber
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter number <= 100:");
                int number = int.Parse(Console.ReadLine());
                bool isPrime = true;
                if (number <= 100)
                {
                    areValidNumbers = true;
                    if (!(number <= 1))
                    {
                        for (int i = 2; i < Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                            }
                        }
                    }
                    else
                    {
                        isPrime = false;
                    }
                    Console.WriteLine("Is the number {0} prime - {1}", number, isPrime);
                }
                else
                {
                    Console.WriteLine("The number is greater than 100!");
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


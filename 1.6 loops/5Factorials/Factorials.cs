using System;

class Factorials
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                int nFactorial = 1, kFactorial = 1, mFactorial = 1;
                Console.WriteLine("Enter first number for factorial (N!):");
                int numberN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number for factorial (K!):");
                int numberK = int.Parse(Console.ReadLine());
                if (1 < numberN && numberN < numberK)
                {
                    isValid = true;
                    for (int i = 2; i <= numberN; i++)
                    {
                        nFactorial *= i;
                    }
                    for (int i = 2; i <= numberK; i++)
                    {
                        kFactorial *= i;
                    }
                    for (int i = 2; i <= numberK-numberN; i++)
                    {
                        mFactorial *= i;
                    }
                    Console.WriteLine("N!*K!/(N-K)! = {0}", nFactorial * kFactorial / mFactorial);
                }
                else
                {
                    Console.WriteLine("N must be greter than 1 and K must be greater than N!");
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


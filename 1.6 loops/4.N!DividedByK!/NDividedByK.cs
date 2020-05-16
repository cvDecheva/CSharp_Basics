using System;

class NDividedByK
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                int nFactorial = 1, kFactorial = 1;
                Console.WriteLine("Enter first number for factorial (N!):");
                int numberN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number for factorial (K!):");
                int numberK = int.Parse(Console.ReadLine());
                if (1 < numberK && numberK < numberN)
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
                    Console.WriteLine("N!/K! = {0}",nFactorial/kFactorial);
                }
                else
                {
                    Console.WriteLine("K must be greter than 1 and N must be greater than K!");
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


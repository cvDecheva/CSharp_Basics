using System;

class GCD
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                Console.WriteLine("Enter first number:");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int secondNumber = int.Parse(Console.ReadLine());
                isValid = true;

                while (firstNumber != secondNumber)
                {
                    if (firstNumber > secondNumber)
                    {
                        firstNumber -= secondNumber;
                    }
                    else
                    {
                        secondNumber -= firstNumber;
                    }
                }

                Console.WriteLine("GCD of the numbers is {0}",firstNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}


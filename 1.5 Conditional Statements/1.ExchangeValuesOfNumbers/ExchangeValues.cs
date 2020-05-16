using System;

class ExchangeValues
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {              
                int temp;
                Console.WriteLine("Enter first number:");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int secondNumber = int.Parse(Console.ReadLine());
                isValid = true;

                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0} > {1}", firstNumber, secondNumber);
                    temp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = temp;
                    Console.WriteLine("So first number = {0} and second number = {1}", firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} <= {1}", firstNumber, secondNumber);
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


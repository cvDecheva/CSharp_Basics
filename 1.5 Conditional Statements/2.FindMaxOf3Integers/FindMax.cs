using System;

class FindMax
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
                int max = firstNumber;
                Console.WriteLine("Enter second number:");
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number:");
                int thirdNumber = int.Parse(Console.ReadLine());
                isValid = true;

                if (max < secondNumber)
                {
                    max = secondNumber;
                }
                if (max < thirdNumber)
                {
                    max = thirdNumber;
                }

                Console.WriteLine("The biggest number of {0}, {1}, {2} is {3}",
                    firstNumber, secondNumber, thirdNumber, max);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}


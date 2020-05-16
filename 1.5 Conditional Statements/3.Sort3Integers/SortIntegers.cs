using System;

class SortIntegers
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
                Console.WriteLine("Enter third number:");
                int thirdNumber = int.Parse(Console.ReadLine());
                isValid = true;

                if (firstNumber > secondNumber)
                {
                    temp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = temp;
                }
                if (secondNumber > thirdNumber)
                {
                    temp = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = temp;
                }

                Console.WriteLine("Sorted: {0}, {1}, {2}",
                    firstNumber, secondNumber, thirdNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect values!");
            }
        } while (!isValid);
        Console.Read();
    }
}


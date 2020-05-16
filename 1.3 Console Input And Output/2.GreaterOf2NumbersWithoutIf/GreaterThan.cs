using System;

class GreaterThan
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

                Console.WriteLine(firstNumber - secondNumber == 0 ? "{0} = {1}" :
                    firstNumber - secondNumber > 0 ? "{0} > {1}" :
                    "{0} < {1}", firstNumber, secondNumber);
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


using System;

class ExchangeValues
{
    static void Main()
    {
        int firstValue, secondValue, temp;
        Console.WriteLine("Enter first integer: ");
        firstValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer: ");
        secondValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("First number - {0}\nSecond number - {1}", firstValue, secondValue);
        temp = secondValue;
        secondValue = firstValue;
        firstValue = temp;
        Console.WriteLine("First number - {0}\nSecond number - {1}", firstValue, secondValue);

        Console.Read();
    }
}


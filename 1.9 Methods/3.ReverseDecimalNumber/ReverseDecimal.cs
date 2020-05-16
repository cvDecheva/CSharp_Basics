using System;

class ReverseDecimal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number - {0}", Reverse(number));
        Console.Read();
    }

    public static decimal Reverse(decimal inputNumber)
    {
        char[] numberChars = inputNumber.ToString().ToCharArray();
        Array.Reverse(numberChars);
        string numberString = null;
        for (int i = 0; i < numberChars.Length; i++)
        {
            numberString += numberChars[i];
        }
        decimal number = decimal.Parse(numberString);
        return number;
    }
}


using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = 107;
        string hexadecimalNumber = string.Format("{0:x}", decimalNumber);
        Console.WriteLine("{0} -> {1}", decimalNumber,hexadecimalNumber.ToUpper());
        Console.Read();
    }
}


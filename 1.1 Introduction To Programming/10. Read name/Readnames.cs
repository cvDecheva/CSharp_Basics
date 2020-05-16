using System;

class ReadNames
{
    static void Main()
    {
        string firstName, lastName;
        Console.WriteLine("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        lastName = Console.ReadLine();
        Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        Console.Read();
    }
}


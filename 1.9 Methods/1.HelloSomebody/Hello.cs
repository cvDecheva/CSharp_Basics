using System;

class Hello
{
    static void Main()
    {
        HelloSomebody();
        Console.Read();
    }

    public static void HelloSomebody()
    {
        Console.Write("Write your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}


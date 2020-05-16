using System;

class Fibonacci
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                int fibonacci = 0;
                int previous = 1;
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                isValid = true;
                Console.WriteLine(fibonacci);
                for (int i = 0; i <= number; i++)
                {
                    int temp = previous;
                    previous = fibonacci;
                    fibonacci = temp + fibonacci;
                    Console.WriteLine(fibonacci);
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


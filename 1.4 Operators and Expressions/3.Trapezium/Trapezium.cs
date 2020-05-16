using System;

class Trapezium
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter the first base of the trapezium:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second base of the trapezium:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the trapezium:");
                double h = double.Parse(Console.ReadLine());

                if (a >= 0 && b >= 0 && h >= 0)
                {
                    Console.WriteLine("The area of the trapezium is: {0}", (a + b) / 2 * h);
                    areValidNumbers = true;
                }
                else
                {
                    Console.WriteLine("The sides must be greater than 0!");
                }
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


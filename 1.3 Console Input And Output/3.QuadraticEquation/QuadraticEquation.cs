using System;

class QuadraticEquation
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("coefficients a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("coefficients b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("coefficients c:");
                double c = double.Parse(Console.ReadLine());

                if (a != 0)
                {
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        Console.WriteLine("The equation has no roots,because D < 0!");
                    }
                    else if (d > 0)
                    {
                        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine("The equation roots are x1 = {0} and x2 = {1}.", x1, x2);
                    }
                    else
                    {
                        double x = (-b) / (2 * a);
                        Console.WriteLine("The equation root is x = {0}.", x);
                    }

                    areValidNumbers = true;
                }
                else
                {
                    Console.WriteLine("a MUST be != 0");
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


using System;

class PointInCircle
{
    static void Main()
    {
        bool areValidNumbers = false;
        do
        {
            try
            {
                Console.WriteLine("Enter the coordinate x of the point A:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the coordinate y of the point A:");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Point A({0},{1}) is in the circle with R = 4 - {2}",
                    x,y,x * x + y * y <= 4 * 4);
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


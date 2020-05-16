using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IsPointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter first coordinate:");
                    double xCoordinate = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second coordinate:");
                    double yCoordinate = double.Parse(Console.ReadLine());
                    isValid = true;

                    if ((xCoordinate * xCoordinate + yCoordinate * yCoordinate <= 4 * 4))
                    {
                        Console.WriteLine("The point is in the circle.");
                    }
                    else
                    {
                        Console.WriteLine("The point isn't in the circle.");
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
}

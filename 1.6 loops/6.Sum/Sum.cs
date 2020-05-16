using System;

class Sum
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                double sum = 1, factorial = 1;
                Console.WriteLine("Enter N:");
                int numberN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter X:");
                int numberX = int.Parse(Console.ReadLine());
                if (numberN > 0 && numberX > 0)
                {
                    isValid = true;
                    for (int i = 1; i <= numberN; i++)
                    {
                        factorial = 1;
                        for (int j = 1; j <= i; j++)
                        {
                            factorial *= j;
                        }
                        sum += factorial / Math.Pow(numberX, i);
                    }
                    Console.WriteLine("sum = {0}", sum);
                }
                else
                {
                    Console.WriteLine("Numbers must be bigger than 0!");
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


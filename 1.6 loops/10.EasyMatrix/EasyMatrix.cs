using System;

class EasyMatrix
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            int counter = 0;
            try
            {
                Console.WriteLine("Enter the size of the matrix:");
                int number = int.Parse(Console.ReadLine());
                isValid = true;

                for (int i = 0; i < number; i++)
                {
                    counter++;
                    for (int j = counter; j < number+counter; j++)
                    {
                        Console.Write("{0,4}",j);
                    }
                    Console.WriteLine();
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


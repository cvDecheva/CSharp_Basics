using System;

class FindBit
{
    static void Main()
    {
        bool isValid = false;
        do
        {
            try
            {
                Console.WriteLine("Enter number:");
                int number = int.Parse(Console.ReadLine());
                isValid = true;

                if ((number & (1 << 2)) == (1 << 2))
                {
                    Console.WriteLine("Third bit is 1");
                }
                else
                {
                    Console.WriteLine("Third bit is 0");
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

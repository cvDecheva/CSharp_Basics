using System;

class NamesOfNumbers
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

                switch (number)
                {
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                    default: Console.WriteLine("I don't know the name of this number :D"); break;
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


using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        string firstStringNumber, secondStringNumber;
        double firstDoubleNumber = 0, secondDoubleNumber = 0;
        bool isCorrect = false;

        while (!isCorrect)
        {
            Console.WriteLine("Enter the first number:");
            firstStringNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            secondStringNumber = Console.ReadLine();

            try
            {
                firstDoubleNumber = Math.Round(Convert.ToDouble(firstStringNumber), 5);
                isCorrect = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("INCORRECT FISRT NUMBER {0}", e.Message);
                isCorrect = false;
            }
            try
            {
                secondDoubleNumber = Math.Round(Convert.ToDouble(secondStringNumber), 5);
                isCorrect = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("INCORRECT SECOND NUMBER {0}", e.Message);
                isCorrect = false;
            }
        }

        if (firstDoubleNumber.CompareTo(secondDoubleNumber) == 0)
        {
            Console.WriteLine("{0} = {1}", firstDoubleNumber, secondDoubleNumber);
        }
        else if (firstDoubleNumber.CompareTo(secondDoubleNumber) > 0)
        {
            Console.WriteLine("{0} > {1}", firstDoubleNumber, secondDoubleNumber);
        }
        else
        {
            Console.WriteLine("{0} < {1}", firstDoubleNumber, secondDoubleNumber);
        }

        Console.Read();
    }
}


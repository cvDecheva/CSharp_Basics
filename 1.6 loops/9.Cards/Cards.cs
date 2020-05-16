using System;

class Cards
{
    static void Main()
    {
        string color = null;
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0: color = "Club"; break;
                case 1: color = "Diamond"; break;
                case 2: color = "Heart"; break;
                case 3: color = "Spade"; break;
            }
            for (int j = 1; j < 14; j++)
            {
             
                switch (j)
                {
                    case 1: Console.Write("{0,8} {1,6}", color , "Ace|"); ; break;
                    case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10:
                        Console.Write("{0,8} {1,6}|", color, j); ; break;
                    case 11: Console.Write("{0,8} {1,6}", color, "Jack|"); ; break;
                    case 12: Console.Write("{0,8} {1,6}", color, "Queen|"); ; break;
                    case 13: Console.WriteLine("{0,8} {1,6}", color, "King|"); ; break;
                }               
            }
        }
        Console.Read();
    }
}


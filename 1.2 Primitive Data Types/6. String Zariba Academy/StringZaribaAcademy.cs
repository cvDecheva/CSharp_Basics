using System;

class StringZaribaAcademy
{
    static void Main()
    {
        string name = "Zariba";
        string academy = "Academy";
        object objectAcademy = name + " " + academy;
        string stringAcademy = (string)objectAcademy;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}", name, academy, objectAcademy, stringAcademy);
        Console.Read();
    }
}


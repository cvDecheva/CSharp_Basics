using System;

class FavouriteMovie
{
    static void Main()
    {
        string myFavMovie = "My favorite movie is ";
        Console.WriteLine("Enter your favourite movie:");
        string movie = Console.ReadLine();
        Console.WriteLine(myFavMovie + movie);
        Console.Read();
    }
}


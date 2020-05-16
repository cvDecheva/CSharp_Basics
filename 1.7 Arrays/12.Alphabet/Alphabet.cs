using System;

class Alphabet
{
    static void Main()
    {
        string word = null;
        char[] alphabet = new char[26];
        char letter = 'a';
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = letter;
            letter++;
        }

        Console.Write("Enter a word: ");
        word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("{0} = ",word[i]);
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine(j);
                }
            }
        }

        Console.Read();
    }
}


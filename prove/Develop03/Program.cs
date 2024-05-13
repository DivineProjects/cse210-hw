using System;

class Program
{
    static void Main(string[] args)
    {
        // Inputs
        string book = "1 Nephi";
        int chapter = 3;
        int verse = 20;
        int endVerse = 0;
        string bookVerseText = "And inasmuch as ye shall keep my commandments, ye shall prosper, and shall be led to a land of promise; yea, even a land which I have prepared for you; yea, a land which is choice above all other lands.";


        //  Declare Objects
        Reference verseReference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(verseReference, bookVerseText);

        string input = "";
        int minWords = 1;
        int maxWords = 4;

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("\nInput any Key to Continue / 'Y' to quit: ");
        input = Console.ReadLine().ToLower();

        do
        {

            Random random = new Random();
            
            int i = random.Next(minWords, maxWords);
            Console.Clear();
            scripture.HideRandomWords(i);
            Console.Write("\n\nInput any Key to Continue / 'Y' to quit: ");
            input = Console.ReadLine().ToLower();
            maxWords += i;
            minWords += i;

        } while ((scripture.IsCompletelyHidden()==true) && input != "y");

        Console.WriteLine("*** Thank You for Play ***");


    }
}
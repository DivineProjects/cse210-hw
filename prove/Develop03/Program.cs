using System;

class Program
{
    static void Main(string[] args)
    {
        // Inputs
        string book = "John";
        int chapter = 3;
        int verse = 16;
        int endVerse = 20;
        string bookVerseText = "This is a sample text to convert into a list of words.";
        

        //  Declare Objects
        Reference verseReference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(verseReference, bookVerseText);

        string input = "";
        int minWords = 1;
        int maxWords = 4;
        do
        {

            Random random = new Random();
            Console.Clear();
            Console.WriteLine("====================================================");
            scripture.GetDisplayText();
            Console.WriteLine();

            // scripture.HideRandomWords(random.Next(numGaps, numberOfHidenWords));
            int i = random.Next(minWords, maxWords);
            scripture.HideRandomWords(i);
            Console.Write("\n\nInput any Key to Continue / 'Y' to quit: ");
            input = Console.ReadLine().ToLower();
            maxWords += i;
            minWords += i;

        } while (scripture.IsCompletelyHidden() && input != "y");

        Console.WriteLine("*** Thank You for Play ***");


    }
}
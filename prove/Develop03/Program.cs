using System;
/* >>>>>>>> Showing Creativity and Exceeding Requirements <<<<<<<< 
    class: ReadScripture.cs
    functions:
    -reads scripture details from a seperate data file names data.cs
    -Gets Book name, Chapter, Verse and End verse using methods
    - GetBook()
    -GetChapter()
    -GetEndVerse()
    -GetText()
*/

class Program
{
    static void Main(string[] args)
    {
        // Inputs Verse
        ReadScripture readScripture=new ReadScripture();

        string book = readScripture.GetBook();
        int chapter = readScripture.GetChapter();
        int verse = readScripture.GetVerse();
        int endVerse =readScripture.GetEndVerse();
        string bookVerseText =  readScripture.GetText();

        //  Declare Objects
        Reference verseReference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(verseReference, bookVerseText);

        string input = "";
        int minWords = 1;
        int maxWords = 4;

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("\nPress Enter to Continue / 'Y' to quit: ");
        input = Console.ReadLine().ToLower();
    
        while ((scripture.IsCompletelyHidden() == true) && input != "y")
        {
            Random random = new Random();
            
            int i = random.Next(minWords, maxWords);
            Console.Clear();
            scripture.HideRandomWords(i);
            Console.Write("\n\nInput any Key to Continue / 'Y' to quit: ");
            input = Console.ReadLine().ToLower();
            maxWords += i;
            minWords += i;
        }
        
        Console.WriteLine("*** Thank You for Play ***");
    }
}
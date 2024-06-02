using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video & Add comments to video
        Video video1 = new Video("Programming I", "Bob Builder", 300);
        video1.AddComment(new Comment("Shoni", "I love it!"));
        video1.AddComment(new Comment("Shillar", "Best tutorial ever"));
        video1.AddComment(new Comment("Eric", "Improve videos quality"));

        // Create video & Add comments to video
        Video video2 = new Video("Programming II", "Jane Dore", 700);
        video2.AddComment(new Comment("Mengi", "This is exactly what I needed."));
        video2.AddComment(new Comment("Tantswa", "Awesome!!!"));
        video2.AddComment(new Comment("Nkosi", "Ohh, great video"));

        // Create video & Add comments to video
        Video video3 = new Video("Programming III", "John Dore", 900);
        video3.AddComment(new Comment("Mongi", "Very useful, thanks!"));
        video3.AddComment(new Comment("Fiona", "Where were you, needed this"));
        video3.AddComment(new Comment("Thandi", "Something special, well thought out"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        //  display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. 
        int count = 1;
        Console.Clear();
        foreach (Video video in videos)
        {
            //Display title, author, length, number of comments
            Console.WriteLine($"\n======== YouTube Video No : {count} =======================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("-------------------------------------------------------");
            count += 1;
            // Display comments for each video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"* {comment.GetName()}: {comment.GetComment()}");
            }

            Console.WriteLine("-------------------------------------------------------");

        }



    }
}
using System;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        video video1 = new video("How to Program in C#", "Michael Tafunai", 600);
        video video2 = new video("Top 10 programming tips", "Dev Guru", 480);
        video video3 = new video("Understanding Algorithms", "Tec World", 720);

        video1.AddComment(new Comment("Michael", "Great video, very informative!"));
        video1.AddComment(new Comment("Dev Guru", "Thanks for the tips!"));
        video1.AddComment(new Comment("Tec World", "Very helpful explanation."));

        video2.AddComment(new Comment("John", "Loved the tips, very useful."));
        video2.AddComment(new Comment("Bob", "Could you make a video on data structures?"));
        video2.AddComment(new Comment("Alice", "This helped me a lot, thanks!"));

        video3.AddComment(new Comment("Sarah", "Algorithms made easy!"));
        video3.AddComment(new Comment("Tom", "Can you explain sorting algorithms next?"));
        video3.AddComment(new Comment("Emma", "Fantastic content, keep it up!"));

        List<video> videos = new List<video> { video1, video2, video3 };

        foreach (video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments ())
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("_______________________________");
        }


    }
}
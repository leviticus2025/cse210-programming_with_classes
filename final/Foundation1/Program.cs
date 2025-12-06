using System;
using System.Runtime.CompilerServices;

class Program
{
    private List<Video> _videos;
    public Program()
    {
        _videos = new List<Video>();
    }
    public void Run()
    {
        Video video1 = new Video("Abstraction in C# Explained", "Levi", 420);
        video1.AddComment(new Comment("Allison", "Good explanation!"));
        video1.AddComment(new Comment("Greg", "I understand C# a lot more now!"));
        video1.AddComment(new Comment("Karli", "Super helpful Levi!"));

        Video video2 = new Video("Netflix - Stranger Things Season 4 Recap", "Leviticus", 660);
        video2.AddComment(new Comment("Dustin", "Stay Stranger!"));
        video2.AddComment(new Comment("Mike", "I'm so excited to see the new season now!"));
        video2.AddComment(new Comment("Eleven", "Super insightful Leviticus!"));

        Video video3 = new Video("Dirt Bike Cosmetic Removal and Re-installation", "Wrangler", 360);
        video3.AddComment(new Comment("Dustin", "Those plastics are always so hard to get off!"));
        video3.AddComment(new Comment("Mike", "I'm so excited to do this on my own bike!"));
        video3.AddComment(new Comment("Eleven", "I couldn't figure this out until I saw your video!"));
        
        Video video4 = new Video("Binary Breakdown in 15 minutes", "Bro. Beasley", 900);
        video4.AddComment(new Comment("Cameron", "Thank you for your video explanation!"));
        video4.AddComment(new Comment("Emma", "Super helpful videos as always!"));
        video4.AddComment(new Comment("Nathan", "Great job!"));

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.GetVideoInfo());

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine(" " + c.GetCommentString());
            }

        }
    }
    public static void Main(string[] args)
    {
        new Program().Run();
    }
}
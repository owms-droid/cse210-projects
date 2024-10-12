using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Learn C# in 10 Minutes", "Tech Guru", 720);
        Video video3 = new Video("Yoga for Beginners", "Yoga Master", 900);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video1.AddComment(new Comment("Bob", "I tried this recipe, it turned out great!"));
        video1.AddComment(new Comment("Charlie", "Thanks for the tips, Chef!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Dave", "This was super informative, thanks!"));
        video2.AddComment(new Comment("Eve", "I love C#, this was a great refresher."));
        video2.AddComment(new Comment("Frank", "Very clear and concise."));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "I feel so relaxed after following this."));
        video3.AddComment(new Comment("Heidi", "Perfect for beginners, thank you!"));
        video3.AddComment(new Comment("Ivan", "Great session, looking forward to more!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); // Blank line for readability between videos
        }
    }
}
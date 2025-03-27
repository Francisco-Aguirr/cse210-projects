using System;

class Program
{
    static void Main(string[] args)
    {
       // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and configure first video
        Video video1 = new Video("Learning C#", "Novice Programmer", 600);
        video1.AddComment(new Comment("User1", "Great tutorial, thank you!"));
        video1.AddComment(new Comment("User2", "Could you explain abstract classes better?"));
        video1.AddComment(new Comment("User3", "Helped me a lot with my homework"));
        videos.Add(video1);

        // Create and configure second video
        Video video2 = new Video("Cake Recipe", "Home Chef", 1200);
        video2.AddComment(new Comment("Cook1", "Tried it and it was delicious"));
        video2.AddComment(new Comment("Beginner", "What can I use instead of flour?"));
        video2.AddComment(new Comment("Foodie", "Very basic but well explained"));
        video2.AddComment(new Comment("Anonymous", "Too sweet for my taste"));
        videos.Add(video2);

        // Create and configure third video
        Video video3 = new Video("iPhone 15 Unboxing", "TechReviews", 300);
        video3.AddComment(new Comment("AppleFan", "So exciting, I want mine now!"));
        video3.AddComment(new Comment("Skeptic", "Don't see much difference from previous model"));
        video3.AddComment(new Comment("Curious", "How much does it cost in your country?"));
        videos.Add(video3);

        // Display information for all videos
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }

}
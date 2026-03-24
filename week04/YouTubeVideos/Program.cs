using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("5 Steps to Become a Billionaire", "Mark Cuban", 123);
        Video video2 = new Video("Mr. Beast Goes to Mars", "Mr. Beast", 456);
        Video video3 = new Video("Best Dunks of the 2000's", "Michael Jordan", 789);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Super helpful!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "This was amazing!"));
        video2.AddComment(new Comment("Eve", "Loved it!"));
        video2.AddComment(new Comment("Frank", "Sign me up next!"));

        // Add comments to video3
        video3.AddComment(new Comment("Gabe", "GOAT!"));
        video3.AddComment(new Comment("Hannah", "SKYWALKER!"));
        video3.AddComment(new Comment("Ian", "Make more videos!"));

        foreach (Video v in videos)
        {
            Console.WriteLine("----- VIDEO -----");
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Comments: {v.GetCommentCount()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"{c.GetName()}: {c.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
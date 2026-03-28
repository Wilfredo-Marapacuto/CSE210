using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Change Engine Oil", "AutoFix Channel", 420);
        video1.AddComment(new Comment("Carlos", "Very helpful video!"));
        video1.AddComment(new Comment("Ana", "Now I understand the process better."));
        video1.AddComment(new Comment("Mike", "Clear explanation and easy steps."));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Immigration Tips", "Legal Pathway", 615);
        video2.AddComment(new Comment("Maria", "Thank you for sharing this information."));
        video2.AddComment(new Comment("Jose", "This answered many of my questions."));
        video2.AddComment(new Comment("Luisa", "Please make more videos like this."));
        videos.Add(video2);

        Video video3 = new Video("Beginner Piano Lesson", "Music Start", 300);
        video3.AddComment(new Comment("Emma", "I loved this lesson."));
        video3.AddComment(new Comment("David", "This was simple and easy to follow."));
        video3.AddComment(new Comment("Sophia", "Great for beginners!"));
        videos.Add(video3);

        Video video4 = new Video("Healthy Breakfast Ideas", "Daily Living", 510);
        video4.AddComment(new Comment("Olivia", "These recipes look amazing."));
        video4.AddComment(new Comment("Noah", "I will try the oatmeal tomorrow."));
        video4.AddComment(new Comment("Isabella", "Easy and practical ideas."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
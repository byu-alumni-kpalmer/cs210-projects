using System;
using System.Collections.Generic;

namespace YouTubeTrackVids
{
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthSeconds { get; set; }
        private List<Comment> comments;

        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
            comments = new List<Comment>();
        }

        public void AddComment(string commenterName, string commentText)
        {
            Comment comment = new Comment(commenterName, commentText);
            comments.Add(comment);
        }

        public int GetNumComments()
        {
            return comments.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Length (seconds): " + LengthSeconds);
            Console.WriteLine("Number of comments: " + GetNumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                Console.WriteLine("- " + comment.CommenterName + " says: " + comment.CommentText);
            }
            Console.WriteLine();
        }
    }
}
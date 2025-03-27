using System.Collections.Generic;

// Video class representing a YouTube video
public class Video
{
    // Private fields (encapsulation)
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Public properties
    public string Title { get => _title; }
    public string Author { get => _author; }
    public int LengthInSeconds { get => _lengthInSeconds; }

    // Method to add a comment (abstraction)
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display video information and comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();
    }
}
// Comment class representing a YouTube comment
public class Comment
{
    // Private fields (encapsulation)
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Public properties to access private fields
    public string CommenterName { get => _commenterName; }
    public string CommentText { get => _commentText; }

    // Method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"- {_commenterName}: \"{_commentText}\"");
    }
}
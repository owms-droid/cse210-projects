using System;

class Video
{
    public string Title { get; set; }   // Title of the video
    public string Author { get; set; }  // Author of the video
    public int Length { get; set; }     // Length of the video in seconds
    private List<Comment> comments;     // List to store comments for the video

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to display video details and comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}
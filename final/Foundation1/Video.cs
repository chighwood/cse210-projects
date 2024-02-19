using System;
using System.Collections.Generic;
using System.Transactions;


public class Video 
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this._title = title;
        this._author = author;
        this._lengthInSeconds = lengthInSeconds;
        this._comments = new List<Comment>();
    }
    public void AddComment(string commenterName, string word)
    {
        _comments.Add(new Comment(commenterName, word));
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideoInfo() 
    {
        Console.WriteLine($"Title of video: {_title}");
        Console.WriteLine($"Author of video: {_author}");
        Console.WriteLine($"Length of video: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetWords()}");
        }
        Console.WriteLine();
    }
}
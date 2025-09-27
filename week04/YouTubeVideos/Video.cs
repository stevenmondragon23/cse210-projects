using System;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public int GetCommentCount()
    {
        return _comments.Count;
    }


    public void AddComent(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"NAME: {_title}");
        Console.WriteLine($"AUTHOR: {_author}");
        Console.WriteLine($"DURATION: {_length} HOUR");
        Console.WriteLine($"NUMBER OF COMMENTS: {GetCommentCount()}");


        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._commenterName} : {comment._allText}");
        }
        Console.WriteLine();
    } 




}
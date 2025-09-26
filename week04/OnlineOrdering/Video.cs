using System;

class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    public List<Comment> _comments = new List<Comment>();


    public int GetCommentCount()
    {
        return 0;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"NAME: {_title} | AUTHOR: {_author} | DURATION: {_lenght} HOUR");
    } 




}
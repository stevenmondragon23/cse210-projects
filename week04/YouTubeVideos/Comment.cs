using System;

class Comment
{
    public string _commenterName;
    public string _allText;


    public Comment(string author, string text)
    {
        _commenterName = author;
        _allText = text;
    }
}
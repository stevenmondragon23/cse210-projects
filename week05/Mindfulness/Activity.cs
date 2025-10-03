using System;
using System.Reflection;

class Activity
{

    /*------------------------------------------------*/

    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    /*--------------------BUILDER----------------------------*/
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }

    /*------------------------------------------------*/

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have complete another {_duration} seconds of the {_name}");
    }







}
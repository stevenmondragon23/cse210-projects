using System;
using System.Reflection;

public class Activity
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

    /*SETTER*/




    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    /*------------------------------------------------*/

    public void DisplayStartingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have complete another {_duration} seconds of the {_name}");
        Console.WriteLine("");

    }


    /*----------------------------------------------------*/

    public void ShowSpinner(int seconds)
    {

        int i = 0;

        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");


        DateTime startime = DateTime.Now;
        DateTime endtime = startime.AddSeconds(seconds);

        while (DateTime.Now < endtime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }

        }
    }


    /*-------------------------------------*/

    public void ShowCountDown(int seconds)
    {
        
    int i = 0;
    List<int> countDown = new List<int>();

    for (int s = seconds; s >= 0; s--)
    {
        countDown.Add(s);
    }

    
    while (i < countDown.Count)
    {
        Console.Write(countDown[i]); 
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        i++;
    }

    Console.WriteLine(); 

    }
    /*-----------------------------------------------*/
}
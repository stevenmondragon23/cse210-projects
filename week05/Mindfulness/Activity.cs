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

    /*------------------------------------------------*/

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have complete another {_duration} seconds of the {_name}");
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
            Thread.Sleep(1000);
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
            
        int width = seconds.ToString().Length; // calcula el ancho máximo una sola vez

        for (int i = seconds; i >= 0; i--)
        {
            Console.Write("\r" + i.ToString().PadLeft(width));
            Thread.Sleep(1000);
        }

        Console.WriteLine(); // salto final
    
    }
    /*-----------------------------------------------*/

}
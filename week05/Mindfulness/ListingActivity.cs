using System;
using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    /*--------------------------------------------------------*/
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0)
    {

    }

    /*---------------------------------------------------*/

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);


        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.Write($"---");
        GetRandomPrompt();
        Console.WriteLine(" ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5); 

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();


    }

    /*-----------------------------------------------*/

    public Random rand = new Random();
    public void GetRandomPrompt()
    {
        int index = rand.Next(_prompts.Count);
        Console.Write(_prompts[index]);
    }

    /*-----------------------------------------------*/

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        return responses;
    }

    /*-----------------------------------------------*/



}
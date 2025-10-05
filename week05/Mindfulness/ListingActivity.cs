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
        DisplayStartingMessage();
        Console.Write("How long, in seconds would you like for your session?  ");
        int count = int.Parse(Console.ReadLine());
        SetDuration(count);
        Console.WriteLine("");
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.Write($"------------- ");
        GetRandomPrompt();
        Console.WriteLine(" -------------");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        int newCount = count / 5;

        while (newCount != _count)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            _count++;


        }

        Console.WriteLine($"You listed {_count} items");

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
        List<string> userList = new List<string>();
        Console.WriteLine("Escribe tus elementos (deja vacío y presiona Enter para terminar):");

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break; 
            }

            userList.Add(input);
        }

        return userList;
    }

    /*-----------------------------------------------*/



}
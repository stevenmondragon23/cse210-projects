using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 0)
    {
        
    }

    /*-------------------------------------------------------*/

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


        /*--------------------------------------------------------------------*/

        Console.Write("Breath in...");
        ShowCountDown(2);
        Console.Write("Now Breathe out...");
        ShowCountDown(3);


        int newCount = count / 10;
        while (newCount != 0)
        {

            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("Now Breathe out...");
            ShowCountDown(6);

            newCount--;
        }

        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        ShowSpinner(5);

        DisplayEndingMessage();

    }
    
    /*-----------------------------------------------*/


}
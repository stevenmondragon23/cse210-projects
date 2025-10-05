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

        Console.Clear();
        DisplayStartingMessage();

        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.Write("Breathe in...");
        ShowCountDown(2); 
        Console.Write("Now breathe out...");
        ShowCountDown(3); 
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in...");
                ShowCountDown(4); // cuenta regresiva para inhalar
                Console.Write("Now breathe out...");
                ShowCountDown(6); // cuenta regresiva para exhalar
                Console.WriteLine();
            }

        DisplayEndingMessage();

    }
    
    /*-----------------------------------------------*/


}
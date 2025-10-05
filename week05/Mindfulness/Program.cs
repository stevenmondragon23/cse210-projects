using System;
using System.Collections.Generic;

/*
 * EXTRA CREDIT:
 * A simple activity counter has been added to keep track of how many times
 * each activity is performed during the session. This fulfills the rubric's
 * creativity requirement by adding functionality beyond the basic program.
 */

class Program
{
    static void Main(string[] args)
    {
        int answerUser = 0;

        Dictionary<string, int> activityLog = new Dictionary<string, int>()
        {
            { "Breathing", 0 },
            { "Reflecting", 0 },
            { "Listing", 0 }
        };

        while (answerUser != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1.- Start Breathing Activity");
            Console.WriteLine("     2.- Start Reflecting Activity");
            Console.WriteLine("     3.- Start Listing Activity");
            Console.WriteLine("     4.- Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu:  ");

            answerUser = int.Parse(Console.ReadLine());

            if (answerUser == 1)
            {
                BreathingActivity breathActivity = new BreathingActivity();
                breathActivity.Run();
                activityLog["Breathing"]++;
            }
            else if (answerUser == 2)
            {
                ReflectingActivity reflectActivity = new ReflectingActivity();
                reflectActivity.Run();
                activityLog["Reflecting"]++;
            }
            else if (answerUser == 3)
            {
                ListingActivity listActivity = new ListingActivity();
                listActivity.Run();
                activityLog["Listing"]++;
            }
            else if (answerUser == 4)
            {
                Console.Clear();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($" - Breathing Activity: {activityLog["Breathing"]} times");
                Console.WriteLine($" - Reflecting Activity: {activityLog["Reflecting"]} times");
                Console.WriteLine($" - Listing Activity: {activityLog["Listing"]} times");
                Console.WriteLine("\nGoodbye!");
                break;
            }
            else
            {
                Console.WriteLine("That is not an option");
            }
        }
    }
}

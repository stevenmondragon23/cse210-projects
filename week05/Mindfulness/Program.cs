using System;

class Program
{
    static void Main(string[] args)
    {
        int answerUser = 0;

        while (answerUser != 4)
        {
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
                BreathingActivity BreathActivity = new BreathingActivity();
                BreathActivity.Run();
            }

            if (answerUser == 2)
            {
                ReflectingActivity ReflectActivity = new ReflectingActivity();
                ReflectActivity.Run();   
            }


            if (answerUser == 3)
            {
                ListingActivity ListActivity = new ListingActivity();
                ListActivity.Run();
            }
        }
        
            
        
    }
}
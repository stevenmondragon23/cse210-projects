using System;
using System.Collections.Generic;


// -------------------------------------------------------------
// AUTHOR: STEVEN MONDRAGON
// POURPOSE: PRINT AND HIDE A SCRIPTURE
// Exceeding Requirements - Explanation
//
// In addition to the core requirements of the project, this program
// goes beyond by including a small library of scriptures instead of
// just one. At the start of the program, it randomly selects from
// 5 different scriptures taken from the Book of Mormon. 
//
// -------------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Ether", 12, 27), "My grace is sufficient for all men that humble themselves before me."),
            new Scripture(new Reference("Moroni", 10, 4, 5), "Ask God, the Eternal Father, in the name of Christ, if these things are not true; and he will manifest the truth of it unto you."),
            new Scripture(new Reference("Mosiah", 18, 9), "Stand as witnesses of God at all times and in all things.")
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Program finished.");
                break;
            }
        }
    }
}

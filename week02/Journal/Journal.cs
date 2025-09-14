using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

/*

AUTHOR: STEVEN MONDRAGON
PROGRAM: CREATE A VIRTUAL JOURNAL

EXCEED THE REQUIREMENTS:
    - The program creates a CSV file to save and load the entries made by the user, making it easy to view the information in Excel. 
*/



public class Journal
{


    /*------------------PUBLIC VARIABLES-----------*/
    public static List<Entry> _entries = new List<Entry>();


    /*-------FUNCTIONS----*/
    static void Main(string[] args)
    {
        /*----------CREATING THE FILE----------------------------*/
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "MY JOURNAL");
        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder MY JOURNAL not exist. Creating the folder...");
            Directory.CreateDirectory(folderPath);
        }

        else
        {
            Console.WriteLine("The folder exist");
        }

        string filePath = Path.Combine(folderPath, "myJournal.csv");

        /*---------------------------------------------------------------*/
        Console.WriteLine("Welcome to the Journal Program.");
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int _choice = int.Parse(Console.ReadLine());

            /*---------------------------------------------------------------------*/

            /*---------------------IF CONDITIONAL------------------------------------*/


            if (_choice == 1)
            {

                DateTime theCurrentTime = DateTime.Now;
                string _dateText = theCurrentTime.ToShortDateString();

                PromptGenerator generator = new PromptGenerator();
                string _prompt = generator.GetRandomPrompt();
                Console.Write($"{_prompt} ");
                string _userEntry = Console.ReadLine();

                Entry _entry = new Entry();
                _entry._promptText = _prompt;
                _entry._entryText = _userEntry;
                _entry._date = _dateText;
                _entry.Display();

                _entries.Add(_entry);


            }

            else if (_choice == 2)
            {
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }
            }


            else if (_choice == 3)
            {

                Console.Write("Input the name of the file please: ");
                string fileName = Console.ReadLine();
                string fileJournal = Path.Combine(folderPath, fileName);


                if (!File.Exists(fileJournal))
                {
                    Console.WriteLine("The fileJournal not exist.");
                    return;
                }

                string[] lines = File.ReadAllLines(fileJournal);
                _entries.Clear();
                foreach (var line in lines)
                {
                    var dates = line.Split(',');
                    if (dates.Length < 3) continue;
                    Entry entry = new Entry();
                    entry._date = dates[0];
                    entry._promptText = dates[1];
                    entry._entryText = dates[2];
                    _entries.Add(entry);
                }
                Console.WriteLine("File succesfully load");

            }
            else if (_choice == 4)
            {
                List<string> finalLines = new List<string>();

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        finalLines.Add(line);
                    }
                }

                foreach (var entry in _entries)
                {
                    string newLine = $"{entry._date},{entry._promptText},{entry._entryText}";

                    if (!finalLines.Contains(newLine))
                    {
                        finalLines.Add(newLine);
                    }
                }

                File.WriteAllLines(filePath, finalLines);

                Console.WriteLine("Entries saved in myJournal.csv.");

            }
            else if (_choice == 5)
            {
                Console.WriteLine("Leaving.....");
                running = false;
            }


            else
            {
                Console.WriteLine("CHOOSE AN OPTION BETWEEN 1 TO 5");
            }
        }

    }

}
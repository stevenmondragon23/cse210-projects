using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Journal
{

    /*------------------PUBLIC VARIABLES-----------*/
    public List<Entry> _entries = new List<Entry>();


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
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int choice  =  int.Parse(Console.ReadLine());

        /*---------------------------------------------------------------------*/

        /*---------------------IF CONDITIONAL------------------------------------*/

        if (choice == 1)
        {
            Console.WriteLine("Seleccionaste la Opción 1");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Seleccionaste la Opción 2");
        }
        else if (choice == 3)
        {
            
            
            Console.WriteLine("Input the name of the file:");
            string archivo = Console.ReadLine();

            if (!File.Exists(archivo))
            {
                Console.WriteLine("File not exist.");
                return;
            }






        }
        else if (choice == 4)
        {
            Console.WriteLine("Seleccionaste la Opción 4");
        }
        else if (choice == 5)
        {
            Console.WriteLine("Seleccionaste la Opción 5");
        }
        else
        {
            Console.WriteLine("Opción no válida. Por favor, ingresa un número entre 1 y 5.");
        }

        /*--------------------------------------------------------------------------------------*/



        /*------------------------ CREATE THE CSV FILE------------------------------------*/
        /*string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "MY JOURNAL");
        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder MY JOURNAL not exist. Creating the folder...");
            Directory.CreateDirectory(folderPath);
        }

        string filePath = Path.Combine(folderPath, "myJournal.csv");*/

        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine("ID,Name,Age");
            writer.WriteLine("1,John Doe,29");
            writer.WriteLine("2,Jane Smith,34");
            writer.WriteLine("3,Bob Johnson,25");
        }

        Console.WriteLine($"MY JOURNAL IS CREATING IN: {filePath}");

        /* ----------------------------------------------------------------------------*/




    }
}
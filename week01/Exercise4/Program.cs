using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberUser = -1;
        while (numberUser != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string numberAnswer = Console.ReadLine();
            numberUser = int.Parse(numberAnswer);
            if (numberUser != 0)
            {
                numbers.Add(numberUser);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


        Console.WriteLine($"The sum is: {sum}");

        //
        //

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }




}
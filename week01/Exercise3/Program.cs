using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userNumberMagic = -1;

        while (magicNumber != userNumberMagic)
        {
            Console.Write("Give me a number: ");
            userNumberMagic = int.Parse(Console.ReadLine());

            if (magicNumber > userNumberMagic)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userNumberMagic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
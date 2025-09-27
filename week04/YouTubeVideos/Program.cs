using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "How make a chocolate Cake!!";
        video1._author = "Pedro Gonzales";
        video1._length = 1;
        video1.AddComent(new Comment("Paola23", "GOOD VIDEO!"));
        video1.AddComent(new Comment("Javier_Prado", "Interesting!"));
        video1.AddComent(new Comment("Jorge34", "Delicious!"));
        videos.Add(video1);



        Video video2 = new Video();
        video2._title = "How fix your car in 10 minutes!";
        video2._author = "CarYoutuber";
        video2._length = 1;
        video2.AddComent(new Comment("Fred_23", "THANKS!!"));
        video2.AddComent(new Comment("Margot_23", "SO HELPFULL!!"));
        video2.AddComent(new Comment("martin23", "I love those tips"));
        videos.Add(video2);

        

        Video video3 = new Video();
        video3._title = "How program with C# so fast!";
        video3._author = "Juan1023";
        video3._length = 1;
        video3.AddComent(new Comment("Luis", "Hello!"));
        video3.AddComent(new Comment("Programer_23", "TOP VIDEO"));
        video3.AddComent(new Comment("Mark23", "SO HELPFULL!!"));
        video3.AddComent(new Comment("Lucas21", "I love those tips"));
        videos.Add(video3);


        Video video4 = new Video();
        video4._title = "How fix your cellphone with rice!!";
        video4._author = "Juan1023";
        video4._length = 1;
        video4.AddComent(new Comment("Jhon", "You save me!"));
        video4.AddComent(new Comment("Elena", "TOP TIPS!"));
        video4.AddComent(new Comment("Mark", "Interesting"));
        videos.Add(video4);


        foreach (var video in videos)
        {
            video.DisplayInfo();
        }


    }
}
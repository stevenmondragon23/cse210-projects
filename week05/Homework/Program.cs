using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mat1 = new MathAssignment();
        mat1.SetStudentName("Pablo");
        mat1.SetTopic("Binomios");
        mat1.SetTextBookSection("Section 9.1");
        mat1.SetProblems("Problems 1-10");
        Console.WriteLine($"{mat1.GetSummary()}");
        Console.WriteLine($"{mat1.GetHomeworkList()}");







        WritingAssignment com1 = new WritingAssignment();
        com1.SetStudentName("Juan");
        com1.SetTopic("Types of Text");
        com1.SetTitle("WORLD WAR II");
        Console.WriteLine($"{com1.GetSummary()}");
        Console.WriteLine($"{com1.GetWritingInformation()}");
    }
}
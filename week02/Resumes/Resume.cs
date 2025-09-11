
using System;
using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _namePerson = "";

    public List<Job> _jobs = new List<Job>();

    public void DisplayList()
    {
        Console.WriteLine($"Name: {_namePerson}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }

}
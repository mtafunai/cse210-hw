
using System;

public class Resume
{
    public string_Name;
    public List<Job>_Jobs = new List<Job>();

    public void Display{}
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");

        foreach (var job in _Jobs)
        {
            job.Display();
        }
    }
}
    

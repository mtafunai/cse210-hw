using System;
using System.Collections.Generic;

class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
}

class Resume
{
    public string _Name;
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        foreach (Job job in _Jobs)
        {
            Console.WriteLine($"  {job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Tech Solutions";   
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Intern";
        job2._company = "Web Innovations";   
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._Name = "Michael Tafunai";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();

    }
}
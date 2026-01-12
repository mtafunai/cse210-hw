using System;

public class Job
{
    public string_jobTitle;
    public string_company;
    public int_startYear;
    public int_endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

using System;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected abstract void PerformActivity();

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready ___");
        ShowSpinner(3);

    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i =  0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i+1) % spinner.Length;
        }
    }
    
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }
}
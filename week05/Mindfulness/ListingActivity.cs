using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?","
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity ()
    : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by listing items. "

    )
    {}

    protected override void PerformActivity()
    {
        Random rand = new();
        Console.WriteLine("\n"+ _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
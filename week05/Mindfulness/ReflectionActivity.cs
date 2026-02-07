using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string>_prompts = new()
    {
        "Think of a time when you stood up fpr someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string>_questions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "what made this time different than others?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    };

    public ReflectionActivity()
    : base(
        "Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience."   
    )  
    {}

    protected override void PerformActivity()
    {
        Random rand = new();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nWhen you have something in mind, press enter.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string _question = _questions[rand.Next(_questions.Count)];
            Console.Write($"\n{_question} ");
            ShowSpinner(5);
        }
            
    }  
}
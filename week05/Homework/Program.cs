using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment simpleAssignment = new Assignment ("Mike Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Joyce Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 2");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}
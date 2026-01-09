using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3 && letter != "F")
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
            Console.WriteLine("Better luck next time! Don't give up");
        }
    }
}
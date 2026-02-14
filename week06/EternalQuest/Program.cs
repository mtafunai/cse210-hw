using System;

using System;
using System.Collections.Generic;
using System.IO;

// EXCEEDING REQUIREMENTS:
// 1. Added a Level System based on total score.
// 2. Displays user title depending on points earned.

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("\n===== Eternal Quest =====");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Title: {GetTitle(score)}");

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goals);
                    break;

                case "2":
                    ListGoals(goals);
                    break;

                case "3":
                    RecordEvent(goals, ref score);
                    break;

                case "4":
                    Save(goals, score);
                    break;

                case "5":
                    Load(goals, ref score);
                    break;

                case "6":
                    return;
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()}");
        }
    }

    static void RecordEvent(List<Goal> goals, ref int score)
    {
        ListGoals(goals);

        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();
        score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    static void Save(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine($"Score|{score}");

            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetSaveString());
            }
        }
    }

    static void Load(List<Goal> goals, ref int score)
    {
        goals.Clear();

        string[] lines = File.ReadAllLines("goals.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "Score")
            {
                score = int.Parse(parts[1]);
            }
            else if (parts[0] == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "EternalGoal")
            {
                goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }
    }

    static string GetTitle(int score)
    {
        if (score >= 5000) return "Eternal Champion";
        if (score >= 2000) return "Covenant Keeper";
        if (score >= 1000) return "Pathfinder";
        return "Beginner";
    }
}

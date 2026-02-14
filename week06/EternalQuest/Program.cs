using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<ChecklistGoals> goals = new List<ChecklistGoals>();
        int score = 0;

        while (true)
        {
            Console.WriteLine($" Score: {score}");
            Console.WriteLine(" 1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6.Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1";

                    break;

                case "2";

                    break;

                case "3";

                    break;
                
                case "4";

                    break;
                
                case "5";

                    break;
                
                case "6";

                    return;
            }
        }
    }
}
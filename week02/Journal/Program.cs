using System;

class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("Hello, World! This is TheJournal Project.");

        Journal journal = new Journal();
        Random random = new Random();

        List<string> prompts = new List<string>()
        {
            "What are you grateful for today?",
            "Describe a challenging moment you faced recently.",
            "What is a goal you want to achieve this month?",
            "Reflect on a happy memory from your childhood.",
            "What is something new you learned today?"
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
            
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == "2")

            {
                journal.DisplayAll();
            }

            else if (choice == "3")

            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "4")


            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "5")

            {
                running = false;
            }

            Console.WriteLine(); 
        }
    }
}

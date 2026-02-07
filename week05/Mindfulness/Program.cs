using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("________");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\nSelect a choice from the menu:");

            choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1";

                    activity = new BreathingActivity();
                    break;
                
                case "2";

                    activity = new ReflectionActivity();
                    break;

                case "3";

                    activity = new ListingActivity();

                case "4";

                    Console.WriteLine("Goodbye!");
                    break;

                default:

                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1500);
                    break;
            }

            activity?.Run();

        }
    }
}
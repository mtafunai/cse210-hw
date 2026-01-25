using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("1 Nephi", 3, 7);

        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall reveal them unto them by the Holy Ghost.");
    

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide words, or type 'quit' to exit.");

        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            break;
        }

        scripture.HideRandomWord();

        if (scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            break;
        }

    }
}
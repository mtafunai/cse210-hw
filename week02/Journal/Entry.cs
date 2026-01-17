public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood; 

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}|{_mood}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|");

        Entry entry = new Entry();
        entry._date = parts[0];
        entry._prompt = parts[1];
        entry._response = parts[2];
        entry._mood = parts[3];

        return entry;
    }
}

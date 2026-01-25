class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(""))
        {
            _words.Add(new Word(word));
        
        }

    }

    public void HideRandomWord()
    {
        int index = _random.Next(_words.Count);
        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        String result = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }
    
}
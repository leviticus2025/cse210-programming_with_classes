using System;
public class Entry
{
    private string _date;
    private string _textPrompt;
    private string _textUserEntry;

    public Entry(string textPrompt, string textUserEntry)
    {
        _date = DateTime.Now.ToShortDateString();
        _textPrompt = textPrompt;
        _textUserEntry = textUserEntry;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_textPrompt}");
        Console.WriteLine($"Response: {_textUserEntry}");
    }
    public string FormatForFile()
    {
        return $"{_date}|{_textPrompt}|{_textUserEntry}";
    }
    public static Entry CreateFromFileLine(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            Entry newEntry = new Entry(parts[1], parts[2]);
            newEntry._date = parts[0];
            return newEntry;
        }
        else
        {
            Console.WriteLine("Warning: Error in file.");
            return null;
        }
    }
}
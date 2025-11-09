public class Reference
{
    private string _book;
    private int _chapter;
    private int _startverse;
    private int? _endverse;

    public Reference(string book, int chapter, int startverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
    }
    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public void DisplayString()
    {
        Console.Write($"{_book} {_chapter}:{_startverse}");
        if (_endverse != null)
            Console.Write($"-{_endverse}");
        Console.WriteLine(" ");
    }
    public static (string, int[]) Parse(string text)
    {
        string[] parts = text.Split(':');
        int n = parts[0].LastIndexOf(' ');
        string book = parts[0][..n];
        int chapter = int.Parse(parts[0][n..]);
        int startverse;
        int endverse;
        if (parts[1].Contains("-"))
        {
            string[] verses = parts[1].Split('-');
            startverse = int.Parse(verses[0]);
            endverse = int.Parse(verses[1]);
        }
        else
        {
            startverse = int.Parse(parts[1]);
            endverse = int.Parse(parts[1]);
        }
        return (book, new int[] { chapter, startverse, endverse });
    }

}
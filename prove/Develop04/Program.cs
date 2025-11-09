using System;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("scriptures.txt");
        Random random = new();
        string line = lines[random.Next(lines.Length)];

        string[] parts = line.Split('|');
        string referenceText = parts[0];
        string scriptureText = parts[1];

        var (book, numbers) = Reference.Parse(referenceText);
        Reference reference = numbers.Length == 2
        ? new Reference(book, numbers[0], numbers[1])
        : new Reference(book, numbers[0], numbers[1], numbers[2]);

        Scripture scripture = new(reference, scriptureText);
        while (true)
        {
            Console.Clear();
            scripture.RenderScripture();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! Great job memorizing!");
                break;
            }
            Console.WriteLine("\nPress ENTER to hide more words or type quit to stop the program.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWords(3);
            
        }
    }
}
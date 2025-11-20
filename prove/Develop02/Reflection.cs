public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself from this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
        : base("Reflection Activity",
               "This activity will help you to look back on times in your life when you have been pushed beyond your comfort zone and how you have become better because of it.\n")
    {
    }

    public void Run()
    {
        Activity.ReflectionCount++;
        StartMessage();
        Console.WriteLine("Read the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you are ready press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine("Ponder on each of the following questions as they relate to this experience.");
        Console.Write("Begin in: ");
        DisplayCountdown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            DisplaySpinner(5);     // pause for thinking
            Console.WriteLine();
        }
        EndMessage();
    }
    private static Random random = new Random();
    private string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    // private string GetRandomPrompt()
    // {
    //     Random rand = new Random();
    //     int index = rand.Next(_prompts.Count);
    //     return _prompts[index];
    // }
    // private string GetRandomQuestion()
    // {
    //     Random rand = new Random();
    //     int index = rand.Next(_questions.Count);
    //     return _questions[index];
    // }
}

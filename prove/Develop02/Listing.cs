public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing()
        : base("Listing Activity",
               "This activity will help jog your memory on good things that have been present in your life. You will list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        Activity.ListingCount++;
        StartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        EndMessage();
    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}

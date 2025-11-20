public class Activity
{
    public string _name;
    public string _description;
    public int _duration;
    public static int BreathingCount = 0;
    public static int ReflectionCount = 0;
    public static int ListingCount = 0;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine($"Enter the activity duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }
    public void EndMessage()
    {
        Console.WriteLine($"Great job! You completed {_duration} seconds of the {_name}!");
    }
    public void DisplaySpinner(int seconds)
    {
        List<string> frames = new List<string>() { "|", "/", "-", "\\" };
        int frameIndex = 0;
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write(frames[frameIndex]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            frameIndex = (frameIndex + 1) % frames.Count;
        }
    }

    public void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
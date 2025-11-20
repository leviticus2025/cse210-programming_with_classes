public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", 
    "This activity will allow you to slow down and focus on your breathing in and out. Focus on nothing but your breathing.")
    {
    }
    public void Run()
    {
        Activity.BreathingCount++;
        StartMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            DisplayCountdown(5);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            DisplayCountdown(5);
            Console.WriteLine();

            elapsed += 10;  // 4 + 6 seconds
        }

        EndMessage();
    }
}
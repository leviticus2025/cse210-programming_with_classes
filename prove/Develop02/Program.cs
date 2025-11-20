using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing();
                    breathing.Run();
                    break;
                case "2":
                    Reflection reflection = new Reflection();
                    reflection.Run();
                    break;
                case "3":
                    Listing listing = new Listing();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("\n--- Activity Log ---");
                    Console.WriteLine($"Breathing Activity: {Activity.BreathingCount} times");
                    Console.WriteLine($"Reflection Activity: {Activity.ReflectionCount} times");
                    Console.WriteLine($"Listing Activity: {Activity.ListingCount} times\n");
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Thank you for participating!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
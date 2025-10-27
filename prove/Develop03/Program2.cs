using System;

class Program2
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Prompt promptGenerator = new Prompt();
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following choices!");
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What do you want to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry(prompt, response);
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        } 
    }
}
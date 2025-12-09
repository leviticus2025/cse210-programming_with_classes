using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _score = 0;
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }
    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int pts = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, pts));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, desc, pts));
        }
        else
        {
            Console.Write("How many times must it be completed? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
    }
    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
            i++;
        }
    }
    static void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoals();

        Console.Write("Enter the number: ");
        int index = int.Parse(Console.ReadLine());

        Goal g = _goals[index - 1];
        int pointsEarned = g.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
    }
    static void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    static void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int pts = int.Parse(parts[3]);
            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, desc, pts, complete));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, desc, pts));
            }
            else
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int current = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus, current));
            }
        }
    }
}
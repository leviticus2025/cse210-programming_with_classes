using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        int birth_year;
        PromptUserBirthYear(out birth_year);
        DisplayResult(userName, squaredNumber, birth_year);
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static void PromptUserBirthYear(out int birth_year)
        {
            Console.Write("Enter your birth year: ");
            birth_year = int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            int number_squared = number * number;
            return number_squared;
        }
        static void DisplayResult(string name, int number_squared, int birth_year)
        {
            Console.WriteLine($"{name}, the square of your number is {number_squared}.");
            Console.WriteLine($"{name}, you will be {2025 - birth_year} years old this year.");
        }
    }
}
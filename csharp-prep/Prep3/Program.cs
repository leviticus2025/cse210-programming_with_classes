using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");

        string play_again = "yes";
        while (play_again == "yes")
        {
            Random randomGenerator = new Random(); // random number
            int magic_number = randomGenerator.Next(1, 100); 
            int guess = -11;
            int count = 0;
            while (guess != magic_number)
            {
                Console.WriteLine("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
                if (guess < magic_number)
                {
                    Console.WriteLine("higher");
                }
                else if (guess > magic_number)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
            Console.WriteLine($"You guessed {count} times");
            Console.WriteLine("Play again? (yes/no)");
            play_again = Console.ReadLine();
        }
    }
}

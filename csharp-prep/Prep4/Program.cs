using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter a list of numbers: type 0 when done!");
        int input = 1;
        List<int> numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int max = 0;
        while (input != 0)
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input); //to not add the ending 0
            }
        }
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The maximum is {max}");
        }
}
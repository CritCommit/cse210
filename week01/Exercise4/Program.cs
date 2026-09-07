using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        do
        {
            Console.Write("Enter a number (0 will end): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int total = 0;

        foreach (int s in numbers)
        {
            total += s;
        }
        Console.WriteLine($"Total: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is {max}");
    }
}

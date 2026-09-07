using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        Console.WriteLine($"Hello {name}!");

        int number = PromptUserNumber();
        Console.WriteLine($"Your favorite number is {number}");

        int squareNumber = SquareNumber(number);
        Console.WriteLine($"Your number squared is {squareNumber}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
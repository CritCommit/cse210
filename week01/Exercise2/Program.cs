using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("");

        Console.Write("What is your grade percentage? ");

        int gradePercentage;

        while (!int.TryParse(Console.ReadLine(), out gradePercentage))
        {
            Console.Write("Invalid input. Please enter a valid grade percentage: ");
        }

        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int lastDigit = gradePercentage % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 2)
        {
            sign = "-";
        }

        if (letterGrade == "A" && (sign == "+" || gradePercentage == 100))
        {
            sign = "";
        }
        else if (letterGrade == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}
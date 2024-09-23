using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string letter = "";

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80) 
        {
            letter = "B";
        }
        else if (grade >= 70) 
        {
            letter = "C";
        }
        else if (grade >= 60) 
        {
            letter = "D";
        }
        else {
            letter = "E";
        }

        Console.WriteLine($"You've got {letter}");

        if (grade >= 70) {
            Console.WriteLine("Congratulations, You passed the course!");
        }
        else {
            Console.WriteLine("Sorry, but you didn't pass the course this time!");
        }
    }
}
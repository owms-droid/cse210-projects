using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magic)
        {
            Console.WriteLine("Tell me your guess: ");
            string response2 = Console.ReadLine();
            guess = int.Parse(response2);

            if (guess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}
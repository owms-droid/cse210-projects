public class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity(ActivityTracker tracker) : base(tracker)
    {
        Name = "Reflection";
        Description = "This activity helps you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);

        for (int i = 0; i < Duration / 5; i++)
        {
            string question = Questions[random.Next(Questions.Length)];
            Console.WriteLine(question);
            PauseWithAnimation(5);
        }
    }
}
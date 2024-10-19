public class BreathingActivity : Activity
{
    public BreathingActivity(ActivityTracker tracker) : base(tracker)
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    protected override void RunActivity()
    {
        for (int i = 0; i < Duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }
    }
}
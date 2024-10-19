public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }  // in seconds
    private ActivityTracker tracker;

    public Activity(ActivityTracker tracker)
    {
        this.tracker = tracker;
    }

    public void StartActivity()
    {
        ShowStartMessage();
        SetDuration();
        PrepareToStart();
        RunActivity();
        ShowFinishMessage();
        tracker.AddTime(Name, Duration);  // Report time spent to tracker
    }

    protected virtual void ShowStartMessage()
    {
        Console.WriteLine($"Starting {Name}: {Description}");
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareToStart()
    {
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);  // Pause for 3 seconds
    }

    protected void ShowFinishMessage()
    {
        Console.WriteLine($"Good job! You completed the {Name} activity for {Duration} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void RunActivity();
}

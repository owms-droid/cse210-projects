public class ActivityTracker
{
    private int totalBreathingTime;
    private int totalReflectionTime;
    private int totalListingTime;

    public void AddTime(string activityType, int time)
    {
        switch (activityType)
        {
            case "Breathing":
                totalBreathingTime += time;
                break;
            case "Reflection":
                totalReflectionTime += time;
                break;
            case "Listing":
                totalListingTime += time;
                break;
        }
    }

    public void ShowTotalTime()
    {
        Console.WriteLine($"\nTotal time spent on activities:");
        Console.WriteLine($"- Breathing: {totalBreathingTime} seconds");
        Console.WriteLine($"- Reflection: {totalReflectionTime} seconds");
        Console.WriteLine($"- Listing: {totalListingTime} seconds\n");
    }
}

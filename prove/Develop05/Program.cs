using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityTracker tracker = new ActivityTracker();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show total time spent on activities");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(tracker);
                    break;
                case "2":
                    activity = new ReflectionActivity(tracker);
                    break;
                case "3":
                    activity = new ListingActivity(tracker);
                    break;
                case "4":
                    tracker.ShowTotalTime();
                    continue;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            activity.StartActivity();
        }
    }
}

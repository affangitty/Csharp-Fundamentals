using System;

class Program
{
    static void Main()
    {
        Counter counter = new Counter(5);

        // Subscribe multiple handlers
        counter.OnThresholdReached += NotifyUser;
        counter.OnThresholdReached += LogEvent;

        for (int i = 0; i < 10; i++)
        {
            counter.Increment();
        }
    }

    // Event handler 1
    static void NotifyUser(int value)
    {
        Console.WriteLine($"[ALERT] Threshold reached at {value}");
    }

    // Event handler 2
    static void LogEvent(int value)
    {
        Console.WriteLine($"[LOG] Counter hit {value}");
    }
}
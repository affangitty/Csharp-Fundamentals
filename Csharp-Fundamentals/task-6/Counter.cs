using System;

public class Counter
{
    private int value = 0;
    private int threshold;

    // Delegate
    public delegate void ThresholdReachedHandler(int value);

    // Event
    public event ThresholdReachedHandler OnThresholdReached;

    public Counter(int threshold)
    {
        this.threshold = threshold;
    }

    public void Increment()
    {
        value++;
        Console.WriteLine($"Counter: {value}");

        if (value == threshold)
        {
            // Raise event
            OnThresholdReached?.Invoke(value);
        }
    }
}
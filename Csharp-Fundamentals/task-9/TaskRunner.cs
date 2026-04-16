using System;

public class TaskRunner
{
    [Runnable]
    public void Task1()
    {
        Console.WriteLine("Running Task 1");
    }

    [Runnable]
    public void Task2()
    {
        Console.WriteLine("Running Task 2");
    }

    public void NotRunnable()
    {
        Console.WriteLine("This should NOT run");
    }
}
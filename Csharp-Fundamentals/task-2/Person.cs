using System;

public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}
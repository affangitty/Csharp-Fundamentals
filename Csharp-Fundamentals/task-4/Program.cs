using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Affan", Grade = 85, Age = 22 },
            new Student { Name = "Rahul", Grade = 70, Age = 21 },
            new Student { Name = "Sara", Grade = 90, Age = 23 },
            new Student { Name = "Aman", Grade = 60, Age = 20 }
        };

        Console.Write("Enter minimum grade: ");
        int threshold = int.Parse(Console.ReadLine());

        // LINQ: Filter + Sort
        var result = students
            .Where(s => s.Grade > threshold)
            .OrderBy(s => s.Name);

        Console.WriteLine("\nFiltered Students:");

        foreach (var s in result)
        {
            Console.WriteLine($"{s.Name} - Grade: {s.Grade}, Age: {s.Age}");
        }
    }
}
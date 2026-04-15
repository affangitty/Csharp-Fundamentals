using System;

class Program
{
    static void Main()
    {
        // Creating objects
        Person p1 = new Person { Name = "Affan", Age = 22 };
        Person p2 = new Person { Name = "Rahul", Age = 25 };
        Person p3 = new Person { Name = "Sara", Age = 20 };

        // Calling methods
        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
    }
}
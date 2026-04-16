using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.WriteLine("Discovering runnable methods...\n");

        var assembly = Assembly.GetExecutingAssembly();

        foreach (var type in assembly.GetTypes())
        {
            foreach (var method in type.GetMethods())
            {
                // Check if method has [Runnable]
                if (method.GetCustomAttribute(typeof(RunnableAttribute)) != null)
                {
                    Console.WriteLine($"Executing: {method.Name}");

                    // Create instance of class
                    var instance = Activator.CreateInstance(type);

                    // Invoke method
                    method.Invoke(instance, null);
                }
            }
        }
    }
}
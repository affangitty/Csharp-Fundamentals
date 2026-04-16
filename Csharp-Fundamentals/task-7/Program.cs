using System;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static async Task Main()
    {
        try
        {
            Console.WriteLine("Fetching data from multiple sources...\n");

            // Start tasks concurrently
            Task<string> task1 = FetchDataAsync("Source 1", 2000);
            Task<string> task2 = FetchDataAsync("Source 2", 3000);
            Task<string> task3 = FetchDataAsync("Source 3", 1500);

            // Wait for all to complete
            string[] results = await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("\n--- Results ---");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static async Task<string> FetchDataAsync(string source, int delay)
    {
        Console.WriteLine($"{source} started...");

        await Task.Delay(delay); // simulate API call

        // Simulate random failure
        var r = new Random().Next(0, 5);
        if (r == 1)
        {
            throw new Exception($"{source} failed!");
        }

        Console.WriteLine($"{source} completed");

        return $"{source} data received";
    }
}
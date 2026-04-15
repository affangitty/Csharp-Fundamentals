using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Display items");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    AddItem(items);
                    break;

                case "2":
                    RemoveItem(items);
                    break;

                case "3":
                    DisplayItems(items);
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddItem(List<string> items)
    {
        Console.Write("Enter item: ");
        string input = Console.ReadLine()?.Trim();

        if (!string.IsNullOrEmpty(input))
        {
            items.Add(input);
            Console.WriteLine("Item added.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static void RemoveItem(List<string> items)
    {
        Console.Write("Enter item to remove: ");
        string input = Console.ReadLine()?.Trim();

        if (items.Remove(input))
        {
            Console.WriteLine("Item removed.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    static void DisplayItems(List<string> items)
    {
        Console.WriteLine("\n--- ITEMS ---");

        if (items.Count == 0)
        {
            Console.WriteLine("No items found.");
            return;
        }

        foreach (var item in items)
        {
            Console.WriteLine(item.ToUpper());
        }
    }
}
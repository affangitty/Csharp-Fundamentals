using System;

class Program
{
    static void Main()
    {
        IRepository<Product> repo = new Repository<Product>();

        // Add products
        repo.Add(new Product { Id = 1, Name = "Laptop", Price = 50000 });
        repo.Add(new Product { Id = 2, Name = "Phone", Price = 20000 });

        // Display all
        Console.WriteLine("All Products:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
        }

        // Get by ID
        var product = repo.GetById(1);
        Console.WriteLine($"\nFound: {product?.Name}");

        // Update
        repo.Update(1, new Product { Id = 1, Name = "Gaming Laptop", Price = 80000 });

        // Delete
        repo.Delete(2);

        Console.WriteLine("\nAfter Update/Delete:");
        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
        }
    }
}
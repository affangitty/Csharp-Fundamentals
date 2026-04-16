using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";

        try
        {
            // Read file
            string[] lines = File.ReadAllLines(inputPath);

            int lineCount = lines.Length;
            int wordCount = 0;

            foreach (var line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }

            // Prepare result
            string result = $"Lines: {lineCount}\nWords: {wordCount}";

            // Write to output file
            File.WriteAllText(outputPath, result);

            Console.WriteLine("Processing complete. Check output.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Input file not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
}
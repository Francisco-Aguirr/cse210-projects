// For exeeding requirements, I added a time limit to memorize the scripture.
// The program will display a random scripture and hide a few words at a time.
using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.")
        };

        // Select a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Set the time limit (e.g., 2 minute)
        TimeSpan timeLimit = TimeSpan.FromMinutes(2);
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Display the remaining time
            TimeSpan remainingTime = timeLimit - stopwatch.Elapsed;
            if (remainingTime.TotalSeconds > 0)
            {
                Console.WriteLine($"\nTime remaining: {remainingTime:mm\\:ss}");
            }
            else
            {
                Console.WriteLine("\nTime's up!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            // End the program if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nCongratulations! You memorized the scripture within the time limit.");
                break;
            }
        }

        stopwatch.Stop();
    }
}
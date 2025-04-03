using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class GratitudeActivity : MindfulnessActivity
    {
        private readonly List<string> _gratitudePrompts = new List<string>
        {
            "What small things are you grateful for today?",
            "Who has helped you recently that you're thankful for?",
            "What abilities or talents are you grateful to have?",
            "What beautiful things have you seen recently?",
            "What comforts are you grateful to have in your life?"
        };

        public GratitudeActivity()
        {
            Name = "Gratitude";
            Description = "This activity will help you cultivate gratitude by focusing on " +
                          "the positive aspects of your life and appreciating them fully.";
        }

        public override void PerformActivity()
        {
            StartActivity();
            
            Random random = new Random();
            string prompt = _gratitudePrompts[random.Next(_gratitudePrompts.Count)];
            
            Console.WriteLine("Focus on the following gratitude prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("Take a moment to feel genuine appreciation for each item you list.");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();
            
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            List<string> items = new List<string>();
            
            while (DateTime.Now < endTime)
            {
                Console.Write("I'm grateful for: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                    Console.WriteLine("Take a moment to feel gratitude for this...");
                    ShowSpinner(2);
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"You expressed gratitude for {items.Count} things!");
            Console.WriteLine("Take a final moment to appreciate all of these:");
            ShowSpinner(5);
            
            EndActivity();
        }
    }
}
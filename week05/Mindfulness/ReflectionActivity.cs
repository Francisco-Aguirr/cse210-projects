using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private readonly List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
        {
            Name = "Reflection";
            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                          "This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        public override void PerformActivity()
        {
            StartActivity();
            
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();
            
            Console.WriteLine("Now reflect on the following questions related to this experience.");
            Console.WriteLine("You may begin in:");
            ShowCountdown(5);
            
            Console.WriteLine();
            
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string question = _questions[random.Next(_questions.Count)];
                Console.WriteLine(question);
                ShowSpinner(5);
            }
            
            EndActivity();
        }
    }
}
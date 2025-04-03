using System;
using System.Threading;

namespace Mindfulness
{
    public abstract class MindfulnessActivity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; private set; }

        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"Activity: {Name}");
            Console.WriteLine();
            Console.WriteLine(Description);
            Console.WriteLine();
            
            SetDuration();
            
            Console.WriteLine();
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void EndActivity()
        {
            Console.WriteLine();
            Console.WriteLine("Good job!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            ShowSpinner(3);
        }

        private void SetDuration()
        {
            int duration;
            Console.Write("How many seconds would you like to spend on this activity? ");
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.Write("Please enter a valid number of seconds: ");
            }
            Duration = duration;
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.Write("  \b\b");
        }

        public abstract void PerformActivity();
    }
}
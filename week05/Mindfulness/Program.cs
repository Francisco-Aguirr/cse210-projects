// for showing creativity and exeeding rerquirements I have added a new activity
using Mindfulness;
using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities Menu");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Gratitude Activity (New!)");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an activity: ");
                
                string choice = Console.ReadLine();
                
                MindfulnessActivity activity = null;
                
                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        activity = new GratitudeActivity();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Thread.Sleep(1500);
                        continue;
                }
                
                activity.PerformActivity();
            }
        }
    }
}
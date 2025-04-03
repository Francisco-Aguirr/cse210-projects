using System;

namespace Mindfulness
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
        {
            Name = "Breathing";
            Description = "This activity will help you relax by walking you through breathing in and out slowly. " +
                          "Clear your mind and focus on your breathing.";
        }

        public override void PerformActivity()
        {
            StartActivity();
            
            Console.WriteLine();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);
                
                if (DateTime.Now >= endTime) break;
                
                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
            }
            
            EndActivity();
        }
    }
}
using System;
// to exeed requirements I have added a leveloing up sistem
// Every 1000 points, the program displays a “⭐ LEVEL UP!” message.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

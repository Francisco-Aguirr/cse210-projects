using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);

        if (grade >= 90)
        {
            Console.WriteLine("Congrats! you grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Good job! your grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You can do it better! your grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Sorry, You have to focuse next term. Your grade is: D");
        }
        else
        {
            Console.WriteLine("Try your best next term. Your grade is: F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class.");
        }
    }
}
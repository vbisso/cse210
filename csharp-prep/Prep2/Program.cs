using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage % 10 >= 7 && percentage < 97 && percentage >= 60)
        {
            sign = "+";
        }
        else if (percentage % 10 < 3 && percentage >= 60)
        {
            sign = "-";
        }


        Console.WriteLine($"Your letter grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations. You passed the course");
        }
        else
        {
            Console.WriteLine("I'm sorry you did not pass the course. Try harder next time.");
        }

    }
}
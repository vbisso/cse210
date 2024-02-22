using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(newAssignment.GetSummary());

        MathAssignment newMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.1", "Problems 1-5");
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(newMathAssignment.GetHomeworkList());

        WritingAssignment newWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newWritingAssignment.GetSummary());
        Console.WriteLine(newWritingAssignment.GetWritingInformation());
    }
}
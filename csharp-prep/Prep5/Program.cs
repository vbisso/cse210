using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int sqnumber = SquareNumber(number);

        DisplayResult(username, sqnumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int num)
    {
        int squaredNum = num * num;
        return squaredNum;
    }

    static void DisplayResult(string username, int number)
    {
        Console.WriteLine($"{username}, the square of your number is {number}.");
    }
}
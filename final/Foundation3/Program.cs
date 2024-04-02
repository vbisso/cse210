using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("\u001b[1m" + "FOUNDATION 3:\n");

        Console.WriteLine("Lecture Event:\n");
        Lecture lecture = new Lecture("Lecture", "Introduction to Quantum Mechanics", "An introductory lecture covering the basic principles and concepts of quantum mechanics.", "April 15th, 2024", "9:00 am - 11:00 am ", new Address("123 Main St", "Rexburg", "ID", "USA"), "Dr. Stephen Hawking", 100);
        Console.Write("\u001b[0m");
        Console.WriteLine("\u001b[4m"+"Standard Details:");
        Console.Write("\u001b[0m");
        lecture.DisplayStandardDetails();
        Console.WriteLine("\u001b[4m"+"\nFull Details:");
        Console.Write("\u001b[0m");
        lecture.DisplayFullEvent();
        Console.WriteLine("\u001b[4m"+"\nShort Description:");
        Console.Write("\u001b[0m");
        lecture.DisplayShortDescription();

        Console.WriteLine("\n---------------------------------------------------------------------");

        Console.WriteLine("\u001b[1m"+"\nReception Event:\n");
        Console.Write("\u001b[0m");
        Reception reception = new Reception("Reception", "Annual Company Reception",  "Join us for an evening of networking, refreshments, and celebration of our company's achievements over the past year.", "June 2nd, 2024", "6:30 pm - 23:00 pm", new Address("789 Broadway Ave", "NYC", "NY", "USA"), "company_reception@gmail.com");
        Console.WriteLine("\u001b[4m"+"Standard Details:");
        Console.Write("\u001b[0m");
        reception.DisplayStandardDetails();
        Console.WriteLine("\u001b[4m"+"\nFull Details:");
        Console.Write("\u001b[0m");
        reception.DisplayFullEvent();
        Console.WriteLine("\u001b[4m"+"\nShort Description:");
        Console.Write("\u001b[0m");
        reception.DisplayShortDescription();

        Console.WriteLine("\n---------------------------------------------------------------------");

        Console.WriteLine("\u001b[1m"+"\nOutdoor Event:\n");
        Console.Write("\u001b[0m");
        Outdoor outdoor = new Outdoor("Outdoor", "Summer Music Festival","An outdoor festival featuring live music, food trucks, and activities for all ages.", "August 4th, 2024", "11:30 am - 6:00 pm", new Address("500 Ocean Dr", "Miami Beach", "FL", "USA"), "Sunny with a chance of afternoon showers");
        Console.WriteLine("\u001b[4m"+"Standard Details:");
        Console.Write("\u001b[0m");
        outdoor.DisplayStandardDetails();
        Console.WriteLine("\u001b[4m"+"\nFull Details:");
        Console.Write("\u001b[0m");
        outdoor.DisplayFullEvent();
        Console.WriteLine("\u001b[4m"+"\nShort Description:");
        Console.Write("\u001b[0m");
        outdoor.DisplayShortDescription();



    }
}
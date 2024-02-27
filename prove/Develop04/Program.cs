using System;
using Develop04;


class Program
{
    static void Main(string[] args)
    {
        int userMenu = 0;

        while (userMenu != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness Program\n");
            Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listing Activity\n4. Quit");
            Console.Write("Select choice from the menu:");
            userMenu = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenu)
            {
                case 1:
                    string name1 = "Breathing Activity";
                    string description1 = "This activity will help you relax by guiding you through breathing slowly. Clear your mind and focus on your breathing.";

                    Activity activity1 = new Activity(name1, description1, 0);
                    Console.WriteLine(activity1.DisplayStartingMessage());

                    Console.Write("\nHow long, in seconds, would you like for your session?");
                    int userTime = int.Parse(Console.ReadLine());
                    activity1.SetAcitivityDuration(userTime);
                    Breathing breathing = new Breathing(name1, description1, userTime);

                    Console.Clear();
                    activity1.DisplayGetReady();
                    breathing.DisplayBreathingIntervals();
                    activity1.DisplayEndMessage();
                    Console.Clear();

                    break;


                case 2:

                    string name2 = "Reflection Activity";
                    string description2 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    List<string> reflectingPrompts = new List<string>(){
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                    };
                    List<string> questions = new List<string>(){
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


                    Activity activity2 = new Activity(name2, description2, 0);
                    Console.WriteLine(activity2.DisplayStartingMessage());

                    Console.Write("\nHow long, in seconds, would you like for your session?");
                    userTime = int.Parse(Console.ReadLine());
                    activity2.SetAcitivityDuration(userTime);
                    Reflection reflection = new Reflection(name2, description2, userTime, reflectingPrompts, questions);


                    Console.Clear();

                    activity2.DisplayGetReady();
                    reflection.DisplayPrompt();
                    Console.Clear();
                    reflection.DisplayQuestion();
                    activity2.DisplayEndMessage();
                    Console.Clear();

                    break;

                case 3:

                    string name3 = "Listing Activity";
                    string description3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    List<string> listingPrompts = new List<string>(){
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                    };
                   

                    Activity activity3 = new Activity(name3, description3, 0);
                    Console.WriteLine(activity3.DisplayStartingMessage());

                    Console.Write("\nHow long, in seconds, would you like for your session?");
                    userTime = int.Parse(Console.ReadLine());
                    activity3.SetAcitivityDuration(userTime);

                    Listing listing = new Listing(name3, description3, userTime, listingPrompts);
                    
                    Console.Clear();
                    activity3.DisplayGetReady();
                    listing.DisplayPrompt();
                    listing.ListItems();
                    activity3.DisplayEndMessage();
                    Console.Clear();
                    
                    break;




            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Scripture Memorizer\nSelect the scripture to memorize:");
        Console.WriteLine("0. John 3:16-18\n1. Proverbs 3:5-6 \n2. Ether 12:27\n3. 3 Nephi 11:37\n4. Jeremiah 29:11\n5. Philippians 4:6");
        int user = int.Parse(Console.ReadLine());

        List<string> scriptureList = new List<string>(){
            "At the time of Jesus, the people ate meals on the ground, leaning on their elbow or on a pillow of some kind with their feet away from the table. It was customary to lean on the left side so one could eat with the right hand. So whoever was on the right side of Jesus would only have had to lean back to have his head on Jesus’ breast.",
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.",
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.",
            "And again, I say unto you, ye must repent, and become as a little child, and be baptized in my name, or ye can in nowise receive these things.",
            "For I know the plans I have for you, declares the Lord, plans for welfare and not for evil, to give you a future and a hope." ,
            "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God."
        };

        Reference newReference = null;
        Scripture scripture = null;


        switch (user)
        {
            case 0:
                newReference = new Reference("John", 3, 16, 18);
                scripture = new Scripture("At the time of Jesus, the people ate meals on the ground, leaning on their elbow or on a pillow of some kind with their feet away from the table. It was customary to lean on the left side so one could eat with the right hand. So whoever was on the right side of Jesus would only have had to lean back to have his head on Jesus’ breast.", newReference);
                break;
            case 1:
                newReference = new Reference("Proverbs", 3, 5, 6);
                scripture = new Scripture("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.", newReference);
                break;
            case 2:
                newReference = new Reference("Ether", 12, 27, 27);
                scripture = new Scripture("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.", newReference);
                break;
            case 3:
                newReference = new Reference("3 Nephi", 11, 37, 37);
                scripture = new Scripture("And again, I say unto you, ye must repent, and become as a little child, and be baptized in my name, or ye can in nowise receive these things.", newReference);
                break;
            case 4:
                newReference = new Reference("Jeremiah", 29, 11, 11);
                scripture = new Scripture("For I know the plans I have for you, declares the Lord, plans for welfare and not for evil, to give you a future and a hope.", newReference);
                break;
            case 5:
                newReference = new Reference("Philippians", 4, 6, 6);
                scripture = new Scripture("Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God.", newReference);
                break;
        }


        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetRenderedText()}");
            Console.WriteLine("\nPress 'Enter' to hide a word, or type 'quit' to exit");
            string userInput = Console.ReadLine().ToLower();

            scripture.HideWord();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine($"Scripture: {scripture.GetRenderedText()}");
            }


            if (userInput == "quit")
            {
                return;
            }
        }
    }
}
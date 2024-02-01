using System;
using System.Reflection.Metadata;
using System.IO;
using Develop02;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {
        //list and variables
        int user = 0;
        List<string> prompts = new List<string>(){
            //I added more prompts to the list
            "What's a recent challenge you faced, and how did you handle it?",
            "List three goals for the next month",
            "Share a recent impactful book, movie, or artwork",
            "Name three things you're grateful for today",
            "Recall a childhood moment that still influences you",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today; what would it be?"
        };
        Entry entry = null;//declaring the instance of Entry outside the loop so I can call it back later in any if statement
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (user != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do?: ");
            user = int.Parse(Console.ReadLine());

            switch (user){

                //WRITE
                case 1:

                DateTime date = DateTime.Now;
                Random randomPrompt = new Random();
                int randomIndex = randomPrompt.Next(prompts.Count);
                Console.WriteLine(prompts[randomIndex]);
                Console.Write(">");
                string userEntry = Console.ReadLine();

                entry = new Entry();
                entry._prompt = prompts[randomIndex];
                entry._date = date.ToShortDateString();
                entry._input = userEntry;

                journal._entries.Add(entry);

                break;
            

                //DISPLAY
                case 2:
            
                journal.DisplayJournal();
                break;
            

                //LOAD
                case 3:
                //only loads from csv
                Console.WriteLine("What is the filename (only csv files accepted)? ");
                string filenameLoad = Console.ReadLine();

                //ensures the filename ends with ".csv"
                 if (!filenameLoad.ToLower().EndsWith(".csv")){
                    filenameLoad += ".csv";
                }
                //reads all the lines in the csv file
                string [] lines = System.IO.File.ReadAllLines(filenameLoad);
                foreach (string line in lines){
                    //iterates and splits through all the lines of the file until "," appears
                    string[] parts = line.Split(",");
                    Entry entryLoad = new Entry();
                    entryLoad._date = parts[0];
                    entryLoad._prompt = parts[1];
                    entryLoad._input = parts[2];
                    journal._entries.Add(entryLoad);
                }
                
                break;

            
                //SAVE
                case 4:
                //only saves to csv
                Console.WriteLine("The document will be saved as a csv. What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveCsv(filename);

                break;

            }//end of switch

        }//end of while

    }//end of main
    


}//program

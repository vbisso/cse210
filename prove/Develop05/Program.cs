using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void SaveFile(List<Goal> list, int points)
    {
        Console.Write("What is the filename for your goal file (only .txt)? : ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(points);

            foreach (Goal goal in list)
            {
                outputFile.WriteLine(goal.StringFormat());
            }
        }
        Console.WriteLine("File saved successfully!");
    }
    static void Main(string[] args)
    {
        int points = 0;
        int user = 0;
        bool isFileSaved = false;
        List<Goal> GoalList = new List<Goal>();


        while (user != 6)
        {
            if (GoalList.Count > 0)
            {
                points = GoalList[0].GetListTotalPoint();
            }


            Console.WriteLine("\nWelcome to the Eternal Quest Program!\n");
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            user = int.Parse(Console.ReadLine());

            switch (user)
            {
                case 1:
                    Console.WriteLine("\nThe following types of goals are available:");
                    Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n");
                    Console.Write("Which type of goal would you like to create?");
                    int type = int.Parse(Console.ReadLine());
                    switch (type)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal("Simple Goal", "", "", 0, false);
                            simpleGoal.CreateNewGoal();
                            GoalList.Add(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal("Eternal Goal", "", "", 0);
                            eternalGoal.CreateNewGoal();
                            GoalList.Add(eternalGoal);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal", "", "", 0, 0, 0, 0);
                            checklistGoal.CreateNewGoal();
                            GoalList.Add(checklistGoal);
                            break;

                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\nThe goals are:");

                    for (int i = 0; i < GoalList.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        if (GoalList[i] is SimpleGoal || GoalList[i] is EternalGoal)
                        {
                            GoalList[i].ListGoals(GoalList[i]);
                        }
                        else if (GoalList[i] is ChecklistGoal checklistGoal)
                        {
                            checklistGoal.ListGoals(GoalList[i]);
                        }

                    }
                    break;

                case 3:
                    SaveFile(GoalList, points);
                    isFileSaved = true;
                    break;

                case 4:
                    Console.Write("What is the filename for the goal file? (only .txt)? ");
                    string fileNameLoad = Console.ReadLine();

                    if (File.Exists(fileNameLoad))
                    {
                        GoalList.Clear();

                        using (StreamReader inputFile = new StreamReader(fileNameLoad))
                        {
                            int totalPoints = int.Parse(inputFile.ReadLine());


                            string line;
                            while ((line = inputFile.ReadLine()) != null)
                            {
                                string[] parts = line.Split(':');
                                string goalType = parts[0];

                                string[] goalDetails = parts[1].Split(',');
                                string name = goalDetails[0];
                                string description = goalDetails[1];
                                int tpoints = int.Parse(goalDetails[2]);


                                Goal goal;
                                if (goalType == "Simple Goal")
                                {
                                    bool isCompleted = bool.Parse(goalDetails[3]);
                                    goal = new SimpleGoal(goalType, name, description, tpoints, isCompleted);
                                    if (isCompleted)
                                    {
                                        goal.SetStatus();
                                    }

                                }
                                else if (goalType == "Eternal Goal")
                                {
                                    goal = new EternalGoal(goalType, name, description, tpoints);

                                }
                                else if (goalType == "Checklist Goal")
                                {
                                    int numToAccomplish = int.Parse(goalDetails[4]);
                                    int accomplishBonus = int.Parse(goalDetails[3]);
                                    int currentlyAccomplished = int.Parse(goalDetails[5]);
                                    goal = new ChecklistGoal(goalType, name, description, tpoints, numToAccomplish, currentlyAccomplished, accomplishBonus);
                                    if (numToAccomplish == currentlyAccomplished)
                                    {
                                        goal.SetStatus();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid goal type: {goalType}");
                                    continue;
                                }

                                GoalList.Add(goal);
                                goal.SetListTotalPoints(totalPoints);

                            }





                        }
                        Console.WriteLine("Goals loaded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;

                case 5:
                    Console.WriteLine("The goals are:");
                    for (int i = 0; i < GoalList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {GoalList[i].getGoalName()}");
                    }
                    Console.Write("\nWhich goal would you like to record an event for? ");
                    int goalIndex = int.Parse(Console.ReadLine());

                    if (GoalList[goalIndex - 1] is SimpleGoal sg)
                    {
                        sg.RecordEvent(GoalList);
                    }
                    else if (GoalList[goalIndex - 1] is EternalGoal eg)
                    {
                        eg.RecordEvent(GoalList);
                    }
                    else if (GoalList[goalIndex - 1] is ChecklistGoal cg)
                    {
                        cg.RecordEvent(GoalList);
                    }
                    break;



            }

            if (user == 6)
            {
                if (!isFileSaved)
                {
                    Console.Write("Do you want to exit without saving? (yes/no): ");
                    string response = Console.ReadLine().ToLower();

                    if (response == "yes")
                    {
                        Console.WriteLine("Exiting without saving...");
                        return;
                    }
                    else if (response == "no")
                    {
                        SaveFile(GoalList, points);
                        isFileSaved = true;
                        break;
                    }

                }
            }
        }

    }
}

using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Arquitect";
        job2._startYear = 2022;
        job2._endYear = 2025;

        //job1.DisplayJob();
        //job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Valeria Bisso";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2); 

        myResume.DisplayResume();

       



    }
}
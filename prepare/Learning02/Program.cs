using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Webpage Designer Manager";
        job1._startYear = 2016;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Tesla";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2019;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Collin Highwood";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}
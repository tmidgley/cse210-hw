using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "AWS";
        job1._startYear = 2000;
        job1._endYear = 2010;

        //Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}");

        Job job2 = new Job();
        job2._jobTitle = "AI Engineer";
        job2._company = "Verint";
        job2._startYear = 2010;
        job2._endYear = 2020;

        //Console.WriteLine($"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}");

        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Travis Midgley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Pathway";
        job1._jobTitle = "Peer Mentor";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "BYU";
        job2._jobTitle = "Teacher";
        job2._startYear = 2018;
        job2._endYear = 2020;


        Resume theResume = new Resume();
        theResume._name = "Sara Aceves";
        
        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);

        theResume.DisplayDetails();
    }
}
using System;




class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job(); 
        Resume resume1= new Resume();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2024;
        job1.Display();

        resume1._name = "Divine Jigu";
        resume1._jobs.Add(job1);
        
        Job job2= new Job(); 
        job2._jobTitle = "Librarian";
        job2._company = "Art Gallery";
        job2._startYear = 2011;
        job2._endYear = 2018;
        job2.Display();
        resume1._jobs.Add(job2);

        resume1.Display();





    }
}
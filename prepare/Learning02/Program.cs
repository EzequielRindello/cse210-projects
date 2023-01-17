using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Tornero";
        job1._company = "Rinaudo";
        job1._startYear = 2019;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Operario";
        job2._company = "Jhon Deere";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Ezequiel Rindello";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
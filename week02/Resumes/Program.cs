// BYU Pathway Worldwide
// Course: CSE210.002 - Programming with Classes
// Term: 2026 Block 2
// Author: Wilfredo Jose Marapacuto Verastegui
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Physical Therapist";
        job1._company = "Central Hospital";
        job1._startYear = 2010;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Business Consultant";
        job2._company = "WM Servicios Hispanos";
        job2._startYear = 2023;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Wilfredo Marapacuto";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
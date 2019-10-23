using System;

namespace Solid.Single_Responsibility
{
    public class Task
    {
        public Discipline Discipline;
        public DateTime Date;
        public string Description;

        public Task(Discipline discipline, DateTime date, string description)
        {
            Discipline = discipline;
            Date = date;
            Description = description;
        }
    }
}
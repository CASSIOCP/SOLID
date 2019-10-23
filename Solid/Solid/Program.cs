using Solid.Single_Responsibility;
using System;

namespace Solid
{
    class Program
    {
        static void Main()
        {
            #region Single Responsability Principle

            var homework = new Homework();
            homework.AddEntry(new Task(Discipline.Math, new DateTime(2019, 1, 1), "Solve the equation: x^2 + 2x + 8"));
            homework.AddEntry(new Task(Discipline.History, new DateTime(2019, 1, 3), "Research of the World War II"));
            homework.AddEntry(new Task(Discipline.English, new DateTime(2019, 2, 3), "An essay about the film industry"));

            Console.WriteLine(homework.ToString());

            Console.WriteLine();

            homework.RemoveEntry(1);

            Console.WriteLine(homework.ToString());

            Console.WriteLine();

            FileSaver.SaveToFile("Homeworks", "homework.txt", homework);
            Console.WriteLine("Homework saved to file!");

            Console.WriteLine();

            var schedule = new Schedule();
            schedule.AddEntry(new Appointment(new DateTime(2019, 2, 1), new TimeSpan(0, 30, 0), "Hospital", "Medical Check up"));
            schedule.AddEntry(new Appointment(new DateTime(2019, 2, 5), new TimeSpan(2, 15, 0), "Sports Club", "Soccer Match"));

            Console.WriteLine(schedule.ToString());

            Console.WriteLine();

            FileSaver.SaveToFile("Schedules", "schedule.txt", schedule);
            Console.WriteLine("Schedule saved to file!");
            
            Console.WriteLine();

            #endregion
        }
    }
}